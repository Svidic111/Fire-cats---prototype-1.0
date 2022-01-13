using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Manager : MonoBehaviour
{
    
    public void LoadMainMenu() {
        SceneManager.LoadScene(0);
    }

    public void LoadLevel_1() {
        SceneManager.LoadScene(1);
    }

    public void LoadLevel_2() {
        SceneManager.LoadScene(2);
    }

    public void LoadLevel_3() {
        SceneManager.LoadScene(3);
    }

    public void LoadLevel_4() {
        SceneManager.LoadScene(4);
    }

    public void LoadLevel_5() {
        SceneManager.LoadScene(5);
    }

    public void LoadLevelMap() {
        SceneManager.LoadScene(6);
    }

    public void LoadCabinet() {
        SceneManager.LoadScene(7);
    }

    public void LoadSettings() {
        SceneManager.LoadScene(8);
    }

    public void LoadCredits() {
        SceneManager.LoadScene(9);
    }

    public void QuitApp() {
        Application.Quit();
    }
}
