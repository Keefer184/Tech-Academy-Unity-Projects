using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceenManager : MonoBehaviour
{
    public void SceenSwitch()
    {
        SceneManager.LoadScene(1);
    }
}
