using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BuildingHandler : MonoBehaviour
{
    Animator anim;
    public float speedMultiplier = 1f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait());
        anim = GetComponent<Animator>();
        anim.Play("BuildingMove");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //print("Collided with trigger!");
        //transform.position = new Vector3(42, 26, -7052);
    }

    IEnumerator Wait()
    {

        //int xcount = Random.Range(45, 22);
        //int ycount = Random.Range(1, 2);

        yield return new WaitForSeconds(5f);

        speedMultiplier = speedMultiplier + .5f;
        anim.SetFloat("SpeedMultiplier", speedMultiplier);
            
        StartCoroutine(Wait());

    }
}
