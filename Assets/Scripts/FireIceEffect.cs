//======= Copyright (c) Valve Corporation, All rights reserved. ===============

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

namespace Valve.VR.InteractionSystem.Sample
{
    public class FireIceEffect : MonoBehaviour
    {
        public GameObject fireObject;

        public void OnButtonPressedFire(Hand fromHand)
        {
            fireObject.SetActive(true);
            fromHand.TriggerHapticPulse(1000);
        }

        public void OnButtonUp(Hand fromHand)
        {
        }
    }
}