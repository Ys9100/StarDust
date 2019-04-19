using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    [RequireComponent(typeof(Rigidbody))]
    public class RotateFloor : MonoBehaviour
    {
        public float m_rotateSpeed = 50;
        public Rigidbody m_rigidbody = null;

        private float m_angle;

        private void Reset()
        {
            m_rigidbody = GetComponent<Rigidbody>();
            m_rigidbody.isKinematic = true;
        }

        private void Update()
        {
            m_angle += m_rotateSpeed * Time.deltaTime;


            var rotation = Quaternion.Euler(0, m_angle, 0);
            m_rigidbody.MoveRotation(rotation);
        }
    }
