using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class respawnstage2 : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider hit)
    {

        if (hit.CompareTag("Player"))
        {
            SceneManager.LoadScene("Stage2Scene");

        }
    }
}
