using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class Healthbar : MonoBehaviour
{

    public float healthvaluep1 = 100f;
    public float healthvaluep2 = 100f;

    public Button Attack1button;
    public Button Attack2button;
public TextMeshProUGUI Healthp1;
public TextMeshProUGUI Healthp2;
    void Start()
    {
        Attack1button.onClick.AddListener(Attack1);
        Attack2button.onClick.AddListener(Attack2);
        Healthp1 = GetComponent<TextMeshProUGUI>();
        Healthp2 = GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
         Healthp1.text = healthvaluep1.ToString();
         Healthp2.text = healthvaluep2.ToString();
    }

    public void Attack1(){
        healthvaluep1 -=25f;
        if(healthvaluep1 <=0)
        {
            healthvaluep1 =0;
            SceneManager.LoadScene(1);
        }
    }

    public void Attack2(){
        healthvaluep2 -=25f;
         if(healthvaluep2 <= 0)
         {
            SceneManager.LoadScene(2);
    }
    }
}
