using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class Wave : MonoBehaviour
{
    private ObjectPool pool;
    public Transform[] spawnPoint;

    private float time = 0f;
    private int randomIdx = 0;

    [SerializeField]
    private Transform[][] transforms;

    private void Awake()
    {
        pool = GetComponent<ObjectPool>();
        transforms = new Transform[spawnPoint.Length][];

        for (int i = 0; i < spawnPoint.Length; i++)
        {
            transforms[i] = spawnPoint[i].GetComponentsInChildren<Transform>();
        }
    }

    private void Update()
    {
        time += Time.deltaTime;

        if(time > 0.5f)
        {
            SpawnPumpkin();
            time = 0f;
        }

    }

    public void SpawnPumpkin()
    {
        for(int i = 0; i < spawnPoint.Length; i++)
        {
            randomIdx = Random.Range(1, transforms[0].Length);
            GameObject pumpkin = pool.Get(0);
            pumpkin.GetComponent<Pumpkin>().SetDir(i);
            pumpkin.transform.position = transforms[i][randomIdx].position;
            pumpkin.SetActive(true);
        }
    }
}
