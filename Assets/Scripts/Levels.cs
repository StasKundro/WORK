using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    //����� � ��������
    public string sceneToLoad;

    //����� ���� ������ �� ������ ������ � �������� ����� ������� ��� ��������
    public void GoNext()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
