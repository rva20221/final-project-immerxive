using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void Mode1(){
        SceneManager.LoadScene("Mode1");
        Time.timeScale = 1;
    }

    public void Mode2(){
        SceneManager.LoadScene("Mode2");
        Time.timeScale = 1;
    }
}