using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Move : MonoBehaviour
{
    public float moveSpeed = 3.0f;
    private float dirX, dirY;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if(this.gameObject.GetComponent<PlayerWeapon>().getWeapon() != null)
        {
            if(this.gameObject.GetComponent<PlayerWeapon>().getWeapon().name.Contains("gun"))
            {
                animator.SetLayerWeight(1, 1f);
                animator.SetLayerWeight(2, 0);
                animator.SetLayerWeight(3, 0);
            }else if(this.gameObject.GetComponent<PlayerWeapon>().getWeapon().name.Contains("ninja")){
                animator.SetLayerWeight(2, 1f);
                animator.SetLayerWeight(3, 0);
            }else if(this.gameObject.GetComponent<PlayerWeapon>().getWeapon().name.Contains("sword")){
                animator.SetLayerWeight(3, 1f);
            }
        }else
        {
            animator.SetLayerWeight(0, 1f);
            animator.SetLayerWeight(1, 0);
            animator.SetLayerWeight(2, 0);
            animator.SetLayerWeight(3, 0);
        }
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
        animator.SetFloat("Horizontal", dirX);
        animator.SetFloat("Vertical", dirY);

        Vector2 moveVect = new Vector2(dirX, dirY);
        moveVect *= moveSpeed * Time.deltaTime;
        animator.SetFloat("Speed", moveVect.sqrMagnitude*10e5f);
        transform.Translate(moveVect);
    }
}
