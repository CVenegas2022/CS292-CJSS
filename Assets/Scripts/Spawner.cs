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
    public float timeToSpawn = 1.8f;
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
                if (timer < 1.8015) {
                    // Debug.Log(timer);
                    GameObject newEasyObstacle1 = Instantiate(easyObstacle1);
                    Destroy(newEasyObstacle1, 10);
                    timer = 0;
                } 
                else if (timer >= 1.8015 && timer < 1.803) {
                    // Debug.Log(timer);
                    GameObject newEasyObstacle2 = Instantiate(easyObstacle2);
                    Destroy(newEasyObstacle2, 10);
                    timer = 0;
                }
                else {
                    // Debug.Log(timer);
                    GameObject newEasyObstacle3 = Instantiate(easyObstacle3);
                    Destroy(newEasyObstacle3, 10);
                    timer = 0;
                }
            }
        }

        if (time >= 20 && time < 40) {
            timeToSpawn = 1.5f;
            if (timer > timeToSpawn) {
                if (timer < 1.501) {
                    // Debug.Log(timer);
                    GameObject newMediumObstacle1 = Instantiate(mediumObstacle1);
                    Destroy(newMediumObstacle1, 10);
                    timer = 0;
                } 
                else if (timer >= 1.501 && timer < 1.502) {
                    // Debug.Log(timer);
                    GameObject newMediumObstacle2 = Instantiate(mediumObstacle2);
                    Destroy(newMediumObstacle2, 10);
                    timer = 0;
                }
                else if (timer >= 1.502 && timer < 1.503) {
                    // Debug.Log(timer);
                    GameObject newEasyObstacle3 = Instantiate(easyObstacle3);
                    Destroy(newEasyObstacle3, 10);
                    timer = 0;
                }
                else if (timer >= 1.503 && timer < 1.507) {
                    // Debug.Log(timer);
                    GameObject newEasyObstacle1 = Instantiate(easyObstacle1);
                    Destroy(newEasyObstacle1, 10);
                    timer = 0;
                }
                else {
                    // Debug.Log(timer);
                    GameObject newEasyObstacle2 = Instantiate(easyObstacle2);
                    Destroy(newEasyObstacle2, 10);
                    timer = 0;
                }
            }
        }

        if (time >= 40) {
            timeToSpawn = 1.2f;
            if (timer > timeToSpawn) {
                if (timer < 1.2005) {
                    // Debug.Log(timer);
                    GameObject newEasyObstacle1 = Instantiate(easyObstacle1);
                    Destroy(newEasyObstacle1, 10);
                    timer = 0;
                } 
                else if (timer >= 1.2005 && timer < 1.201) {
                    // Debug.Log(timer);
                    GameObject newEasyObstacle2 = Instantiate(easyObstacle2);
                    Destroy(newEasyObstacle2, 10);
                    timer = 0;
                }
                else if (timer >= 1.201 && timer < 1.2015) {
                    // Debug.Log(timer);
                    GameObject newEasyObstacle3 = Instantiate(easyObstacle3);
                    Destroy(newEasyObstacle3, 10);
                    timer = 0;
                }
                else if (timer >= 1.2015 && timer < 1.202) {
                    // Debug.Log(timer);
                    GameObject newMediumObstacle1 = Instantiate(mediumObstacle1);
                    Destroy(newMediumObstacle1, 10);
                    timer = 0;
                }
                else if (timer >= 1.2025 && timer < 1.203) {
                    // Debug.Log(timer);
                    GameObject newMediumObstacle2 = Instantiate(mediumObstacle2);
                    Destroy(newMediumObstacle2, 10);
                    timer = 0;
                }
                else if (timer >= 1.203 && timer < 1.205) {
                    // Debug.Log(timer);
                    GameObject newHardObstacle1 = Instantiate(hardObstacle1);
                    Destroy(newHardObstacle1, 10);
                    timer = 0;
                }
                else if (timer >= 1.205 && timer < 1.207) {
                    // Debug.Log(timer);
                    GameObject newHardObstacle2 = Instantiate(hardObstacle2);
                    Destroy(newHardObstacle2, 10);
                    timer = 0;
                }
                else if (timer >= 1.207 && timer < 1.209) {
                    // Debug.Log(timer);
                    GameObject newHardObstacle2 = Instantiate(hardObstacle2);
                    Destroy(newHardObstacle2, 10);
                    timer = 0;
                }
                else {
                    // Debug.Log(timer);
                    GameObject newHardObstacle3 = Instantiate(hardObstacle3);
                    Destroy(newHardObstacle3, 10);
                    timer = 0;
                }
            }
        }

        timer += Time.deltaTime;
    }
}
