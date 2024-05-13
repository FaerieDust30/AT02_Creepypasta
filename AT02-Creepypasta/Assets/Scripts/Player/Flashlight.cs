using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Faye Butler 6/05/24

public class Flashlight : MonoBehaviour
{
    public float maxIntensity = 5f;
    public float minIntensity = 0f;
    public float fadeSpeed = 0.5f;

    private Light light;

    private void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        light.intensity = Mathf.Lerp(minIntensity, maxIntensity, Time.time/10);
    }

}
