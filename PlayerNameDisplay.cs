using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerNameDisplay : MonoBehaviour
{
public TextMeshProUGUI displayplayer1;
public TextMeshProUGUI displayplayer2;


public void Awake(){
    displayplayer1.text = P1name.scenea.player1_name;
    displayplayer2.text = P2name.sceneb.player2_name;
    }

}

