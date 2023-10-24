using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScriptInstructions : MonoBehaviour
{
    public void quit()
    {
        SceneManager.LoadScene("Start Screen");
    }
}