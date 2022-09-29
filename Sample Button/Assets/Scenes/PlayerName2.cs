using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName2 : MonoBehaviour
{
    public string nameOfPlayer2;
    public string saveName2;

    public Text inputText2;
    public Text loadedName2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        nameOfPlayer2 = PlayerPrefs.GetString("name", "none");
        loadedName2.text = nameOfPlayer2;
    }

    public void SetName()
    {
        saveName2 = inputText2.text;
        PlayerPrefs.SetString("name", saveName2);
    }
}
