using UnityEngine;
using UnityEngine.InputSystem;

public class MovementController : MonoBehaviour
{
    public float speedMultiplier = 3f;
    public float maxSpeed = 4f;
    public float speedSmooth = 5f;

    private float currentSpeed = 0f;
    public bool canMove = true;

    void Update()
    {
        if (!canMove) return;
        if (Accelerometer.current == null) return;

        // Eje Z invertido por el sistema de coordenadas del dispositivo
        float z = -Accelerometer.current.acceleration.ReadValue().z;

        float desiredSpeed = Mathf.Clamp(z * speedMultiplier, -maxSpeed, maxSpeed);

        currentSpeed = Mathf.Lerp(currentSpeed, desiredSpeed, Time.deltaTime * speedSmooth);

        transform.position += transform.forward * currentSpeed * Time.deltaTime;
    }
}
