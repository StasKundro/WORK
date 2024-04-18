using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RightFalse : MonoBehaviour
{
    public string sceneToLoad;
    public GameObject rigthText;
    public GameObject falseText;

    public void GoRight()
    {
        rigthText.SetActive(true);
        StartCoroutine(end(3f));
    }
    public void GoFalse()
    {
        falseText.SetActive(true);
        StartCoroutine(end(3f));
    }

    IEnumerator end(float Secs)
    {
        yield return new WaitForSeconds(Secs);
        SceneManager.LoadScene(sceneToLoad);
    }
}
