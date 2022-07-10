using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsClick : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject player;
    public Button left;
    public Button right;
    public float turnSpeed = 90f;
    // Start is called before the first frame update
    void Start()
    {
        rb = player.GetComponent<Rigidbody>();
    }

    public void onClickLeft()
    {
        rb.AddForce(Vector3.left * turnSpeed);
    }
    public void onClickRight()
    {
        rb.AddForce(Vector3.right * turnSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Touch touch in Input.touches)
        {
            if ((touch.position.x > Screen.width / 2) && (touch.phase == TouchPhase.Began))
            {
                rb.AddForce(Vector3.left * turnSpeed);
            }
            if ((touch.position.x < Screen.width / 2) && (touch.phase == TouchPhase.Began))
            {
                rb.AddForce(Vector3.right * turnSpeed);
            }
        }
    }
}
