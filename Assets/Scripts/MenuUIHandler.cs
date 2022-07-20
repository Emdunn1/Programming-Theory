using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    public static MenuUIHandler data;
    public TMP_InputField inputField;

    public string playerName;
    private void Awake()
    {
        if (data != null)
        {
            Destroy(gameObject);
        }
        data = this;
        DontDestroyOnLoad(gameObject);
    }

    public void SetName()
    {
        //ENCAPSULATION
        if (inputField.text.Length > 10)
        {
            Debug.LogError("Name must be at most ten characters long!");
        }
        else
        {
            playerName = inputField.text;
            SceneManager.LoadScene(1);
        }
    }
}
