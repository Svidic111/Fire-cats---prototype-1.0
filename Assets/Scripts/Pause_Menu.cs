using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_Menu : MonoBehaviour
{
    public static bool _isGamePaused = false;
    
    [SerializeField]
    private GameObject PauseMenu;
    [SerializeField]
    private GameObject EndGameMenu;

    private void Start() {
        if (_isGamePaused == true) {
            _isGamePaused = false;
        }
    }

    
    public void LoadMainMenu() {
        _isGamePaused = false;
        Time.timeScale = 1f;
        
        SceneManager.LoadScene(0);
    }

    public void PauseGame() {
        if (_isGamePaused == false) {
            _isGamePaused = true;
            
            PauseMenu.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void ResumeGame() {
        if (_isGamePaused == true) {
            _isGamePaused = false;

            PauseMenu.SetActive(false);
            Time.timeScale = 1f;
        }
    }

    public void LevelEndMenu() {
        if (_isGamePaused == false) {
            _isGamePaused = true;
            
            EndGameMenu.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void RetryLevel_1() {
        Time.timeScale = 1f;
   
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
}
