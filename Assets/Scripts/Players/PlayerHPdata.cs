
using UnityEngine;
using UnityEngine.Events;
[CreateAssetMenu(fileName = "New Player HP", menuName = "Player HP", order = 53)]
public class PlayerHPdata : ScriptableObject
{ 
    private  float doubleSpeed =1 ;
    private int score;
    private int bullets;
    private int currentbullet = 15;

    private void Awake()
    {
        bullets = 0;
        Score = 0;
    }

    //private bool isShoot;

    public UnityAction<int> OnAddOrDecreaseBullet;
    public UnityAction OnShoot;

    public UnityAction<int> OnAddScore;

    public float DoubleSpeed
    {
        get => doubleSpeed;
        set => doubleSpeed = value;
    }

    //public int Score
    //{
    //    get => score;
    //    set => score = value;
    //}

    public int Bullets
    {
        get { return bullets; }
        set {
            if (bullets - 1 == value)
            {
                OnShoot?.Invoke();
                //Debug.Log("The Player shoot");
            }
            bullets = value;
            OnAddOrDecreaseBullet?.Invoke(Bullets);
            }
    }

    public int Score
    {
        get { return score; }
        set { score = value;
            OnAddScore?.Invoke(score);
        }
    }
     
    
    //public bool IsShoot
    //{
    //    get { return isShoot; }
    //    set { isShoot = value;
    //        if (isShoot)
    //        {
    //            OnShoot?.Invoke();
    //        }
    //        }

    //}

    

    

    

}
