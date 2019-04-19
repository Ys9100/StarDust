using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.AI;

public class Chase : MonoBehaviour
{

    //ターゲットのGameObject
    public GameObject target;


    //追いかける側のNavMeshAgent
    private NavMeshAgent agent;


    public bool isitemhit = false;

    // Use this for initialization
    void Start()
    {
        //NavMeshAgentを獲得
        agent = GetComponent<NavMeshAgent>();

    }

    //トリガーと接触した場合

    //itemのtriggerの当たり判定
    //void OnTriggerStay(Collider hit)
    //{

    //    if (hit.CompareTag("Item"))
    //    {

    //            //エネミーの角度の調節
    //            transform.LookAt(hit.transform.position);
    //            //アイテムから遠ざかる
    //            transform.position += transform.forward * -0.01f;
    //        freeze++;
    //    }
    //}



    void OnTriggerEnter(Collider hit)
    {
        // 接触対象はPlayerタグですか？
        if (hit.CompareTag("Player"))
        {
            if (isitemhit == false)
            {
                // ターゲットの位置を目的地に設定する。
                agent.destination = target.transform.position;
            }
        }
    }

    /// <summary>
    /// 敵がアイテムに驚く処理
    /// </summary>
    /// <returns></returns>
    IEnumerator ChaseStop()
    {
        // agent中断
        agent.isStopped = true;
        // アイテムから○○メートル下がる
        yield return new WaitForSeconds(1.0f);

        while (true)
        {
            // まだアイテムがあるならここで関数中断
            if (isitemhit == true)
            {
                yield return null;
            }

            // もしアイテムがないなら
            if (isitemhit == false)
            {
                break;
            }
        }

        // agent再開
        agent.isStopped = false;
    }

}
