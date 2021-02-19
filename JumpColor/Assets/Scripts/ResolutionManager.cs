using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResolutionManager : MonoBehaviour
{
    Resolution resolution;

    private void Awake()
    {
        resolution = Screen.currentResolution;

        if (resolution.width <= 1080)
        {
            if (resolution.height <= 1920)
            {
                Camera.main.orthographicSize = 5;
            }

            if (resolution.height > 1920)
            {
                Camera.main.orthographicSize = 6;
            }
        }

        if (resolution.width > 1080)
        {
            if (resolution.height <= 2560)
            {
                Camera.main.orthographicSize = 5;
            }

            if (resolution.height > 2560)
            {
                Camera.main.orthographicSize = 6;
            }
        }
    }
}

