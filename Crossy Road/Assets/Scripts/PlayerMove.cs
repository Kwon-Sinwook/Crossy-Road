using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerMove : MonoBehaviour
{
    private Vector3 forward = new Vector3(0, 0, 1);
    private Vector3 back = new Vector3(0, 0, -1);
    private Vector3 right = new Vector3(1, 0, 0);
    private Vector3 left = new Vector3(-1, 0, 0);

    public void OnMove(InputValue input)
    {
        Vector2 dir = input.Get<Vector2>();
        
        if (dir == Vector2.right) 
        {
            transform.Translate(right);
        }

        else if (dir == Vector2.left)
        {
            transform.Translate(left);
        }
        
        else if (dir == Vector2.up)
        {
            transform.Translate(forward);
        }
        else if(dir == Vector2.down)
        {
            transform.Translate(back);
        }
    }
}
