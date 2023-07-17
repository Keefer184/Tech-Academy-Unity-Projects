using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ScreenSwitch()
    {
        SceneManager.LoadScene(1);
    }

    public static void GameWin()
    {
        SceneManager.LoadScene(2);
    }
}
