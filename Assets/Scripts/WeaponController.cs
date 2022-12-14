using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    private AudioSource audioSource;
    private void Start() {
        audioSource = gameObject.GetComponent<AudioSource>();
    }
    IEnumerator Wait(){
         yield return new WaitForSeconds(5);
    }
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        audioSource.Play();
        if(collision.tag == "Player")
        {
            if(collision.GetComponent<PlayerWeapon>().getWeapon() != null)
            {
                collision.GetComponent<PlayerWeapon>().getWeapon().SetActive(true);
                collision.GetComponent<PlayerWeapon>().getWeapon().transform.position = new Vector3(this.gameObject.transform.position.x - 2, this.gameObject.transform.position.y, 0);
            }
            collision.GetComponent<PlayerWeapon>().UpdateWeapon(this.gameObject);
            gameObject.SetActive(false);
        }
    }
}
