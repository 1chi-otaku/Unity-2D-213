using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayScript : MonoBehaviour
{
    [SerializeField] private float levelTimeout = 5f;
    private TMPro.TextMeshProUGUI clockTMP;
    private float gameTime; 
    void Start()
    {
        clockTMP = GameObject.Find("ClockTMP").GetComponent<TMPro.TextMeshProUGUI>();
        gameTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        gameTime += Time.deltaTime;
        if (clockTMP != null)
        {
            int minutes = (int)(gameTime / 60);
            int seconds = (int)(gameTime % 60);
            int milliseconds = (int)((gameTime * 1000) % 100);

            clockTMP.text = string.Format("Time: {0:00}:{1:00}:{2:00}", minutes, seconds, milliseconds);
        }
        if(gameTime >= levelTimeout)
        {
            GameState.Pause("You lost", "Timeout", "Retry");
            GameState.IsLevelComplete = true;
        }
    } 
}
