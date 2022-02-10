using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchingPlayers : MonoBehaviour
{
    public GameObject otherPlayer;

    private void OnMouseDown()
    {
        otherPlayer.GetComponent<MovingPlayer>().enabled = false;
        GetComponent<MovingPlayer>().enabled = true;
    }

}
