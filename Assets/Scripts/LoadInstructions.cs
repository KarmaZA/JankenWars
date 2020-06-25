using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadInstructions : MonoBehaviour
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
        //LevelNumTrack.Level = 1;
        //Debug.Log(LevelNumTrack.Level);
        SceneManager.LoadScene(2);

        //Debug.Log(LevelNumTrack.Level);
    }
}
