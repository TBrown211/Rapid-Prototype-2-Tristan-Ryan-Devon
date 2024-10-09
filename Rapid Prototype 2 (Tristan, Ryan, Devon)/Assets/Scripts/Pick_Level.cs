using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pick_Level : MonoBehaviour
{
    public void Level1() // Loads Level 1
    {
        SceneManager.LoadScene("Level 1");
    }

    public void Level2() // Loads Level 2
    {
        SceneManager.LoadScene("Level 2");
    }

    public void Level3() // Loads Level 3
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
