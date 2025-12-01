using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class SensorUI : MonoBehaviour
{
    public TextMeshProUGUI txtAccelerometer;
    public TextMeshProUGUI txtGyro;
    public TextMeshProUGUI txtGravity;
    public TextMeshProUGUI txtAttitude;
    public TextMeshProUGUI txtLinearAcc;
    public TextMeshProUGUI txtMagnetic;
    public TextMeshProUGUI txtLight;
    public TextMeshProUGUI txtPressure;
    public TextMeshProUGUI txtProximity;
    public TextMeshProUGUI txtHumidity;
    public TextMeshProUGUI txtTemperature;
    public TextMeshProUGUI txtSteps;

    void Update()
    {
        if (Accelerometer.current != null)
            txtAccelerometer.text = $"Accelerometer: {Accelerometer.current.acceleration.ReadValue()}";

        if (UnityEngine.InputSystem.Gyroscope.current != null)
            txtGyro.text = $"Gyroscope: {UnityEngine.InputSystem.Gyroscope.current.angularVelocity.ReadValue()}";

        if (GravitySensor.current != null)
            txtGravity.text = $"Gravity: {GravitySensor.current.gravity.ReadValue()}";

        if (AttitudeSensor.current != null)
            txtAttitude.text = $"Attitude: {AttitudeSensor.current.attitude.ReadValue()}";

        if (LinearAccelerationSensor.current != null)
            txtLinearAcc.text = $"Linear Acc: {LinearAccelerationSensor.current.acceleration.ReadValue()}";

        if (MagneticFieldSensor.current != null)
            txtMagnetic.text = $"Magnetic: {MagneticFieldSensor.current.magneticField.ReadValue()}";

        if (LightSensor.current != null)
            txtLight.text = $"Light: {LightSensor.current.lightLevel.ReadValue()}";

        if (PressureSensor.current != null)
            txtPressure.text = $"Pressure: {PressureSensor.current.atmosphericPressure.ReadValue()}";

        if (ProximitySensor.current != null)
            txtProximity.text = $"Proximity: {ProximitySensor.current.distance.ReadValue()}";

        if (HumiditySensor.current != null)
            txtHumidity.text = $"Humidity: {HumiditySensor.current.relativeHumidity.ReadValue()}";

        if (AmbientTemperatureSensor.current != null)
            txtTemperature.text = $"Temperature: {AmbientTemperatureSensor.current.ambientTemperature.ReadValue()}";

        if (StepCounter.current != null)
            txtSteps.text = $"Steps: {StepCounter.current.stepCounter.ReadValue()}";
    }
}
