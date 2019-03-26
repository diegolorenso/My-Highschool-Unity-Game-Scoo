using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public Text playerName;
    public void loadGame()
    {
        GameManager.instance.SetName(playerName.text);
    SceneManager.LoadScene("SampleScene");
         
    }
}
