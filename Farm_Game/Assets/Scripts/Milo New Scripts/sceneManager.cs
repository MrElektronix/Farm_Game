using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour {

    public void startGame(string _startGame)
    {
        SceneManager.LoadScene(_startGame);
    }

    public void mainMenu(string _mainmenu)
    {
        SceneManager.LoadScene(_mainmenu);
    }

    public void Instructions(string _instructions)
    {
        SceneManager.LoadScene(_instructions);
    }


    public void Quitgame()
    {
        Application.Quit();
    }

}
