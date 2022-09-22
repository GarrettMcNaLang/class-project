using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //This function(void) doesn't return any information back when executed
    public void ExitGame()  //The header of a function NEVER has a semicolon in front of it
    //This function takes no arguments/parameters but you must still include the parentheses
    {
        Debug.Log("Quitted");
        Application.Quit();
    }//Every { must have a } to match it

    //We added a string argument to this one, so it can be reused for other scenes
    //string sceneName = argument string = type
    public void LoadLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
