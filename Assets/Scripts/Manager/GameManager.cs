using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;


public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    //public UnityAction<int, int, bool> OnFlagConquered;
    public UnityAction<int,Groups> OnFlagChange;
    public UnityAction OnPLayerCatch;
    
   
    //private int flagGro1num = 4;
    //private int flagGro2num = 4;
    private Dictionary<Groups, int> groupsFlagsScores = new Dictionary<Groups, int>();
    //private Groups groupFlag;
    //public Groups GroupFlag
    //{
    //    get { return groupFlag; }
    //    set {groupFlag = value;
    //        OnFlagConquered(groupFlag);
    //    }
    //}

    public UnityAction<bool> OnGro1Win;
    public UnityAction<bool> OnGro2Win;
    private bool is1GroWin;
    private bool is2GroWin;

    private bool isConquered = false;

    
    private bool thePlayerCaught;

    private void Awake()
    {
        Instance = this;
        groupsFlagsScores.Add(Groups.Groupe1, 4);
        groupsFlagsScores.Add(Groups.Groupe2, 4);
    }

    //public bool IsConquered
    //{

    //    get { return isConquered; }
    //    set
    //    {
    //        isConquered = value;
    //        Debug.Log("The flag Caught Group1");
    //        if (isConquered)
    //        {
    //            //OnFlagConquered?.Invoke(flagGro1num, flagGro2num, isConquered);
    //            isConquered = false;
    //        }
    //    }
    //}

    //public int FlagGro1Num
    //{

    //    get { return flagGro1num; }
    //    set { flagGro1num = value;
            
    //    }

    //}

    //public int FlagGro2Num
    //{
    //    get { return flagGro2num; }
    //    set { flagGro2num = value;
    //    }
    //}

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
        Debug.Log(group);
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
