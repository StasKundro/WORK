using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // ��� ��������� �����
    public string nextSceneName;

    // ����� ��� ���������� ����
    public void QuitGame()
    {
        Application.Quit();
    }

    // ����� ��� �������� ��������� �����
    public void LoadNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
