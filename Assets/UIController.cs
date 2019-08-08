using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public Animator Menu, Teori;

    public void Mulai()
    {
        Menu.SetTrigger("Start");
    }

    public void TeoriDasar(string a_param)
    {
        Teori.SetTrigger(a_param);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void changeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
