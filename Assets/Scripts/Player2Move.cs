using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Move : MonoBehaviour
{
    public float moveSpeed = 3.0f;
    private float dirX, dirY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dirX = 0f;
        dirY = 0f;
        if(Input.GetKey("up"))
        {    
            dirY = moveSpeed;
        }
        if(Input.GetKey("left"))
        {
            dirX = -moveSpeed;
        }
        if(Input.GetKey("down"))
        {
            dirY = -moveSpeed;
        }
        if(Input.GetKey("right"))
        {
            dirX = moveSpeed;
        }
        Vector3 moveVect = new Vector3(dirX, dirY, 0);
        moveVect *= moveSpeed * Time.deltaTime;
        transform.Translate(moveVect);
    }
}
