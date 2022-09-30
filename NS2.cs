using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NS2 : MonoBehaviour


{
    public string theName;
    public GameObject inputfield;

    public void PlayerName(){
        theName = inputfield.GetComponent<Text>().text;
    }

    public void NewScene1(){
        SceneManager.LoadScene(0);
    }

    public void NewScene2(){
        SceneManager.LoadScene(2);
    }
}
