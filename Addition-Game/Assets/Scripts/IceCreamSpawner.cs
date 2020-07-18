using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceCreamSpawner : MonoBehaviour
{
    public Transform prefab;
    //private List<Transform> prefabClone;

    //private void Start()
    //{
    //    prefabClone = new List<Transform>();
    //}

    public void InstantiateIceCreamScoops(int number)
    {
        for (int i = 0; i < number; i++)
        {
            //prefabClone.Add(Instantiate(prefab, new Vector3(0, i * 2.0f, 0), Quaternion.identity, transform));
            Instantiate(prefab, new Vector3(0, i * 2.0f, 0), Quaternion.identity, transform);
        }
    }

    public void ClearScoopStack()
    {
        //for(int i = 0; i < prefabClone.Count; i++)
        //{
        //    Destroy(prefabClone[i]);
        //}
        foreach(Transform child in transform)
        {
            GameObject.Destroy(child.gameObject);
        }
    }
}
