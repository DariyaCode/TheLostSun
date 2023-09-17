using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour {


    public void LoadMain()
    {
        SceneManager.LoadScene("GameIntro");
    }

		public void Quit()
    {
        Application.Quit();
    }

		
}
