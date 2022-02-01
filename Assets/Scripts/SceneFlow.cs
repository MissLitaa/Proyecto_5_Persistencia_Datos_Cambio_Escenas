using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneFlow : MonoBehaviour
{
  public void GoToGameScene()
    {
        UIManagerMenu.sharedInstance.SaveUsername();
        SceneManager.LoadScene("Game_Start");
    }

    public void GoToGameMenu()
    {
        SceneManager.LoadScene("Menu_Start");
    }
}
