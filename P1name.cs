using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class P1name : MonoBehaviour
{
    public static P1name scenea;
    public TMP_InputField inputField;
    public string player1_name;

    private void Awake()
    {
        if(scenea == null)
        {
            scenea = this;
            DontDestroyOnLoad(gameObject);
        }
        else 
        {
            Destroy(gameObject);
        }
    }

    public void setplayer1name()
    {
        player1_name = inputField.text;
        SceneManager.LoadSceneAsync("P2 name");
    }
}
