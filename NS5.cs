using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NS5 : MonoBehaviour
{

    private float health;
    public float maxHealth = 100f;
    public float chipSpeed = 2f;
    public Image frontHealthBar;
    public Image backHealthBar;

    // LIFE 
    [Range(0,1)]
    [SerializeField] float healthValue = 1f;
    [SerializeField] Image foreground = null;

    public Button lowpunchbutton;
    public Button highpunchbutton;
    public Button lowkickbutton;
    public Button highkickbutton;
    public Button Specialbutton;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    public void start(){
        lowpunchbutton.onClick.AddListener(lowpunch);
        highpunchbutton.onClick.AddListener(highpunch);
        lowkickbutton.onClick.AddListener(lowkick);
        highkickbutton.onClick.AddListener(highkick);
        Specialbutton.onClick.AddListener(special);
    }

    public void lowpunch(){
        int attack1p1, accuracyp1 = 75;
            attack1p1 = Random.Range(0,100);
        if(attack1p1 <= accuracyp1){
            healthValue -= 0.03f;
            foreground.fillAmount = healthValue;
            Debug.Log("Attack Success");
        }
        else{
            Debug.Log("Attack Missed");
        }
    }


    public void highpunch(){
        int attack2p1, accuracyp2 = 55;
            attack2p1 = Random.Range(0,100);
        if(attack2p1 <= accuracyp2){
            healthValue -= 0.08f;
        foreground.fillAmount = healthValue;
        Debug.Log("Attack Success");
        }
        else{
            Debug.Log("Attack Missed");
        }
    }

    public void lowkick(){
        int attack3p1, accuracyp3 = 65;
            attack3p1 = Random.Range(0,100);
        if(attack3p1 <= accuracyp3){
            healthValue -= 0.06f;
            foreground.fillAmount = healthValue;
            Debug.Log("Attack Success");
        }
        else{
            Debug.Log("Attack Missed");
        }
    }

    public void highkick(){
        int attack4p1, accuracyp4 = 45;
            attack4p1 = Random.Range(0,100);
        if(attack4p1 <= accuracyp4){
            healthValue -= 0.12f;
            foreground.fillAmount = healthValue;
            Debug.Log("Attack Success");
        }
        else{
            Debug.Log("Attack Missed");
        }
    }

    public void special(){
        healthValue -= 0.25f;
        foreground.fillAmount = healthValue;
        Debug.Log("Attack Success");
    }

    // Update is called once per frame
    void Update()
    {
        health = Mathf.Clamp(health, 0, maxHealth);
        UpdateHealthUI();
    }

    public void UpdateHealthUI()
    {
        Debug.Log(health);
        float fillF = frontHealthBar.fillAmount;
        float fillB = backHealthBar.fillAmount;
        float hFraction = health/maxHealth;
        if (fillB > hFraction){
            frontHealthBar.fillAmount = hFraction;
            backHealthBar.color = Color.red;
        }
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
    }
}
