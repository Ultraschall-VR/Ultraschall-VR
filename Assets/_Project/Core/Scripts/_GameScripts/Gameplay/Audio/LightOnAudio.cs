﻿using UnityEngine;

namespace Echosystem.Resonance.Prototyping
{
    [RequireComponent(typeof(Light))]
    public class LightOnAudio : MonoBehaviour
    {
        [SerializeField] public AudioPeer AudioPeer;
        [SerializeField] private bool _fromOtherObject;
        [Range(0, 8)] [SerializeField] private int _band = 3;
        [SerializeField] private float _minIntensity = 0, _maxIntesity = 1;
        private Light _light;

        // Start is called before the first frame update
        void Start()
        {
            if (!_fromOtherObject)
            {
                AudioPeer = GetComponent<AudioPeer>();
            }

            _light = GetComponent<Light>();
            _light.intensity = 0f;
        }

        // Update is called once per frame
        void Update()
        {
            _light.intensity = (AudioPeer._audioBandBuffer[_band] * (_maxIntesity - _minIntensity)) + _minIntensity;
        }
    }
}