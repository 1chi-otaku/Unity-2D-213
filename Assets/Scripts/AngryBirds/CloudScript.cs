using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClourScript : MonoBehaviour
{
    private Vector3 startPosition;
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * 0.001f);
        if(transform.position.x > 10)
        {
            transform.position = startPosition + Vector3.down * Random.Range(0f,1f);
        }
    }
}
