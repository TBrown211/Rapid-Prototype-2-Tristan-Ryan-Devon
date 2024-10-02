using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pick_Level : MonoBehaviour
{
    public void LevelSelect()
    {
        SceneManager.LoadScene("Test Level Tristan");
    }
}
