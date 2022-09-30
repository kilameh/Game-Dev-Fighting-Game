using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class P2name : MonoBehaviour
{
    public static P2name sceneb;
    public TMP_InputField inputField;
    public string player2_name;

    private void Awake()
    {
        if(sceneb == null)
        {
            sceneb = this;
            DontDestroyOnLoad(gameObject);
        }
        else 
        {
            Destroy(gameObject);
        }
    }

    public void setplayer1name()
    {
        player2_name = inputField.text;
        SceneManager.LoadSceneAsync("Versus2");
    }
}
