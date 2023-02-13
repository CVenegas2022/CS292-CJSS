using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cling : MonoBehaviour
{
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = target.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = target.position;
    }
}
