using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Faye Butler 6/05/24

public class Flashlight : MonoBehaviour
{
    [SerializeField] private GameObject light;

    private void Awake()
    {
        light.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FlashlightToggle();
    }

    private void FlashlightToggle()
    {
        if (Input.GetButtonDown("Flashlight") == true)
        {
            light.SetActive(!light.activeSelf);
        }
    }
}
