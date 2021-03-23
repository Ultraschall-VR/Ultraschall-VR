#ifndef VOLUMETRIC_LIGHTS_CUSTOM_SHADOW
#define VOLUMETRIC_LIGHTS_CUSTOM_SHADOW

TEXTURE2D(_ShadowTexture);
SAMPLER(sampler_ShadowTexture);
float4x4 _ShadowMatrix;

float4 shadowTextureStart;
float4 shadowTextureEnd;
half3 _ShadowIntensity;

TEXTURE2D(_Cookie2D);
SAMPLER(sampler_Cookie2D);

void ComputeShadowTextureCoords(float3 rayStart, float3 rayDir, float t0, float t1) {
    shadowTextureStart = mul(_ShadowMatrix, float4(rayStart + rayDir * t0, 1.0));
    shadowTextureEnd = mul(_ShadowMatrix, float4(rayStart + rayDir * t1, 1.0));
}

half SampleShadowMap(inout float4 shadowCoords) {
    float shadowDepth = SAMPLE_DEPTH_TEXTURE(_ShadowTexture, sampler_ShadowTexture, shadowCoords.xy );
    #if UNITY_REVERSED_Z
        shadowCoords.z = shadowCoords.w - shadowCoords.z;
        shadowDepth = shadowCoords.w - shadowDepth;
    #endif
#if VL_POINT
    shadowCoords.z = clamp(shadowCoords.z, -shadowCoords.w, shadowCoords.w);
#endif    
    half shadowTest = shadowCoords.z<0 || shadowDepth > shadowCoords.z;
    return shadowTest;
}

inline half3 UnitySpotCookie(float4 lightCoord) {
    half4 cookie = SAMPLE_TEXTURE2D_LOD(_Cookie2D, sampler_Cookie2D, lightCoord.xy, 0);
    return cookie.rgb;
}


half3 GetShadowAtten(float x) {
    float4 shadowCoords = lerp(shadowTextureStart, shadowTextureEnd, x);
    shadowCoords.xyz /= shadowCoords.w;

    #if VL_SPOT_COOKIE
        half3 s = UnitySpotCookie(shadowCoords);
    #else
        half3 s = 1.0.xxx;
    #endif

    #if VL_SHADOWS
	    half sm = SampleShadowMap(shadowCoords);
	    sm = sm * _ShadowIntensity.x + _ShadowIntensity.y;
	    s *= sm;
    #endif

    return s;
}


half3 GetShadowAttenWS(float3 wpos) {
    float4 shadowCoords = mul(_ShadowMatrix, float4(wpos, 1.0));
    shadowCoords.xyz /= shadowCoords.w;
    #if VL_SPOT_COOKIE
        half3 shadowTest = UnitySpotCookie(shadowCoords);
    #else
        half3 shadowTest = 1.0.xxx;
    #endif

    #if VL_SHADOWS
	    shadowTest *= SampleShadowMap(shadowCoords);
	    // ignore particles outside of shadow map
	    float inMap = all(shadowCoords.xy > 0.0.xx && shadowCoords.xy < 1.0.xx);
	    shadowTest *= (half)inMap;
    #endif
    return shadowTest;
}


#endif // VOLUMETRIC_LIGHTS_CUSTOM_SHADOW

