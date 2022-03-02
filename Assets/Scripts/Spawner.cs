using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] standbyGroup;
    private GameObject lastGo;

    



    
    public void SpawnNext()
    {
        
        GameObject go = Instantiate(standbyGroup[FindObjectOfType<Queue>().Next()], this.transform.position, Quaternion.identity);
        go.transform.parent = this.transform;
        go.tag = "Player";
        lastGo = go;
    }




    void Start()
    {

        SpawnNext();


    }



   
}
