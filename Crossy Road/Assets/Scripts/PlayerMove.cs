using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerMove : MonoBehaviour
{

    Rigidbody rb;

    public float moveSpeed;
    public Vector3 move = Vector3.zero;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //rb.velocity = move;
    }


    public void OnMove(InputValue input)
    {
        Vector2 dir = input.Get<Vector2>();
        
        if (dir == Vector2.right) 
        {
            transform.Translate(dir);
        }

        else if (dir == Vector2.left)
        {
            transform.Translate(dir);
        }
        
        else if (dir == Vector2.up)
        {
            transform.Translate(new Vector3(0,0,1));
        }
        else if(dir == Vector2.down)
        {
            transform.Translate(new Vector3(0, 0, -1));
        }
    }
}
