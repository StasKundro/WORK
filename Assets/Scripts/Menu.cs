using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Имя следующей сцены
    public string nextSceneName;

    // Метод для выключения игры
    public void QuitGame()
    {
        Application.Quit();
    }

    // Метод для загрузки следующей сцены
    public void LoadNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
