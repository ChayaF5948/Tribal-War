using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAbility : MonoBehaviour
{
    public PlayerHPdata playerHP;
    [SerializeField] private KeyCode keyShoot;
    
    private bool canShoot = false;
    
    public bool CanShoot
    {

        get { return canShoot; }
        set { canShoot = value; }
    }

    [SerializeField] GameObject bullet;
    [SerializeField]  private float bulletSpeed = 100;
     private PlayerBeaviour playerBeaviour;

    


    void Start()
    {
        playerBeaviour = GetComponent<PlayerBeaviour>();
        canShoot = false;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(keyShoot) && playerHP.Bullets >= 1 && playerBeaviour.IsMyGround)
        {
            canShoot = true;
            playerHP.Bullets--;
        }
        
    }

    private void FixedUpdate()
    {
        if(canShoot)
        {
            canShoot = false;
            GameObject newBullet = Instantiate(bullet, transform.position + new Vector3(1, 0, 0), transform.rotation);
            newBullet.GetComponent<Rigidbody>().velocity = transform.forward * bulletSpeed;
        }
    }

}
