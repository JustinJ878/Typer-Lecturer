using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //Buat manggil nanti textnya
    public GameObject Prefab;
    public Transform canvas;

    public GameObject SpawnWords()
    {
        Vector3 randomPos = new Vector3(900f, Random.Range(88f, 488f));

        GameObject obj = Instantiate(Prefab,randomPos, Quaternion.identity, canvas);
        obj.GetComponent<CollisionDetection>();

        return obj;
    }
}
