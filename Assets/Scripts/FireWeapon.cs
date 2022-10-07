using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWeapon : MonoBehaviour
{
    public GameObject bullet;
    public GameObject ninjaStar;
    public Transform firePoint; 
    public float bulletSpeed = 500f;
    public float starSpeed = 200f;
    public float fireRateNinja = 1.0f;
    public float fireRateBullet = .5f;
    public float nextFire = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject weapon = this.gameObject.GetComponent<PlayerWeapon>().getWeapon();
        if(weapon != null && weapon.name.Contains("gun"))
        {
            if(Input.GetKey("e") && Time.time > nextFire)
            {
                nextFire= Time.time + fireRateBullet;
                GameObject spawnedBullet = Instantiate(bullet, firePoint.position, firePoint.rotation);
                StartCoroutine(destroy(spawnedBullet));
            }
        }
        if(weapon != null && weapon.name.Contains("ninja"))
        {
            if(Input.GetKey("e") && Time.time > nextFire)
            {
                nextFire= Time.time + fireRateNinja;
                GameObject spawnedNinjaStar = Instantiate(ninjaStar, firePoint.position, firePoint.rotation);
                StartCoroutine(destroy(spawnedNinjaStar));
            }
        }
    }
    IEnumerator destroy(GameObject spawned)
    {
        yield return new WaitForSeconds(7);
        Destroy(spawned);
    }
}
