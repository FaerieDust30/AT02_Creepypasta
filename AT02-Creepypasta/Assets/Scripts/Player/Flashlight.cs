using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Faye Butler 6/05/24

public class Flashlight : MonoBehaviour
{
    public float maxIntensity = 5f;
    public float minIntensity = 0f;
    public float fadeSpeed;
    public float fadeTime;
    public float chargeSpeed;
    public float chargeTime;

    private Light fLight;

    // Start is called before the first frame update
    void Start()
    {
        fLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        flashlightFade();
        flashlightCrank();
    }

    private void flashlightCrank()
    {
        if (Input.GetButton("Flashlight") == true)
        {
            chargeTime = Time.deltaTime / chargeSpeed;
            fLight.intensity = Mathf.Lerp(fLight.intensity, maxIntensity, chargeTime);
            fadeTime = 0f;
            if(chargeTime > chargeSpeed)
            {
                chargeTime = chargeSpeed;
            }
        }
    }

    private void flashlightFade()
    {
        if (Input.GetButton("Flashlight") == false)
        {
            chargeTime = 0f;
            if (fadeTime < fadeSpeed)
            {
                fLight.intensity = Mathf.Lerp(fLight.intensity, minIntensity, fadeTime / fadeSpeed);
                fadeTime += Time.deltaTime;
                if (fadeTime > fadeSpeed)
                {
                    fadeTime = fadeSpeed;
                }
            }
        }
    }
}
