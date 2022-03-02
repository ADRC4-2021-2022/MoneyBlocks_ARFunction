using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Queue : MonoBehaviour
{
    public GameObject[] standbyGroup;

    private int[] showGroup;

    public int sgLimit = 3;


    private float timeFrame = 1.0f;

    public float TimeFrame
    {
        get
        {
            return timeFrame;
        }
    }

    // Use this for initialization
    void Start()
    {
        showGroup = new int[sgLimit];
        FillShowGroup();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public int Next()
    {
        int currentPieces = showGroup[0];
        FlushShowGroup();
        FillShowGroup(sgLimit - 1);
        return currentPieces;
    }


    private void FlushShowGroup()
    {
        //将队列头移除到正式的游戏面板当中
        GameObject[] currentPieces = GameObject.FindGameObjectsWithTag("ShowGroup");
        Destroy(currentPieces[0]);
        MoveUp();
    }


    private void MoveUp(int i = 0)
    {
        //递归，依次上升
        if (i < sgLimit - 1)
        {
            showGroup[i] = showGroup[++i];
            GameObject[] previousPieces = GameObject.FindGameObjectsWithTag("ShowGroup");
            previousPieces[i].transform.position += new Vector3(0, 10.0f, 0);
            MoveUp(i);
        }
    }

    private void FillShowGroup(int i = 0)
    {
        //将方块都显示在面板上
        if (i < sgLimit)
        {
            Debug.Log(i);
            AddToShowGroup(i);
            FillShowGroup(++i);

        }
    }


    private void AddToShowGroup(int i)
    {

        //选择一块，显示在面板  choose one piece and show on the panel

        showGroup[i] = Random.Range(0, standbyGroup.Length);

        GameObject go = Instantiate(standbyGroup[showGroup[i]], transform.position + new Vector3(0, i * -10, -1), Quaternion.identity);

        go.transform.parent = this.transform;
    }
}
