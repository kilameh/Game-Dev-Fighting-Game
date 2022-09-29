using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class fightingscript : MonoBehaviour
{
// Health Bar 
 [Range(0,1)]
 [SerializeField] float healthValue = 1f;
 [SerializeField] Image foreground = null;
 [SerializeField] Image foreground2 = null;

//button ni jom
public Button lowpunchbutton, highpunchbutton, lowkickbutton, highkickbutton, Specialbutton;

//button ni joshed
public Button lowpunch2button, highpunch2button, lowkick2button, highkick2button, Special2button; 

    //Jom missed vidclips
    public VideoClip P1LowPunch,P1HighPunch, P1LowKick, P1HighKick, P1Special;
    // Joshed missed vidclips
    public VideoClip P2LowPunch, P2HighPunch, P2LowKick, P2HighKick, P2Special;
    
    //Jom missed vidclips
    public VideoClip P1MissLowPunch,P1MissHighPunch,P1MissLowKick,P1MissHighKick;
    //Joshed missed vidclips
    public VideoClip P2MissLowPunch,P2MissHighPunch,P2MissLowKick,P2MissHighKick;

    //win vidclips
    public VideoClip P1Win, P2Win;

    public VideoClip inIdle; // idle video
    public VideoPlayer videoplayer;

    public void Awake()
    {
        videoplayer=GetComponent<VideoPlayer>();   
    }

    public void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
            Debug.Log("over");
            idling();
    }

    public void start()
    {
        lowpunchbutton.onClick.AddListener(P1LowPunchChoice);
        highpunchbutton.onClick.AddListener(P1HighPunchChoice);
        lowkickbutton.onClick.AddListener(P1LowKickChoice);
        highkickbutton.onClick.AddListener(P1HighKickChoice);
        Specialbutton.onClick.AddListener(P1SpecialChoice);

        lowpunch2button.onClick.AddListener(P2LowPunchChoice);
        highpunch2button.onClick.AddListener(P2HighPunchChoice);
        lowkick2button.onClick.AddListener(P2LowKickChoice);
        highkick2button.onClick.AddListener(P2HighKickChoice);
        Special2button.onClick.AddListener(P2SpecialChoice);
    }

    public void update()
    {

    }

    //button functions for P1 / Jom
    public void P1LowPunchChoice()
    {
        videoplayer.clip = P1LowPunch;
        videoplayer.isLooping = false;
        videoplayer.loopPointReached += CheckOver;

        int attack1p1, accuracyp1 = 75;
        attack1p1 = Random.Range(0,100);
            
        if(attack1p1 <= accuracyp1)
        {
            healthValue -= 0.03f;
            foreground2.fillAmount = healthValue;

            Debug.Log("Attack Success");
            }
        else
            {
            videoplayer.clip = P1MissLowPunch;
            videoplayer.isLooping = false;
            videoplayer.loopPointReached += CheckOver; 
         
            Debug.Log("Attack Missed");
            }
    }

    public void P1HighPunchChoice()
    {
        videoplayer.clip = P1HighPunch;
        videoplayer.isLooping = false;
        videoplayer.loopPointReached += CheckOver;
    
        int attack2p1, accuracyp2 = 55;
        attack2p1 = Random.Range(0,100);
        
        if(attack2p1 <= accuracyp2)
        {
            healthValue -= 0.08f;
            foreground2.fillAmount = healthValue;
        
            Debug.Log("Attack Success");

            }
            else
            {
            videoplayer.clip = P1MissHighPunch;
            videoplayer.isLooping = false;
            videoplayer.loopPointReached += CheckOver;   
            Debug.Log("Attack Missed");
            }
    }

    public void P1LowKickChoice()
    {
        videoplayer.clip = P1LowKick;
        videoplayer.isLooping = false;
        videoplayer.loopPointReached += CheckOver;

        int attack3p1, accuracyp3 = 65;
        attack3p1 = Random.Range(0,100);
            
        if(attack3p1 <= accuracyp3)
        {
            healthValue -= 0.06f;
            foreground2.fillAmount = healthValue;

            Debug.Log("Attack Success");
        }
        else
        {
            videoplayer.clip = P1MissLowKick;
            videoplayer.isLooping = false;
            videoplayer.loopPointReached += CheckOver;   
            Debug.Log("Attack Missed");
        }
    }

    public void P1HighKickChoice()
    {
        videoplayer.clip = P1HighKick;
        videoplayer.isLooping = false;
        videoplayer.loopPointReached += CheckOver;

        int attack4p1, accuracyp4 = 45;
        attack4p1 = Random.Range(0,100);
            
        if(attack4p1 <= accuracyp4)
        {
            healthValue -= 0.12f;
            foreground2.fillAmount = healthValue;

            Debug.Log("Attack Success");
        }
        else
        {
            videoplayer.clip = P1MissHighKick;
            videoplayer.isLooping = false;
            videoplayer.loopPointReached += CheckOver;   
            Debug.Log("Attack Missed");
        }
    }

    public void P1SpecialChoice()
    {
        videoplayer.clip = P1Special;
        videoplayer.isLooping = false;
        videoplayer.loopPointReached += CheckOver;

        healthValue -= 0.25f;
        foreground2.fillAmount = healthValue;
        Debug.Log("Attack Success");
    }

    //button functions for P2 / Joshed
    public void P2LowPunchChoice()
    {
        videoplayer.clip = P2LowPunch;
        videoplayer.isLooping = false;
        videoplayer.loopPointReached += CheckOver;

        int attack5p2, accuracyp5 = 75;
        attack5p2 = Random.Range(0,100);
            
        if(attack5p2 <= accuracyp5)
        {
            healthValue -= 0.03f;
            foreground.fillAmount = healthValue;

            Debug.Log("Attack Success");
        }
        else
        {
            videoplayer.clip = P2MissLowPunch;
            videoplayer.isLooping = false;
            videoplayer.loopPointReached += CheckOver;   
            Debug.Log("Attack Missed");
        }

    }

    public void P2HighPunchChoice()
    {
        videoplayer.clip = P2HighPunch;
        videoplayer.isLooping = false;
        videoplayer.loopPointReached += CheckOver;

        int attack6p2, accuracyp6 = 55;
        attack6p2 = Random.Range(0,100);
        
        if(attack6p2 <= accuracyp6)
        {
            healthValue -= 0.08f;
            foreground.fillAmount = healthValue;
        
            Debug.Log("Attack Success");

        }
        else
        {
            videoplayer.clip = P2MissHighPunch;
            videoplayer.isLooping = false;
            videoplayer.loopPointReached += CheckOver;   
            Debug.Log("Attack Missed");
        }
    }

    public void P2LowKickChoice()
    {
        videoplayer.clip = P2LowKick;
        videoplayer.isLooping = false;
        videoplayer.loopPointReached += CheckOver;

        int attack7p2, accuracyp7 = 65;
        attack7p2 = Random.Range(0,100);
            
        if(attack7p2 <= accuracyp7)
        {
            healthValue -= 0.06f;
            foreground.fillAmount = healthValue;

            Debug.Log("Attack Success");
        }
        else
        {
            videoplayer.clip = P2MissLowKick;
            videoplayer.isLooping = false;
            videoplayer.loopPointReached += CheckOver;   
            Debug.Log("Attack Missed");
        }
    }

    public void P2HighKickChoice()
    {
        videoplayer.clip = P2HighKick;
        videoplayer.isLooping = false;
        videoplayer.loopPointReached += CheckOver;

        int attack8p2, accuracyp8 = 45;
        attack8p2 = Random.Range(0,100);
            
        if(attack8p2 <= accuracyp8)
        {
            healthValue -= 0.12f;
            foreground.fillAmount = healthValue;

            Debug.Log("Attack Success");
        }
        else
        {
            videoplayer.clip = P2MissHighKick;
            videoplayer.isLooping = false;
            videoplayer.loopPointReached += CheckOver;   
            Debug.Log("Attack Missed");
        }
    }

    public void P2SpecialChoice()
    {
        videoplayer.clip = P2Special;
        videoplayer.isLooping = false;
        videoplayer.loopPointReached += CheckOver;

        healthValue -= 0.25f;
        foreground.fillAmount = healthValue;
        Debug.Log("Attack Success");
    }

    //button functions for idle
    public void idling()
    {
        videoplayer.isLooping = true;
        videoplayer.clip = inIdle;
    }

    public void winning()
    {
        if(healthValue == 0f)
        {   
            videoplayer.clip = P1Win;
            videoplayer.isLooping = false;
        }
        else
        {
            Debug.Log("System error");
        }
    }
}