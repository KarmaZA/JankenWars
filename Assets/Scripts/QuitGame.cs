using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour
{
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        try
        {
            button.onClick.AddListener(LoadNextLevel);
        }
        catch
        {
            Debug.Log("Button Null Pointer exception");
        }
    }
    void LoadNextLevel()
    {
        Application.Quit();
    }
}
