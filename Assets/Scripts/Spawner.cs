using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject easyObstacle1;
    public GameObject easyObstacle2;
    public GameObject easyObstacle3;
    public GameObject mediumObstacle1;
    public GameObject mediumObstacle2;
    public GameObject hardObstacle1;
    public GameObject hardObstacle2;
    public GameObject hardObstacle3;
    public GameObject hardObstacle4;
    public float timeToSpawn = 1.5f;
    private float timer = 0;
    private float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time < 20) {
            if (timer > timeToSpawn) {
                if (timer < 1.5015) {
                    Debug.Log(timer);
                    GameObject newEasyObstacle1 = Instantiate(easyObstacle1);
                    Destroy(newEasyObstacle1, 10);
                    timer = 0;
                } 
                else if (timer >= 1.5015 && timer < 1.503) {
                    Debug.Log(timer);
                    GameObject newEasyObstacle2 = Instantiate(easyObstacle2);
                    Destroy(newEasyObstacle2, 10);
                    timer = 0;
                }
                else {
                    Debug.Log(timer);
                    GameObject newEasyObstacle3 = Instantiate(easyObstacle3);
                    Destroy(newEasyObstacle3, 10);
                    timer = 0;
                }
            }
        }

        if (time >= 20 && time < 40) {
            timeToSpawn = 1.2f;
            if (timer > timeToSpawn) {
                if (timer < 1.201) {
                    Debug.Log(timer);
                    GameObject newMediumObstacle1 = Instantiate(mediumObstacle1);
                    Destroy(newMediumObstacle1, 10);
                    timer = 0;
                } 
                else if (timer >= 1.201 && timer < 1.202) {
                    Debug.Log(timer);
                    GameObject newMediumObstacle2 = Instantiate(mediumObstacle2);
                    Destroy(newMediumObstacle2, 10);
                    timer = 0;
                }
                else if (timer >= 1.202 && timer < 1.203) {
                    Debug.Log(timer);
                    GameObject newEasyObstacle3 = Instantiate(easyObstacle3);
                    Destroy(newEasyObstacle3, 10);
                    timer = 0;
                }
                else if (timer >= 1.203 && timer < 1.207) {
                    Debug.Log(timer);
                    GameObject newEasyObstacle1 = Instantiate(easyObstacle1);
                    Destroy(newEasyObstacle1, 10);
                    timer = 0;
                }
                else {
                    Debug.Log(timer);
                    GameObject newEasyObstacle2 = Instantiate(easyObstacle2);
                    Destroy(newEasyObstacle2, 10);
                    timer = 0;
                }
            }
        }

        if (time >= 40) {
            timeToSpawn = 0.9f;
            if (timer > timeToSpawn) {
                if (timer < 0.9005) {
                    Debug.Log(timer);
                    GameObject newEasyObstacle1 = Instantiate(easyObstacle1);
                    Destroy(newEasyObstacle1, 10);
                    timer = 0;
                } 
                else if (timer >= 0.9005 && timer < 0.901) {
                    Debug.Log(timer);
                    GameObject newEasyObstacle2 = Instantiate(easyObstacle2);
                    Destroy(newEasyObstacle2, 10);
                    timer = 0;
                }
                else if (timer >= 0.901 && timer < 0.9015) {
                    Debug.Log(timer);
                    GameObject newEasyObstacle3 = Instantiate(easyObstacle3);
                    Destroy(newEasyObstacle3, 10);
                    timer = 0;
                }
                else if (timer >= 0.9015 && timer < 0.902) {
                    Debug.Log(timer);
                    GameObject newMediumObstacle1 = Instantiate(mediumObstacle1);
                    Destroy(newMediumObstacle1, 10);
                    timer = 0;
                }
                else if (timer >= 0.9025 && timer < 0.903) {
                    Debug.Log(timer);
                    GameObject newMediumObstacle2 = Instantiate(mediumObstacle2);
                    Destroy(newMediumObstacle2, 10);
                    timer = 0;
                }
                else if (timer >= 0.903 && timer < 0.905) {
                    Debug.Log(timer);
                    GameObject newHardObstacle1 = Instantiate(hardObstacle1);
                    Destroy(newHardObstacle1, 10);
                    timer = 0;
                }
                else if (timer >= 0.905 && timer < 0.907) {
                    Debug.Log(timer);
                    GameObject newHardObstacle2 = Instantiate(hardObstacle2);
                    Destroy(newHardObstacle2, 10);
                    timer = 0;
                }
                else if (timer >= 0.907 && timer < 0.909) {
                    Debug.Log(timer);
                    GameObject newHardObstacle2 = Instantiate(hardObstacle2);
                    Destroy(newHardObstacle2, 10);
                    timer = 0;
                }
                else {
                    Debug.Log(timer);
                    GameObject newHardObstacle3 = Instantiate(hardObstacle3);
                    Destroy(newHardObstacle3, 10);
                    timer = 0;
                }
            }
        }

        timer += Time.deltaTime;
    }
}
