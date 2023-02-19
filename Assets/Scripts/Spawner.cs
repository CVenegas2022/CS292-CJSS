using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject health;
    private int healthCount = 0;
    public GameObject easyObstacle1_1;
    public GameObject easyObstacle1_2;
    public GameObject easyObstacle1_3;
    public GameObject easyObstacle2_1;
    public GameObject easyObstacle2_2;
    public GameObject easyObstacle2_3;
    public GameObject mediumObstacle2_1;
    public GameObject mediumObstacle2_2;
    public GameObject easyObstacle3_1;
    public GameObject easyObstacle3_2;
    public GameObject easyObstacle3_3;
    public GameObject mediumObstacle3_1;
    public GameObject mediumObstacle3_2;
    public GameObject hardObstacle3_1;
    public GameObject hardObstacle3_2;
    public GameObject hardObstacle3_3;
    public GameObject hardObstacle3_4;
    public GameObject mediumObstacle4_1;
    public GameObject mediumObstacle4_2;
    public GameObject hardObstacle4_1;
    public GameObject hardObstacle4_2;
    public GameObject hardObstacle4_3;
    public GameObject hardObstacle4_4;
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
                float randomNumber = Random.Range(0f, 100f);
                if (randomNumber < 33) {
                    // Debug.Log(timer);
                    GameObject newEasyObstacle1 = Instantiate(easyObstacle1_1);
                    Destroy(newEasyObstacle1, 10);
                    timer = 0;
                } 
                else if (randomNumber >= 33 && randomNumber < 66) {
                    // Debug.Log(timer);
                    GameObject newEasyObstacle2 = Instantiate(easyObstacle1_2);
                    Destroy(newEasyObstacle2, 10);
                    timer = 0;
                }
                else {
                    // Debug.Log(timer);
                    GameObject newEasyObstacle3 = Instantiate(easyObstacle1_3);
                    Destroy(newEasyObstacle3, 10);
                    timer = 0;
                }
            }
        }

        if (time >= 25 && time < 45) {
            timeToSpawn = 1.5f;
            if (timer > timeToSpawn) {
                float randomNumber = Random.Range(0f, 100f);
                if (randomNumber < 20) {
                    // Debug.Log(timer);
                    GameObject newMediumObstacle1 = Instantiate(mediumObstacle2_1);
                    Destroy(newMediumObstacle1, 10);
                    timer = 0;
                } 
                else if (randomNumber >= 20 && randomNumber < 40) {
                    // Debug.Log(timer);
                    GameObject newMediumObstacle2 = Instantiate(mediumObstacle2_2);
                    Destroy(newMediumObstacle2, 10);
                    timer = 0;
                }
                else if (randomNumber >= 40 && randomNumber < 60) {
                    // Debug.Log(timer);
                    GameObject newEasyObstacle3 = Instantiate(easyObstacle2_3);
                    Destroy(newEasyObstacle3, 10);
                    timer = 0;
                }
                else if (randomNumber >= 60 && randomNumber < 80) {
                    // Debug.Log(timer);
                    GameObject newEasyObstacle1 = Instantiate(easyObstacle2_1);
                    Destroy(newEasyObstacle1, 10);
                    timer = 0;
                }
                else {
                    // Debug.Log(timer);
                    GameObject newEasyObstacle2 = Instantiate(easyObstacle2_2);
                    Destroy(newEasyObstacle2, 10);
                    timer = 0;
                }
            }
        }

        if (time >= 47 && time <=48 && healthCount == 0) {
            GameObject newHealth = Instantiate(health);
            Destroy(newHealth, 10);
            healthCount += 1;
        }


        if (time >= 50 && time < 70) {
            timeToSpawn = 1.2f;
            if (timer > timeToSpawn) {
                float randomNumber = Random.Range(0f, 200f);
                if (randomNumber < 20) {
                    // Debug.Log(timer);
                    GameObject newEasyObstacle1 = Instantiate(easyObstacle3_1);
                    Destroy(newEasyObstacle1, 10);
                    timer = 0;
                } 
                else if (randomNumber >= 20 && randomNumber < 40) {
                    // Debug.Log(timer);
                    GameObject newEasyObstacle2 = Instantiate(easyObstacle3_2);
                    Destroy(newEasyObstacle2, 10);
                    timer = 0;
                }
                else if (randomNumber >= 40 && randomNumber < 60) {
                    // Debug.Log(timer);
                    GameObject newEasyObstacle3 = Instantiate(easyObstacle3_3);
                    Destroy(newEasyObstacle3, 10);
                    timer = 0;
                }
                else if (randomNumber >= 60 && randomNumber < 80) {
                    // Debug.Log(timer);
                    GameObject newMediumObstacle1 = Instantiate(mediumObstacle3_1);
                    Destroy(newMediumObstacle1, 10);
                    timer = 0;
                }
                else if (randomNumber >= 80 && randomNumber < 100) {
                    // Debug.Log(timer);
                    GameObject newMediumObstacle2 = Instantiate(mediumObstacle3_2);
                    Destroy(newMediumObstacle2, 10);
                    timer = 0;
                }
                else if (randomNumber >= 100 && randomNumber < 125) {
                    // Debug.Log(timer);
                    GameObject newHardObstacle1 = Instantiate(hardObstacle3_1);
                    Destroy(newHardObstacle1, 10);
                    timer = 0;
                }
                else if (randomNumber >= 125 && randomNumber < 150) {
                    // Debug.Log(timer);
                    GameObject newHardObstacle2 = Instantiate(hardObstacle3_2);
                    Destroy(newHardObstacle2, 10);
                    timer = 0;
                }
                else if (randomNumber >= 150 && randomNumber < 175) {
                    // Debug.Log(timer);
                    GameObject newHardObstacle2 = Instantiate(hardObstacle3_3);
                    Destroy(newHardObstacle2, 10);
                    timer = 0;
                }
                else {
                    // Debug.Log(timer);
                    GameObject newHardObstacle3 = Instantiate(hardObstacle3_4);
                    Destroy(newHardObstacle3, 10);
                    timer = 0;
                }
            }
        }

        if (time >= 72 && time <= 73 && healthCount == 1) {
            GameObject newHealth = Instantiate(health);
            Destroy(newHealth, 10);
            healthCount += 1;
        }

        if (time >= 75) {
            timeToSpawn = 1.1f;
            if (timer > timeToSpawn) {
                float randomNumber = Random.Range(0f, 200f);
                if (randomNumber < 33) {
                    // Debug.Log(timer);
                    GameObject newMediumObstacle1 = Instantiate(mediumObstacle4_1);
                    Destroy(newMediumObstacle1, 10);
                    timer = 0;
                }
                else if (randomNumber >= 33 && randomNumber < 66) {
                    // Debug.Log(timer);
                    GameObject newMediumObstacle2 = Instantiate(mediumObstacle4_2);
                    Destroy(newMediumObstacle2, 10);
                    timer = 0;
                }
                else if (randomNumber >= 66 && randomNumber < 100) {
                    // Debug.Log(timer);
                    GameObject newHardObstacle1 = Instantiate(hardObstacle4_1);
                    Destroy(newHardObstacle1, 10);
                    timer = 0;
                }
                else if (randomNumber >= 100 && randomNumber < 133) {
                    // Debug.Log(timer);
                    GameObject newHardObstacle2 = Instantiate(hardObstacle4_2);
                    Destroy(newHardObstacle2, 10);
                    timer = 0;
                }
                else if (randomNumber >= 133 && randomNumber < 166) {
                    // Debug.Log(timer);
                    GameObject newHardObstacle2 = Instantiate(hardObstacle4_3);
                    Destroy(newHardObstacle2, 10);
                    timer = 0;
                }
                else {
                    // Debug.Log(timer);
                    GameObject newHardObstacle3 = Instantiate(hardObstacle4_4);
                    Destroy(newHardObstacle3, 10);
                    timer = 0;
                }
            }
        }



        timer += Time.deltaTime;
    }
}
