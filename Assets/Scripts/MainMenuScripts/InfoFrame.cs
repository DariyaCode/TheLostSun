using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InfoFrame : MonoBehaviour
{
    [SerializeField]
    GameObject info;
    // Start is called before the first frame update
    void Start()
    {
        info.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Backspace))
        {
            info.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void InfoOff()
    {
        info.SetActive(false);
        Time.timeScale = 1;
    }
}
