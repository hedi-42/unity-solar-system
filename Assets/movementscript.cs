using UnityEngine;

public class PlanetMovement : MonoBehaviour
{
    // Rotation speeds for the Sun, Earth, and Moon
    public float sunRotationSpeed = 10f;
    public float earthRotationSpeed = 20f;
    public float moonRotationSpeed = 30f;


    void Update()
    {
        // Rotate the Sun (parent)
        transform.Rotate(Vector3.up, sunRotationSpeed * Time.deltaTime);

        // Rotate the Earth (child of the Sun)
        transform.GetChild(0).Rotate(Vector3.up, earthRotationSpeed * Time.deltaTime);

        // Rotate the Moon (child of the Earth)
        transform.GetChild(0).GetChild(0).Rotate(Vector3.up, moonRotationSpeed * Time.deltaTime);
    }
}
