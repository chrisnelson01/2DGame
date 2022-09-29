using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    public int numberToSpawn;
    private float[] obstacleAngles = {0.0f, 45.0f, 90.0f, 135.0f, 180.0f, 225.0f, 270.0f, 315.0f, 360.0f};
    public float screenX, screenY;

    public GameObject toSpawn;
    Vector2 pos;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        numberToSpawn = Random.Range(5, 10);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

        for(int i = 0; i < numberToSpawn; i++){
            screenX = Random.Range(-screenBounds.x, screenBounds.x);
            screenY = Random.Range(-screenBounds.y, screenBounds.y);
            toSpawn.transform.rotation = Random.rotation;
            pos = new Vector2(screenX, screenY);
            toSpawn.transform.rotation = Quaternion.Euler(0.0f, 0.0f, obstacleAngles[Random.Range(0,9)]);
            GameObject newObstacle = Instantiate(toSpawn, pos, toSpawn.transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
