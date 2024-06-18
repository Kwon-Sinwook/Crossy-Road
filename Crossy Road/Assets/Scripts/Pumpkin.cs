using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pumpkin : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 move;
    public Vector3 dir = Vector3.zero;
    public float moveSpeed;


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        moveSpeed = Random.Range(7, 20);
    }

    private void Update()
    {
        move = dir * moveSpeed;
        rb.velocity = move;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            this.gameObject.SetActive(false);
        }
    }

    public void SetDir(int i)
    {
        if(i == 0)
        {
            dir = Vector3.right;
        }

        else if(i == 1)
        {
            dir = Vector3.left;
        }

        else if (i == 2)
        {
            dir = Vector3.back;
        }

        else if (i == 3)
        {
            dir = Vector3.forward;
        }
    }
}
