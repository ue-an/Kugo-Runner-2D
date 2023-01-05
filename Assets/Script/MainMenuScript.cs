using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public TMP_Text Highscore;

    // Start is called before the first frame update
    void Start()
    {
        Highscore.text = "High Score: " + PlayerPrefs.GetInt("HighScore");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("Assets/Scenes/SampleScene.unity");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
