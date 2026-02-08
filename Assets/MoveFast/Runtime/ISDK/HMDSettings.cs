// Copyright (c) Meta Platforms, Inc. and affiliates.

using UnityEngine;

namespace Oculus.Interaction.MoveFast
{
    /// <summary>
    /// Sets the target framerate to 90fps
    /// </summary>
    public class HMDSettings : MonoBehaviour
    {
        [SerializeField]
        private float _fps = 90;

        private void Start()
        {
            if (OVRManager.display != null)
            {
                OVRManager.display.displayFrequency = _fps;
            }
            OVRManager.useDynamicFoveatedRendering = true;
        }
    }
}
