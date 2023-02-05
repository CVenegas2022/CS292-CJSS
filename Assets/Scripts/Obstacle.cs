using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed;
    // private float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // time += Time.deltaTime;
        // if (time < 20) {
        //     // speed = 6;
        //     transform.position += Vector3.left * 6 * Time.deltaTime;
        // }
        // else if (time >= 25 && time < 45) {
        //     // speed = 7;
        //     transform.position += Vector3.left * 7 * Time.deltaTime;
        // }
        // else if (time >= 50) {
        //     // speed = 8;
        //     transform.position += Vector3.left * 8 * Time.deltaTime;
        // }
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
