using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class ModalScript : MonoBehaviour
{
    [SerializeField] private GameObject content;
    [SerializeField] private TMPro.TextMeshProUGUI titleTMP;
    [SerializeField] private TMPro.TextMeshProUGUI messageTMP;
    [SerializeField] private TMPro.TextMeshProUGUI buttonTMP;
    void Start()
    {
        this.ShowModal(content.activeInHierarchy);
        GameState.modalScriptInstance = this;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            this.ShowModal(!content.activeInHierarchy);
            
        }
    }

    public void ShowModal(bool isShown, string title = null, string message = null, string buttonMessage = null)
    {
        if (message == null) message = "The name is temporary and not required.";
        if (title == null) title = "PAUSE";
        if (buttonMessage == null) buttonMessage = "Continue";

        if (isShown)
        {
            Time.timeScale = 0.0f;
            titleTMP.text = title;
            messageTMP.text = message;
            buttonTMP.text = buttonMessage;
            content.gameObject.SetActive(true);
        }
        else
        {
            Time.timeScale = 1.0f;
            content.gameObject.SetActive(false); ;
        }
    }

    public void OnReturnButtonClick()
    {
        if (GameState.IsLevelComplete)
        {
            SceneManager.LoadScene(1);
            ShowModal(false);
        }
        else
        {
            ShowModal(false);
        }
       
    }
    public void OnExitButtonClick()
    {
        #if UNITY_STANDALONE

                Application.Quit();

        #endif

        #if UNITY_EDITOR

                UnityEditor.EditorApplication.isPlaying = false;

        #endif


        //if (Application.isEditor)
        //{
        //    EditorApplication.isPlaying = false;
        //}
        //else
        //{
        //    Application.Quit();
        //}



    }
}
