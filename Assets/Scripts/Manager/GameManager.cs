using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;


public class GameManager : MonoBehaviour
{

    public static GameManager Instance;
    public UnityAction OnPLayerCatch;
    
    private Dictionary<Groups, int> groupsFlagsScores = new Dictionary<Groups, int>();

    public UnityAction<bool> OnGro1Win;
    public UnityAction<bool> OnGro2Win;
    private bool is1GroWin;
    private bool is2GroWin;
  
    private bool thePlayerCaught;

    private void Awake()
    {
        Instance = this;
        groupsFlagsScores.Add(Groups.Groupe1, 4);
        groupsFlagsScores.Add(Groups.Groupe2, 4);
    }

    public bool ThePlayerCaught
    {
        set { thePlayerCaught = value;
            if (thePlayerCaught)
            {
                OnPLayerCatch?.Invoke();
                thePlayerCaught = false;
            }
        }
    }

    public void OnFlagConquered(Groups group)
    {
        switch (group)
        {
            case Groups.Groupe1:
                groupsFlagsScores[Groups.Groupe1]++;
                groupsFlagsScores[Groups.Groupe2]--;
                Debug.Log(group);
                break;
            case Groups.Groupe2:
                groupsFlagsScores[Groups.Groupe2]++;
                groupsFlagsScores[Groups.Groupe1]--;
                Debug.Log(group);
                break;
        }
    }

    public int GetFlagsScoresGroup(Groups groups)
    {
        return groupsFlagsScores[groups];
    }
}
