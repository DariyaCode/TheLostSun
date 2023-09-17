using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour
{
    public void Menu()
    {
        SceneManager.LoadScene("Start");
    }

    public void LoadedLevels()
    {
        SceneManager.LoadScene("ChaptersLevel");
    }

    public void ToStart()
    {
        SceneManager.LoadScene("Story");
    }

		public void Options()
    {
        SceneManager.LoadScene("Settings");
    }

		public void Info()
    {
        SceneManager.LoadScene("Info");
    }
}
