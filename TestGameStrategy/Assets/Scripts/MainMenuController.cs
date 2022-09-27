using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    [Header("Main Menu Buttons\n")]

    [SerializeField]
    private Button newGame;
    
    [SerializeField]
    private Button loadGame;

    [SerializeField]
    private Button quit;

    public void NewGame()
    {
        Debug.Log("NewGameButton");
        SceneManager.LoadScene("NewGameScen");
    }

    public void LoadGame()
    {
        Debug.Log("Required to implement");
        //SceneManager.LoadScene("Save"); // Required to implement
    }

    public void Quit()
    {
        Debug.Log("Quit");
        //Invoke("Application.Quit()", 5f);
        Application.Quit();
    }
}
