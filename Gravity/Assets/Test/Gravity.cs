using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Gravity : MonoBehaviour
{      
        public Vector3 gravity;
        Rigidbody rb;

        void Awake()
        {
      
            rb = GetComponent<Rigidbody>();
            rb.useGravity = false;
            gravity = Physics.gravity;
            ReverseGravity();
    }
        private void Update()
        {
            if (Input.GetKey(KeyCode.Alpha0))
            {
                Debug.Log("Click");
              
            }
        }

        void FixedUpdate()
        {
            rb.AddForce(gravity * 500, ForceMode.Acceleration);
        }

        void ReverseGravity() => gravity *= -1;
    }

