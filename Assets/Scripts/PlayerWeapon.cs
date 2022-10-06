using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    public GameObject currentWeapon;
    
    void Start() {
        currentWeapon = null;
    }
    public void UpdateWeapon(GameObject weapon) {
        currentWeapon = weapon;
    }
    public GameObject getWeapon()
    {
        return currentWeapon;
    }
}