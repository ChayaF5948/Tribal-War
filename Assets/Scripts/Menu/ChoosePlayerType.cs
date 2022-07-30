using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosePlayerType : MonoBehaviour
{
    public GameObject player;
    
    [SerializeField]
    private GameObject playerType1;
    [SerializeField]
    private GameObject playerType2;

    public void UsePlayerType1()
    {
        player = playerType1;
    }

    public void UsePlayerType2()
    {
        player = playerType2;
    }
}
