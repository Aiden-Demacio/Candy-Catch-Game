using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    private Rigidbody2D rb;


    public float speed;
    public float horizontalInput;
    //private static Controls _controls;
    //public static void init(Player myPlayer)
    //{
    //    //    _controls = new Controls();


    //    //    _controls.Game.Movement.performed += ctx =>
    //    //    {
    //    //        myPlayer.SetMovementDirection(ctx.ReadValue<Vector3>());
    //    //    };


    //    //    };
        
    //}


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxisRaw("Horizontal");
        if (horizontalInput != 0)
        {
            rb.AddForce(new Vector3(horizontalInput * speed, 0f, 0f));
        }
        
    }





}
