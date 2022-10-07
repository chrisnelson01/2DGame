using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class P1Health : MonoBehaviour
{
    private AudioSource audioSource;
    public float MAX_HEALTH = 100;
    public float currHealth;
    public GameObject healthBar;
    //GameObject gameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        //gameManager = GameObject.FindGameObjectWithTag("Game Manager");
        currHealth = MAX_HEALTH;
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.transform.localScale = new Vector3((currHealth) / MAX_HEALTH, 1.0f, 1.0f);
        if(currHealth <= 0)
        {
             SceneManager.LoadScene (sceneName: "MainMenu");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Projectile")
        {
            currHealth -= 10;
            if (currHealth <= 0.0f){
                //gameManager.SendMessage("GotoGameOver");
            }
        }
        if(collision.gameObject.tag == "Player")
        {
            audioSource.Play();
            if(collision.gameObject.GetComponent<PlayerWeapon>().getWeapon() != null)
            {
                currHealth -= 20;                
            }
        }
    }
}