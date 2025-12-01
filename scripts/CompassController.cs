using UnityEngine;

public class CompassController : MonoBehaviour
{
    public float rotationSpeed = 5f;
    public float headingOffset = 0f;

    void Start()
    {
        Input.compass.enabled = true;
    }

    void Update()
    {
        if (!Input.compass.enabled)
            return;

        // Dirección hacia el norte
        float north = Input.compass.trueHeading;

        // SOLO rotamos en Y , nada de pitch/roll
        Quaternion targetRotation = Quaternion.Euler(0, north + headingOffset, 0);

        transform.rotation = Quaternion.Slerp(
            transform.rotation,
            targetRotation,
            Time.deltaTime * rotationSpeed
        );
    }
}
