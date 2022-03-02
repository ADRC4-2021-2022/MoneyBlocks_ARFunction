using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGrid : MonoBehaviour
{
    private static MyGrid _instance;

    public static MyGrid Instance
    {
        get
        {
            return _instance;
        }
    }

    public static int w = 40;
    public static int h = 80;

    public Transform[,] grid = new Transform[w, h];

    void Awake()
    {
        _instance = this;
    }


    public Vector2 RoundVector2(Vector2 pos)
    {
        return new Vector2(Mathf.Round(pos.x), Mathf.Round(pos.y));
    }

    public bool IsInside(Vector2 pos)
    {
        return (pos.x >= 0 && pos.x < w && pos.y >= 0);
    }

    public bool IsRowFull(int y)
    {
        for (int x = 0; x < w; x++)
        {
            if (grid[x, y] == null)
            {
                return false;
            }
        }
        return true;
    }

    public void DecreaseRow(int y)
    {
        for (int x = 0; x < w; x++)
        {
            if (grid[x, y] != null)
            {
                grid[x, y - 1] = grid[x, y];
                grid[x, y] = null;

                grid[x, y - 1].position += new Vector3(0, -1, 0);
            }
        }
    }

    public void DecreaseRowAbove(int y)
    {
        for (int i = y; i < h; i++)
        {
            DecreaseRow(i);
        }
    }

}
