using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect : MonoBehaviour
{

    private ParticleSystem effect;



    public GameObject player;




    int i;
    bool flag = false;




    // Use this for initialization
    void Start()
    {

        effect = this.GetComponent<ParticleSystem>();
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position;


        if (flag == true)
        {
            i++;
        }

        if (i >= 100)
        {
            Destroy(gameObject);
        }


    }




    void OnTriggerEnter(Collider hit)
    {
        //当たるとプレイヤー消える
        // 接触対象はPlayerタグですか？
        if (hit.CompareTag("Light"))
        {
            flag = true;

            effect.Play();
            Debug.Log("起動");

        }

        //当たるとプレイヤー消える
        // 接触対象はColiderタグですか？
        if (hit.CompareTag("Colider"))
        {
            flag = true;

            effect.Play();
            Debug.Log("起動");

        }

    }
}
