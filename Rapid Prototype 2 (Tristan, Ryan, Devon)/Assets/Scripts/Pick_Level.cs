using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pick_Level : MonoBehaviour
{
    public void Level1() // Loads Level 1
    {
        SceneManager.LoadScene("TestMovement");
    }

    public void Help() //Loads Help Screen
    {
        SceneManager.LoadScene("Help Screen");
    }

    public void Menu() //Loads Menu Screen
    {
        SceneManager.LoadScene("Menu Screen");
    }
}
