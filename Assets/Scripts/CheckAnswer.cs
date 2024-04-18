using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CheckAnswer : MonoBehaviour
{
    public TMP_InputField inputField;
    public string correctText = "Привет"; // Заранее заданный корректный текст

    public string sceneToLoad;

    public GameObject rigthText;
    public GameObject falseText;

    // Метод для проверки текста
    public void CheckText()
    {
        string inputText = inputField.text; // Получаем текст из InputField

        if (inputText == correctText)
        {
            rigthText.SetActive(true);
            StartCoroutine(end(3f));
        }
        else
        {
            falseText.SetActive(true);
            StartCoroutine(end(3f));
        }
    }
    IEnumerator end(float Secs)
    {
        yield return new WaitForSeconds(Secs);
        SceneManager.LoadScene(sceneToLoad);
    }
}
