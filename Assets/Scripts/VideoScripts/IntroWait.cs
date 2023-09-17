using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroWait : MonoBehaviour
{
    public int waitTime;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitForGame());
    }

    IEnumerator WaitForGame()
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(1);
    }
}
