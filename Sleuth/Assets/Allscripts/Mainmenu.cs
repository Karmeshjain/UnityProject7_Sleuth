using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Mainmenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Maingame");
    }

    //use for quiting of game
    public void QuitGame()
    {
        Application.Quit();
    }
}
