using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moveplayer : MonoBehaviour
{

    [SerializeField]
    GameObject player;

    //プレイヤーのスピード
    //Rigidbody rb;
    //float speed = 5.0f;


    [SerializeField]
    private Vector3 velocity;              // 移動方向
    [SerializeField]
    private float moveSpeed = 5.0f;        // 移動速度








    void Start()
    {
        //rb = GetComponent<Rigidbody>();

        //DelayMethodを3秒後に呼び出す 
        //Invoke("DelayMethod", 3f);


    }

    void FixedUpdate()
    {
        //float x = Input.GetAxis("Horizontal");
        //float z = Input.GetAxis("Vertical");
        //rb.velocity = new Vector3(x, 0, z);
        //xとzにspeedを掛ける
        //rb.AddForce(x * speed, 0, z * speed);

        velocity = Vector3.zero;
        if (Input.GetKey(KeyCode.UpArrow))
            velocity.z += 1;
        if (Input.GetKey(KeyCode.LeftArrow))
            velocity.x -= 1;
        if (Input.GetKey(KeyCode.DownArrow))
            velocity.z -= 1;
        if (Input.GetKey(KeyCode.RightArrow))
            velocity.x += 1;

        // 速度ベクトルの長さを1秒でmoveSpeedだけ進むように調整します
        velocity = velocity.normalized * moveSpeed * Time.deltaTime;

        // いずれかの方向に移動している場合
        if (velocity.magnitude > 0)
        {
            // プレイヤーの位置(transform.position)の更新
            // 移動方向ベクトル(velocity)を足し込みます
            transform.position += velocity;
        }

    }




    void OnTriggerEnter(Collider hit)
    {
        //当たるとプレイヤー消える
        // 接触対象はPlayerタグですか？
        if (hit.CompareTag("Light1"))
        {
            SceneManager.LoadScene("Stage1Scene");

        }

        if (hit.CompareTag("Light2"))
        {
            SceneManager.LoadScene("Stage2Scene");

        }

        if (hit.CompareTag("Light3"))
        {
            SceneManager.LoadScene("Stage3Scene");

        }

        //当たるとプレイヤー消える
        // 接触対象はColiderタグですか？
        if (hit.CompareTag("Colider1"))
        {
            SceneManager.LoadScene("Stage1Scene");

        }

        if (hit.CompareTag("Colider2"))
        {
            SceneManager.LoadScene("Stage2Scene");

        }

        if (hit.CompareTag("Colider3"))
        {
            SceneManager.LoadScene("Stage3Scene");

        }




    }

}