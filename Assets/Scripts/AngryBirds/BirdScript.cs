using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    [SerializeField] private Transform arrow;
    [SerializeField] private float minForce = 500f;
    [SerializeField] private float maxForce = 2000f;
    private Rigidbody2D rb2d;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        GameState.IsLevelComplete = false;
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            float forceAmplitude = minForce + (maxForce - minForce) * ForceIndicatorScript.forceFactor;
            rb2d.AddForce(arrow.right * forceAmplitude);
        }
    }
}
