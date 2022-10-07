using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaStar : MonoBehaviour
{
    // Start is called before the first frame update
    private float move = 10f;
    private float rotate = -100f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate (move*Time.deltaTime, 0 ,0, Space.World);
        transform.Rotate (0, 0, rotate*Time.deltaTime, Space.World);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        this.gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
        move = 0f;
        rotate = 0f;
        if(collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
    public void isPlayer2()
    {
            move = -10f;
            rotate = 100f;
    }
}
