using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour {

    public void startGame(string _startGame)
    {
        SceneManager.LoadScene(_startGame);
    }

    public void Instructions(string _Instructions)
    {
        SceneManager.LoadScene(_Instructions);
    }

    public void Quitgame()
    {
        Application.Quit();
    }

}
