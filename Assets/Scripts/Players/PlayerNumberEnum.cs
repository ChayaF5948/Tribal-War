using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerNumber
{
    Player1 = 0,
    Player2 = 1,
    Player3 = 2,
    Player4 = 3 
}
public class PlayerNumberEnum : MonoBehaviour
{
    [SerializeField] PlayerNumber PlayerNumber;
}
