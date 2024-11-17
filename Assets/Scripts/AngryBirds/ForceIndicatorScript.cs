using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForceIndicatorScript : MonoBehaviour
{
    public static float forceFactor;
    [SerializeField] private Image indicatorFg;
    [SerializeField] private float sensitivity = 0.01f;

    private Gradient gradient;

    void Start()
    {
        forceFactor = indicatorFg.fillAmount;
        gradient = new Gradient();


        GradientColorKey[] colorKeys = new GradientColorKey[5];
        colorKeys[0].color = Color.green;
        colorKeys[0].time = 0.0f;
        colorKeys[1].color = Color.yellow;
        colorKeys[1].time = 0.25f;
        colorKeys[2].color = new Color(1.0f, 0.65f, 0.0f); 
        colorKeys[2].time = 0.5f;
        colorKeys[3].color = new Color(1.0f, 0.5f, 0.0f); 
        colorKeys[3].time = 0.75f;
        colorKeys[4].color = Color.red;
        colorKeys[4].time = 1.0f;

        GradientAlphaKey[] alphaKeys = new GradientAlphaKey[2];
        alphaKeys[0].alpha = 1.0f;
        alphaKeys[0].time = 0.0f;
        alphaKeys[1].alpha = 1.0f;
        alphaKeys[1].time = 1.0f;

        gradient.SetKeys(colorKeys, alphaKeys);
    }

    void Update()
    {
        float dx = Input.GetAxis("Horizontal");
        if (dx != 0)
        {
            dx *= sensitivity;
            if (0.1f <= indicatorFg.fillAmount + dx && indicatorFg.fillAmount + dx <= 1.0f)
            {
                forceFactor = indicatorFg.fillAmount += dx;

                indicatorFg.color = gradient.Evaluate(indicatorFg.fillAmount);
            }
        }
    }
}
