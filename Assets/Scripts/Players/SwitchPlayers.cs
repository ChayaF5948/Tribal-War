using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPlayers : MonoBehaviour
{
    [SerializeField]
    private KeyCode playerContral;


    [SerializeField] private PlayerNumber playerNumber;
    [SerializeField] private PlayerMovement[] playerMovement;
    [SerializeField] private PlayerAbility[] playerAbilitiy;
   


    [SerializeField]
    private bool iCaught = false;
    public bool Icaught
    {

        get { return iCaught; }
        set { iCaught = value; }
    }



    // Start is called before the first frame update
    void Start()
    {
        if (playerNumber == PlayerNumber.Player1)
        {
            playerMovement[0].enabled = true;
            playerAbilitiy[0].enabled = true;
        }
        if (playerNumber == PlayerNumber.Player2)
        {
            playerMovement[0].enabled = false;
            playerAbilitiy[0].enabled = false;
        }
        if (playerNumber == PlayerNumber.Player3)
        {
            playerMovement[0].enabled = false;
            playerAbilitiy[0].enabled = false;
        }
       
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(playerContral) && !iCaught)
        {
            playerMovement[0].enabled = true;
            playerMovement[1].enabled = false;
            playerMovement[2].enabled = false;

            playerAbilitiy[0].enabled = true;
            playerAbilitiy[1].enabled = false;
            playerAbilitiy[2].enabled = false;

        }

        //else if (Input.GetKeyDown(playerContral) && !iCaught)
        //{
        //    //witchPlayer[1] = curnetPlayer;
        //    if (playerNumber == PlayerNumber.Player1)
        //    {
        //        playerMovement.enabled = false;
        //    }
        //    if (playerNumber == PlayerNumber.Player2)
        //    {
        //        playerMovement.enabled = true;
        //    }
        //    if (playerNumber == PlayerNumber.Player3)
        //    {
        //        playerMovement.enabled = false;
        //    }
            

        //}

        //else if (Input.GetKeyDown(playerContral) && !iCaught)
        //{
        //    //witchPlayer[2] = curnetPlayer;
        //    if (playerNumber == PlayerNumber.Player1)
        //    {
        //        playerMovement.enabled = false;
        //    }
        //    if (playerNumber == PlayerNumber.Player2)
        //    {
        //        playerMovement.enabled = false;
        //    }
        //    if (playerNumber == PlayerNumber.Player3)
        //    {
        //        playerMovement.enabled = true;
        //    }
            
        //}
    }
   
}
