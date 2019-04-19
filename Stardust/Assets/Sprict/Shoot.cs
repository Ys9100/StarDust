using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public int bulletnum = 0;

    public int deletebullet = 0;
    // bullet prefab
    public GameObject bullet;

    // 弾丸発射点
    public Transform muzzle;

    // 弾丸の速度
    public float speed = 0.98f;





    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {



        // z キーが押された時
        if (Input.GetKeyDown(KeyCode.Z) && bulletnum > 0)
        {

            // 弾丸の複製
            GameObject bullets = Instantiate(bullet) as GameObject;

            Vector3 force;

            force = this.gameObject.transform.forward * speed;

            // Rigidbodyに力を加えて発射
            bullets.GetComponent<Rigidbody>().AddForce(force);

            // 弾丸の位置を調整
            bullets.transform.position = muzzle.position;



            //弾の数調整
            bulletnum--;

            deletebullet++;


        }

    }

    void OnTriggerEnter(Collider hit)
    {
        // 接触対象はitemタグですか？
        if (hit.CompareTag("Item"))
        {
            Destroy(hit.gameObject);
            //Destroy(bullet);
            //弾を獲得する
            bulletnum++;

        }
    }
}
