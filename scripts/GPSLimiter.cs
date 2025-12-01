using UnityEngine;
using System.Collections;

public class GPSLimiter : MonoBehaviour
{
    public float minLat;
    public float maxLat;
    public float minLon;
    public float maxLon;

    private MovementController movement;

    void Start()
    {
        movement = GetComponent<MovementController>();
        StartCoroutine(StartGPS());
    }

    IEnumerator StartGPS()
    {
        if (!Input.location.isEnabledByUser)
            yield break;

        Input.location.Start(1f, 1f);

        int wait = 20;
        while (Input.location.status == LocationServiceStatus.Initializing && wait > 0)
        {
            wait--;
            yield return new WaitForSeconds(1);
        }
    }

    void Update()
    {
        if (Input.location.status != LocationServiceStatus.Running)
            return;

        var d = Input.location.lastData;

        bool outside =
            d.latitude < minLat ||
            d.latitude > maxLat ||
            d.longitude < minLon ||
            d.longitude > maxLon;

        movement.canMove = !outside;
    }
}
