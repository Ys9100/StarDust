using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemycolider : MonoBehaviour
{

    public GameObject enemy;

    public Chase enemychase;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerStay(Collider hit)
    {
        if (hit.CompareTag("Item"))
        {
            enemy.transform.LookAt(hit.transform.position);

            enemy.transform.position += transform.forward * -0.01f;
        }
    }

    void OnTriggerEnter(Collider hit)
    {
        if (hit.CompareTag("Item"))
        {
            enemychase.isitemhit = true;

            enemy.GetComponent<UnityEngine.AI.NavMeshAgent>().isStopped = true;
        }
    }

    void OnTriggerExit(Collider hit)
    {
        if (hit.CompareTag("Item"))
        {
            enemychase.isitemhit = false;

            enemy.GetComponent<UnityEngine.AI.NavMeshAgent>().isStopped = false;
        }
    }
}
