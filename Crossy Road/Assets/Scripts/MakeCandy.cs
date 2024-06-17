using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeCandy : MonoBehaviour
{
    private ObjectPool pool;
    
    private int x = 0;
    private int z = 0;

    private float time = 0;

    private void Awake()
    {
        pool = GetComponent<ObjectPool>();
    }


    private void Update()
    {
        time += Time.deltaTime;

        if (time > 10f) 
        {
            Candy();
            time = 0f;
        }
    }

    public void Candy()
    {
        x = Random.Range(-14, 15);
        z = Random.Range(-14, 15);

        GameObject candy = pool.Get(1);
        candy.transform.position = new Vector3(x, 1, z);
        candy.SetActive(true);
    }


}
