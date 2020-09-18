//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Valve.VR
{
    using System;
    using UnityEngine;
    
    
    public partial class SteamVR_Actions
    {
        
        private static SteamVR_Action_Boolean p_ultraschallVR_AnyTriggerPressed;
        
        private static SteamVR_Action_Boolean p_ultraschallVR_HeadsetOnHead;
        
        private static SteamVR_Action_Vector2 p_ultraschallVR_TouchpadPosition;
        
        private static SteamVR_Action_Boolean p_ultraschallVR_TouchpadPressed;
        
        private static SteamVR_Action_Boolean p_ultraschallVR_LeftTriggerPressed;
        
        private static SteamVR_Action_Boolean p_ultraschallVR_RightTriggerPressed;
        
        private static SteamVR_Action_Pose p_ultraschallVR_Pose;
        
        private static SteamVR_Action_Boolean p_ultraschallVR_RightAPressed;
        
        private static SteamVR_Action_Vibration p_ultraschallVR_Haptic;
        
        public static SteamVR_Action_Boolean ultraschallVR_AnyTriggerPressed
        {
            get
            {
                return SteamVR_Actions.p_ultraschallVR_AnyTriggerPressed.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean ultraschallVR_HeadsetOnHead
        {
            get
            {
                return SteamVR_Actions.p_ultraschallVR_HeadsetOnHead.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Vector2 ultraschallVR_TouchpadPosition
        {
            get
            {
                return SteamVR_Actions.p_ultraschallVR_TouchpadPosition.GetCopy<SteamVR_Action_Vector2>();
            }
        }
        
        public static SteamVR_Action_Boolean ultraschallVR_TouchpadPressed
        {
            get
            {
                return SteamVR_Actions.p_ultraschallVR_TouchpadPressed.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean ultraschallVR_LeftTriggerPressed
        {
            get
            {
                return SteamVR_Actions.p_ultraschallVR_LeftTriggerPressed.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean ultraschallVR_RightTriggerPressed
        {
            get
            {
                return SteamVR_Actions.p_ultraschallVR_RightTriggerPressed.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Pose ultraschallVR_Pose
        {
            get
            {
                return SteamVR_Actions.p_ultraschallVR_Pose.GetCopy<SteamVR_Action_Pose>();
            }
        }
        
        public static SteamVR_Action_Boolean ultraschallVR_RightAPressed
        {
            get
            {
                return SteamVR_Actions.p_ultraschallVR_RightAPressed.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Vibration ultraschallVR_Haptic
        {
            get
            {
                return SteamVR_Actions.p_ultraschallVR_Haptic.GetCopy<SteamVR_Action_Vibration>();
            }
        }
        
        private static void InitializeActionArrays()
        {
            Valve.VR.SteamVR_Input.actions = new Valve.VR.SteamVR_Action[] {
                    SteamVR_Actions.ultraschallVR_AnyTriggerPressed,
                    SteamVR_Actions.ultraschallVR_HeadsetOnHead,
                    SteamVR_Actions.ultraschallVR_TouchpadPosition,
                    SteamVR_Actions.ultraschallVR_TouchpadPressed,
                    SteamVR_Actions.ultraschallVR_LeftTriggerPressed,
                    SteamVR_Actions.ultraschallVR_RightTriggerPressed,
                    SteamVR_Actions.ultraschallVR_Pose,
                    SteamVR_Actions.ultraschallVR_RightAPressed,
                    SteamVR_Actions.ultraschallVR_Haptic};
            Valve.VR.SteamVR_Input.actionsIn = new Valve.VR.ISteamVR_Action_In[] {
                    SteamVR_Actions.ultraschallVR_AnyTriggerPressed,
                    SteamVR_Actions.ultraschallVR_HeadsetOnHead,
                    SteamVR_Actions.ultraschallVR_TouchpadPosition,
                    SteamVR_Actions.ultraschallVR_TouchpadPressed,
                    SteamVR_Actions.ultraschallVR_LeftTriggerPressed,
                    SteamVR_Actions.ultraschallVR_RightTriggerPressed,
                    SteamVR_Actions.ultraschallVR_Pose,
                    SteamVR_Actions.ultraschallVR_RightAPressed};
            Valve.VR.SteamVR_Input.actionsOut = new Valve.VR.ISteamVR_Action_Out[] {
                    SteamVR_Actions.ultraschallVR_Haptic};
            Valve.VR.SteamVR_Input.actionsVibration = new Valve.VR.SteamVR_Action_Vibration[] {
                    SteamVR_Actions.ultraschallVR_Haptic};
            Valve.VR.SteamVR_Input.actionsPose = new Valve.VR.SteamVR_Action_Pose[] {
                    SteamVR_Actions.ultraschallVR_Pose};
            Valve.VR.SteamVR_Input.actionsBoolean = new Valve.VR.SteamVR_Action_Boolean[] {
                    SteamVR_Actions.ultraschallVR_AnyTriggerPressed,
                    SteamVR_Actions.ultraschallVR_HeadsetOnHead,
                    SteamVR_Actions.ultraschallVR_TouchpadPressed,
                    SteamVR_Actions.ultraschallVR_LeftTriggerPressed,
                    SteamVR_Actions.ultraschallVR_RightTriggerPressed,
                    SteamVR_Actions.ultraschallVR_RightAPressed};
            Valve.VR.SteamVR_Input.actionsSingle = new Valve.VR.SteamVR_Action_Single[0];
            Valve.VR.SteamVR_Input.actionsVector2 = new Valve.VR.SteamVR_Action_Vector2[] {
                    SteamVR_Actions.ultraschallVR_TouchpadPosition};
            Valve.VR.SteamVR_Input.actionsVector3 = new Valve.VR.SteamVR_Action_Vector3[0];
            Valve.VR.SteamVR_Input.actionsSkeleton = new Valve.VR.SteamVR_Action_Skeleton[0];
            Valve.VR.SteamVR_Input.actionsNonPoseNonSkeletonIn = new Valve.VR.ISteamVR_Action_In[] {
                    SteamVR_Actions.ultraschallVR_AnyTriggerPressed,
                    SteamVR_Actions.ultraschallVR_HeadsetOnHead,
                    SteamVR_Actions.ultraschallVR_TouchpadPosition,
                    SteamVR_Actions.ultraschallVR_TouchpadPressed,
                    SteamVR_Actions.ultraschallVR_LeftTriggerPressed,
                    SteamVR_Actions.ultraschallVR_RightTriggerPressed,
                    SteamVR_Actions.ultraschallVR_RightAPressed};
        }
        
        private static void PreInitActions()
        {
            SteamVR_Actions.p_ultraschallVR_AnyTriggerPressed = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/UltraschallVR/in/AnyTriggerPressed")));
            SteamVR_Actions.p_ultraschallVR_HeadsetOnHead = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/UltraschallVR/in/HeadsetOnHead")));
            SteamVR_Actions.p_ultraschallVR_TouchpadPosition = ((SteamVR_Action_Vector2)(SteamVR_Action.Create<SteamVR_Action_Vector2>("/actions/UltraschallVR/in/TouchpadPosition")));
            SteamVR_Actions.p_ultraschallVR_TouchpadPressed = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/UltraschallVR/in/TouchpadPressed")));
            SteamVR_Actions.p_ultraschallVR_LeftTriggerPressed = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/UltraschallVR/in/LeftTriggerPressed")));
            SteamVR_Actions.p_ultraschallVR_RightTriggerPressed = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/UltraschallVR/in/RightTriggerPressed")));
            SteamVR_Actions.p_ultraschallVR_Pose = ((SteamVR_Action_Pose)(SteamVR_Action.Create<SteamVR_Action_Pose>("/actions/UltraschallVR/in/Pose")));
            SteamVR_Actions.p_ultraschallVR_RightAPressed = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/UltraschallVR/in/RightAPressed")));
            SteamVR_Actions.p_ultraschallVR_Haptic = ((SteamVR_Action_Vibration)(SteamVR_Action.Create<SteamVR_Action_Vibration>("/actions/UltraschallVR/out/Haptic")));
        }
    }
}
