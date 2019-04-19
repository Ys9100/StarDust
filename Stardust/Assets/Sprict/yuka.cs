using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class yuka : MonoBehaviour
{
    public float m_length = 5;
    public Rigidbody m_rigidbody = null;

    private void Reset()
    {
        m_rigidbody = GetComponent<Rigidbody>();
        m_rigidbody.isKinematic = true;
    }

    private void Update()
    {
        var basePos = transform.position;
        var y = Mathf.PingPong(Time.time, m_length);
        var position = new Vector3(basePos.x, y, basePos.z);

        m_rigidbody.MovePosition(position);
    }

}

