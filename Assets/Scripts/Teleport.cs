//======= Copyright (c) Valve Corporation, All rights reserved. ===============

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

namespace Valve.VR.InteractionSystem.Sample
{
    public class Teleport : MonoBehaviour
    {
        public GameObject playerObject;

        public void OnButtonPressedRed(Hand fromHand)
        {
            playerObject.transform.position = new Vector3(-14f, 25.5f, -14f);
            fromHand.TriggerHapticPulse(1000);
        }

        public void OnButtonPressedBlue(Hand fromHand)
        {
            playerObject.transform.position = new Vector3(-14f, 25.5f, 14f);
            fromHand.TriggerHapticPulse(1000);
        }

        public void OnButtonPressedGreen(Hand fromHand)
        {
            playerObject.transform.position = new Vector3(14f, 25.5f, -14f);
            fromHand.TriggerHapticPulse(1000);
        }

        public void OnButtonPressedYellow(Hand fromHand)
        {
            playerObject.transform.position = new Vector3(14f, 25.5f, 14f);
            fromHand.TriggerHapticPulse(1000);
        }

        public void OnButtonUp(Hand fromHand)
        {
        }
    }
}