using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    public Sprite PlayerWithNinjaStar;
    public Sprite PlayerWithSword;
    public Sprite PlayerWithGun;

    public GameObject currentWeapon;
    private void Start() {
        currentWeapon = null;
    }
    public void UpdateWeapon(GameObject weapon) {
        if(weapon.name.Contains("ninja star"))
        {
            GetComponent<SpriteRenderer>().sprite = PlayerWithNinjaStar;
            
        }else if(weapon.name.Contains("sword"))
        {
            GetComponent<SpriteRenderer>().sprite = PlayerWithSword;
        }else if(weapon.name.Contains("gun"))
        {
            GetComponent<SpriteRenderer>().sprite = PlayerWithGun;
        }
        currentWeapon = weapon;
    }

}
