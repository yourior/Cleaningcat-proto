using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {

    public static bool GameIsPaused = false;
    public GameObject PausedMenuUI;
    public string SceneMenu;
	// Update is called once per frame
	void Update () {
	
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Resume();
            }else if(!GameIsPaused)
            {
                Paused();
            }
        }
	}

    public void Resume()
    {
        PausedMenuUI.SetActive(false);
        Time.timeScale = 1;
        GameIsPaused = false;
    }
    void Paused()
    {
        PausedMenuUI.SetActive(true);
        Time.timeScale = 0;
        GameIsPaused = true;
    }
   public void LoadMenu()
    {
        Debug.Log("Load Menu");
        SceneManager.LoadScene(SceneMenu);
    }
    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
