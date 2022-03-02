using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ARGroups : MonoBehaviour
{
    


    public float freezingTime = 0.5f;

    private float pressingButtonTime = 0f;

    private float lastFallTime = 0;

    

    // Use this for initialization
    

    // Update is called once per frame
    void Update()
    {
     // UpdateGrid();
     

    }

   
    
    
    private bool IsValidGridPos()
    {
        foreach (Transform child in transform)
        {
            Vector2 v = MyGrid.Instance.RoundVector2(child.position);
            // ±ß½ç¼ì²â
            /*
            if (!MyGrid.Instance.IsInside(v))
            {
                Debug.Log("222222");
                Debug.Log(this.gameObject.name);
                return false;
            }*/
            if (MyGrid.Instance.grid[(int)v.x, (int)v.y] != null && MyGrid.Instance.grid[(int)v.x, (int)v.y].parent != this.transform)
            {

                Debug.Log(this.gameObject.name);
                return false;
            }
        }
        return true;
    }
    
    
    
    private void UpdateGrid()
    {
        for (int x = 0; x < MyGrid.w; x++)
        {
            for (int y = 0; y < MyGrid.h; y++)
            {
              

                
                   if (MyGrid.Instance.grid[x, y] != null)
                   {
                     if (MyGrid.Instance.grid[x, y].parent == transform)
                     {
                         MyGrid.Instance.grid[x, y] = null;
                     }
                   }
                
            }
        }

        foreach (Transform child in transform)
        {
            Vector2 v = MyGrid.Instance.RoundVector2(child.position);

            MyGrid.Instance.grid[(int)v.x, (int)v.y] = child;
        }
    }
    
   


    







}
