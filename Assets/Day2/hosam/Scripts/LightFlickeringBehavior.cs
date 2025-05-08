using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

public class LightFlickeringBehavior : MonoBehaviour
{
    [SerializeField] float flickerDuration = 1f; // Duration of flicker in seconds
    [SerializeField] bool initialState = true; // Interval between flickers in seconds

    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= flickerDuration)
        {
            
            initialState = !initialState;
            
            Array.ForEach(gameObject.GetComponentsInChildren<Light>(),light => light.enabled=initialState); // Set the light state

            timer = 0f; // restart the timer
        }
    }
}
