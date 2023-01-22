using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obstacle;
    public float timeToSpawn = 1.5f;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > timeToSpawn) {
            // if (timer > 20) {
                Debug.Log(timer);
                GameObject newObstacle = Instantiate(obstacle);
                Destroy(newObstacle, 10);
                timer = 0;
                
            // } 
        }
        timer += Time.deltaTime;
    }
}
