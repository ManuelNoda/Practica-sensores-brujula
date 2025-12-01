using UnityEngine;
using UnityEngine.InputSystem;

public class EnableSensors : MonoBehaviour
{
    void OnEnable()
    {
        EnableDevice(Accelerometer.current);
        EnableDevice(UnityEngine.InputSystem.Gyroscope.current);
        EnableDevice(GravitySensor.current);
        EnableDevice(AttitudeSensor.current);
        EnableDevice(LinearAccelerationSensor.current);
        EnableDevice(MagneticFieldSensor.current);
        EnableDevice(LightSensor.current);
        EnableDevice(PressureSensor.current);
        EnableDevice(ProximitySensor.current);
        EnableDevice(HumiditySensor.current);
        EnableDevice(AmbientTemperatureSensor.current);
        EnableDevice(StepCounter.current);
    }

    void OnDisable()
    {
        DisableDevice(Accelerometer.current);
        DisableDevice(UnityEngine.InputSystem.Gyroscope.current);
        DisableDevice(GravitySensor.current);
        DisableDevice(AttitudeSensor.current);
        DisableDevice(LinearAccelerationSensor.current);
        DisableDevice(MagneticFieldSensor.current);
        DisableDevice(LightSensor.current);
        DisableDevice(PressureSensor.current);
        DisableDevice(ProximitySensor.current);
        DisableDevice(HumiditySensor.current);
        DisableDevice(AmbientTemperatureSensor.current);
        DisableDevice(StepCounter.current);
    }

    void EnableDevice(InputDevice device)
    {
        if (device != null && !device.enabled)
            InputSystem.EnableDevice(device);
    }

    void DisableDevice(InputDevice device)
    {
        if (device != null && device.enabled)
            InputSystem.DisableDevice(device);
    }
}
