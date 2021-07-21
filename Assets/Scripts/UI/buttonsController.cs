using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class buttonsController : MonoBehaviour
{
    public Button startBtn, aboutBtn, quitBtn;
    // Start is called before the first frame update
    void Start()
    {
        startBtn.onClick.AddListener(startLevel);
        quitBtn.onClick.AddListener(quitGame);
    }

    
    void startLevel()
    {
        SceneManager.LoadScene("level1V4");
    }

    void quitGame()
    {
        Application.Quit();
    }

}
