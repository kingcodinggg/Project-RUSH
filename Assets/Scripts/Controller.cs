using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Controller : MonoBehaviour
{
    float screenWidth = Screen.width;

    private Rigidbody rb;
    private Rigidbody rbBuildings;
    public float turnSpeed = 5f;
    public float speed = 30f;
    public float speedIncrease = 10;
    public float zoffset = 100;
    public float zoffset2 = 138.5f;
    public float zoffset3 = 138.5f;
    public GameObject cube;
    public GameObject street;
    public GameObject buildings;
    public float waitTime = .35f;
    public Button left, right;
    int x = 1;
    int y = 1;
    public float[] values;

 
    // Start is called before the first frame update
    void Start()
    {

        values = new float[4];

        //int zoffset = Random.Range(-7108, 7100);
        zoffset = -7000;
        zoffset2 = -7138;
        zoffset3 = -7138;
        StartCoroutine(Wait());
        StartCoroutine(Wait2());
        StartCoroutine(Wait3());
        StartCoroutine(Wait4());
        StartCoroutine(Wait5());
        StartCoroutine(Wait6());
        rb = GetComponent<Rigidbody>();
        rbBuildings = buildings.GetComponent<Rigidbody>();
    }

    

    // Update is called once per frame
    void FixedUpdate()
    {
        // the grid will always be 1, 2, 3, 4, or 5 prefabs wide
            /*int xcount = Random.Range(100, 600);
            // the grid will always be 2, 3, or 4 prefabs long
            int ycount = Random.Range(200, 500);

            for (int x = 0; x != xcount; ++x)
            {
                for (int y = 0; y != ycount; ++y)
                {
                    var position = new Vector3(x * 2, zoffset, y * 2);
                    Instantiate(cube, position, Quaternion.identity);
                }
            } */

            
        rb.AddForce(Vector3.forward * speed);
        //rbBuildings.AddForce(Vector3.back * speed);
        Touch touch = Input.GetTouch(0);
        if (touch.position.x > (screenWidth / 2))
        {
            rb.AddForce(Vector3.right * turnSpeed);
        }
        else
        {
            rb.AddForce(Vector3.left * turnSpeed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * turnSpeed);
        }
        if(Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * turnSpeed);
        }
        
    }

    IEnumerator Wait()
{

            //int xcount = Random.Range(45, 22);
            //int ycount = Random.Range(1, 2);

    yield return new WaitForSeconds(waitTime);
    int xcount = Random.Range(54, 22);
    int ycount = Random.Range(0, 1);
    zoffset += 10;
     x = xcount;
     y = ycount;
     var position = new Vector3(x, y, zoffset);
    GameObject Cube = Instantiate(cube, position, Quaternion.identity) as GameObject;
        Destroy(Cube, 15);
    
        StartCoroutine(Wait());
       
}

IEnumerator Wait2()
{
    yield return new WaitForSeconds(4f);
    speed = speed + speedIncrease;
    StartCoroutine(Wait2());
}

IEnumerator Wait3()
    {
        yield return new WaitForSeconds(15f);
        waitTime = waitTime - .02f;
        StartCoroutine(Wait3());
    }

    IEnumerator Wait4()
    {
        yield return new WaitForSeconds(210f);
        speedIncrease = speedIncrease + 10;
        StartCoroutine(Wait4());
    }

    IEnumerator Wait5()
    {

        //int xcount = Random.Range(45, 22);
        //int ycount = Random.Range(1, 2);

        yield return new WaitForSeconds(1f);
        
        zoffset2 += 138.5f;
       
        var position = new Vector3(37.8f, 0.017748f, zoffset2);
        GameObject Street = Instantiate(street, position, Quaternion.identity) as GameObject;
        //Destroy(Street, 15);

        StartCoroutine(Wait5());

    }

    IEnumerator Wait6()
    {

        //int xcount = Random.Range(45, 22);
        //int ycount = Random.Range(1, 2);

        yield return new WaitForSeconds(2f);

        zoffset3 += 138.5f;

        var position2 = new Vector3(37.8f, 25f, zoffset3);
        GameObject Buildings = Instantiate(buildings, position2, Quaternion.identity) as GameObject;
        //Destroy(Street, 15);
        yield return new WaitForSeconds(2f);
        Destroy(Buildings, 30);

        StartCoroutine(Wait6());

    }

}
