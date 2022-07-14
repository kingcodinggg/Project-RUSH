using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MeterCounter : MonoBehaviour
{
    public TextMeshProUGUI distanceText;
    private Vector3 lastPosition;
    private float totalDistance;

    void Start()
    {
        lastPosition = transform.position;
    }

    void Update()
    {
        float distance = Vector3.Distance(lastPosition, transform.position);
        totalDistance += distance;
        lastPosition = transform.position;
        // TODO:
        print(totalDistance);
        distanceText.text = "Distance: " + totalDistance.ToString ("0") + "m";
        // here you would display the value of
        // odometerDistance somehow, probably using UI.
    }
}
