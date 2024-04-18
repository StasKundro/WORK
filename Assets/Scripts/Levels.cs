using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    //сцена с вопросом
    public string sceneToLoad;

    //Вешай этот скрипт на каждую кнопку и указывай сцену которую она загрузит
    public void GoNext()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
