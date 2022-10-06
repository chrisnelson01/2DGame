using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.tag == "Player")
        {
            GameObject[] portals = GameObject.FindGameObjectsWithTag("Portal");
            for(int i = 0; i < portals.Length; i++) {
                if(gameObject.name != portals[i].name)
                {
                    collision.transform.position = new Vector3(portals[i].transform.position.x, portals[i].transform.position.y, collision.transform.position.z);
                    StartCoroutine(wait(portals[i]));
                }
            }
        }
    }
    IEnumerator wait(GameObject portal)
    {
        portal.GetComponent<Collider2D>().enabled =false;
        yield return new WaitForSeconds(1);
        portal.GetComponent<Collider2D>().enabled =true;
    }
}
