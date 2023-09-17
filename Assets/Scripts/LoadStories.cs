using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadStories : MonoBehaviour
{
    public void First()
    {
        SceneManager.LoadScene("FirstChapter");
    }

    public void Second()
    {
        SceneManager.LoadScene("SecondChapter");
    }

    public void Third()
    {
        SceneManager.LoadScene("ThirdChapter");
    }
	
    public void Fourth()
    {
        SceneManager.LoadScene("FourthChapter");
    }

    public void Fifth()
    {
        SceneManager.LoadScene("FifthChapter");
    }
}
