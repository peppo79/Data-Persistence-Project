using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{ 
    public TextMeshProUGUI inputText;


    private void Awake()
    {
        ScManager.Instance.LoadScore();
    }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void StartNew()
    {    
        ScManager.Instance.playerName = inputText.text;        
        SceneManager.LoadScene(1); 
    }


    public void QuitGame()
    {
        ScManager.Instance.SaveScore();
        EditorApplication.ExitPlaymode();
        Application.Quit();
    }


    public void BackToMain()
    {
        SceneManager.LoadScene(0);
    }



    

}
