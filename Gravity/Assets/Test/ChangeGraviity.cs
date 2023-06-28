using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGraviity : MonoBehaviour
{
    public int koef = 1;
    public Rigidbody player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha0))
        {
            Debug.Log("Click");
           // Physics.gravity = Vector3.up;

            player.useGravity = false;
            player.AddForce(transform.up * koef);
            
        }
        if (Input.GetKey(KeyCode.Alpha9))
        {
            Debug.Log("Click");
            // Physics.gravity = Vector3.up;

            player.useGravity = true;
            player.AddForce(-transform.up * koef);

        }
    }
   
}
