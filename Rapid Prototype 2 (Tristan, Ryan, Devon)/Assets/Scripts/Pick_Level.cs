using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pick_Level : MonoBehaviour
{
    public void Level1()
    {
        SceneManager.LoadScene("Test Level Tristan");
    }

    public void Help()
    {
        SceneManager.LoadScene("Help Screen");
    }
}
