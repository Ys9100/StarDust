using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trampoline : MonoBehaviour {
    public float Player_Jump;

    public bool Jump;



    public GameObject player;
    void OnTriggerEnter(Collider hit)
    {
        if (hit.CompareTag("Player"))
        {
            if (Jump)
            {

                player.GetComponent<Rigidbody>().AddForce(transform.up * Player_Jump * Time.deltaTime, ForceMode.Impulse);

            }
        }
    }
}
