using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGraviity : MonoBehaviour
{
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
           // player.useGravity = false;
            player.AddForce(transform.up * 500);
        }
    }
   
}
