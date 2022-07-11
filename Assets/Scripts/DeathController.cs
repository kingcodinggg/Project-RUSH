using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathController : MonoBehaviour
{
    public GameObject DeathScreen;
    // Start is called before the first frame update
    void Start()
    {
        DeathScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Dumpster")
        {
            DeathScreen.SetActive(true);
        }
    }

    public void restart()
    {
        SceneManager.LoadScene("level");
    }
}
