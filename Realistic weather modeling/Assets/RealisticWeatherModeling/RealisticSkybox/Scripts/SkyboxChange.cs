using UnityEngine;

public class SkyboxChange : MonoBehaviour
{
    public GameObject Sun;
    [Range(0.0f, 23.999f)]
    public float Hour;
    [Range(0.0f, 1.0f)]
    public float Thunder;
    public Material Sky;

    private float sunriseHour = 8f;

    private float solarAngle;

    private void Start()
    {
        
    }

    private void FixedUpdate()
    {
        CalculateSunPosition();
    }

    private void CalculateSunPosition()
    {
        solarAngle = 15f * (Hour - sunriseHour);
        //if (solarAngle < 0f)
        //{
        //    solarAngle = Mathf.Abs(solarAngle);
        //}
        Quaternion sunRotation = Quaternion.Euler(solarAngle, 0f, 0f);
        Sun.transform.rotation = sunRotation;
        //Debug.Log("Sun angle: " + solarAngle + " degree");
    }

}
