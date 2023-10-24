using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicScriptStart : MonoBehaviour
{

    public void startGame()
    {
        SceneManager.LoadScene("Rainbow Run");
    }

    public void toInstructions()
    {
        SceneManager.LoadScene("Instructions");
    }
}
