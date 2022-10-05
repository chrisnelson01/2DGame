using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class P1Health : MonoBehaviour
{
    public float MAX_HEALTH = 100;
    public float currHealth;
    GameObject gameManager;
    public GameObject P1HealthBar;
    
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("Game Manager");
        currHealth = MAX_HEALTH;
    }

    // Update is called once per frame
    void Update()
    {
        P1HealthBar.transform.localScale =
            new Vector3((currHealth) / MAX_HEALTH, 1.0f, 1.0f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Weapon")
        {
            currHealth -= 10;
            if (currHealth <= 0.0f)
                gameManager.SendMessage("GotoGameOver");
        }
    }
}