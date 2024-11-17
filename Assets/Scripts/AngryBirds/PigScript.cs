using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("PigDestroyer"))
        {
            GameState.IsLevelComplete = true;
            GameState.Pause("Victory is yours","You've successfully perished an innocent pig", "Next Level");
        }
       
    }
}
