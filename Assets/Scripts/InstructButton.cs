using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InstructButton : MonoBehaviour
{
    public Button button;
    public Text intro;
    public Text control;
    // Start is called before the first frame update
    void Start()
    {
        try
        {
            button.onClick.AddListener(NextPage);
        }
        catch
        {

        }
    }
    void NextPage()
    {
        SceneManager.LoadScene(3);
    }
}
