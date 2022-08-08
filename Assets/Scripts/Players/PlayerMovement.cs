using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
 public enum Groups 
    { 
        Groupe1,
        Groupe2
    }

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 80f;
    [SerializeField] private float addSpeed = 120f;
   
    [SerializeField] private float rotateSpeed = 300f;
    [SerializeField] private float addRotateSpeed = 400f;
   
    private bool increaseSpeed;
    public bool IncreaseSpeed
    {
        get { return increaseSpeed; }
        set { increaseSpeed = value; }
    }

    private const string VERTICAL1_AXIS = "Vertical1";
    private const string HORIZONTAL1_AXIS = "Horizontal1";

    private const string VERTICAL2_AXIS = "Vertical2";
    private const string HORIZONTAL2_AXIS = "Horizontal2";

    private float v1Input;
    private float h1Input;

    private float v2Input;
    private float h2Input;

    [SerializeField] private Light light;

    public Groups myGroup;

    private Rigidbody rb;

    public PlayerHPdata playerData;

    private void OnEnable()
    {
        light.enabled = true;
    }

    private void OnDisable()
    {
        light.enabled = false;
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {

        if (myGroup == Groups.Groupe1)
        {
            v1Input =(Input.GetAxis(VERTICAL1_AXIS) * moveSpeed) * playerData.DoubleSpeed;
            h1Input =(Input.GetAxis(HORIZONTAL1_AXIS) * rotateSpeed) * playerData.DoubleSpeed;
            if (increaseSpeed)
            {
                v1Input = v2Input = Input.GetAxis(VERTICAL2_AXIS) * addSpeed;
                h1Input = Input.GetAxis(HORIZONTAL2_AXIS) * addRotateSpeed;
                increaseSpeed = false;
            }
        }

        else if (myGroup == Groups.Groupe2)
        {
            v2Input = Input.GetAxis(VERTICAL2_AXIS) * moveSpeed/** playerData.DoubleSpeed*/;
            h2Input = Input.GetAxis(HORIZONTAL2_AXIS) * rotateSpeed /** playerData.DoubleSpeed*/;
            if (increaseSpeed)
            {
                v2Input = v2Input = Input.GetAxis(VERTICAL2_AXIS) * addSpeed;
                h2Input = Input.GetAxis(HORIZONTAL2_AXIS) * addRotateSpeed;
                increaseSpeed = false;
            }
        }
        
    }
    private void FixedUpdate()
    {   

        if (myGroup == Groups.Groupe1)
        {
            Vector3 rotation = Vector3.up * h1Input;
            Quaternion angleRot = Quaternion.Euler(rotation * Time.fixedDeltaTime);

            rb.MovePosition(transform.position + transform.forward * v1Input);
            rb.MoveRotation(rb.rotation * angleRot);
            
        }
        else if(myGroup == Groups.Groupe2)
        {
             Vector3 rotation = Vector3.up * h2Input;
             Quaternion angleRot = Quaternion.Euler(rotation * Time.fixedDeltaTime);

             rb.MovePosition(transform.position + transform.forward * v2Input);
             rb.MoveRotation(rb.rotation * angleRot);
            
        }
        
    }

    
}
