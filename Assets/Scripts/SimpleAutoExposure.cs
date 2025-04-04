using UnityEngine;

public class SimpleAutoExposure : MonoBehaviour
{
    private Camera _camera;
    public float minExposure = 2.5f;
    public float maxExposure = 9.0f;
    public float exposureSpeed = 1.0f;
    public Light sceneLight;

    private void Start()
    {
        _camera = GetComponent<Camera>();
        if (sceneLight == null)
        {
            sceneLight = FindObjectOfType<Light>();
        }
    }

    private void Update()
    {
        // Simulate exposure based on the scene light intensity
        float brightness = CalculateSceneBrightness();

        // Adjust exposure in a simple way by modifying the light intensity
        float exposure = Mathf.Clamp(brightness, minExposure, maxExposure);

        // Apply the exposure to the light intensity
        if (sceneLight != null)
        {
            sceneLight.intensity = exposure;
        }
    }

    private float CalculateSceneBrightness()
    {
        // A simplified method to adjust exposure dynamically (based on time in this case)
        // For more realistic results, consider sampling pixel brightness or other scene attributes.
        return Mathf.PingPong(Time.time * exposureSpeed, maxExposure);
    }
}

