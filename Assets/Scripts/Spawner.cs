using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //Buat manggil nanti textnya
    public GameObject Prefab;
    public Transform canvas;

    public DisplayWords SpawnWords()
    {
        Vector3 randomPos = new Vector3(900f, Random.Range(20f, 300f));

        GameObject obj = Instantiate(Prefab,randomPos, Quaternion.identity, canvas);
        DisplayWords wdp = obj.GetComponent<DisplayWords>();

        return wdp;
    }
}
