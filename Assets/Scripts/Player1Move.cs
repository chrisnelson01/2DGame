using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player1Move : MonoBehaviour
{
    public float moveSpeed = 3.0f;
    private float dirX, dirY;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dirX = 0f;
        dirY = 0f;
        if(Input.GetKey("w"))
        {    
            dirY = moveSpeed;
        }
        if(Input.GetKey("a"))
        {
            dirX = -moveSpeed;
        }
        if(Input.GetKey("s"))
        {
            dirY = -moveSpeed;
        }
        if(Input.GetKey("d"))
        {
            dirX = moveSpeed;
        }
        Vector3 moveVect = new Vector3(dirX, dirY, 0);
        moveVect *= moveSpeed * Time.deltaTime;
        transform.Translate(moveVect);
    }
}
