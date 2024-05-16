using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Faye Butler 16/05/24

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
            if (fLight.intensity < maxIntensity)
            {
                fLight.intensity += Time.deltaTime * chargeSpeed;  //Mathf.Lerp(fLight.intensity, maxIntensity, chargeTime/chargeSpeed);
                fadeTime = 0f;
            }
            //chargeTime += Time.deltaTime;
            if (chargeTime > chargeSpeed)
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
                if (fLight.intensity > 0f)
                {
                    fLight.intensity -= Time.deltaTime * fadeSpeed; //Mathf.Lerp(fLight.intensity, minIntensity, fadeTime / fadeSpeed);
                    //fadeTime += Time.deltaTime;
                }
                if (fadeTime > fadeSpeed)
                {
                        fadeTime = fadeSpeed;
                }
            }
        }
    }
}
