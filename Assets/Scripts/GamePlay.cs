using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlay : MonoBehaviour
{
    //prefabs
    public Box box;
  

    public List<Row> listRows = new List<Row>();
    public List<Column> listCols = new List<Column>();
    // Start is called before the first frame update
    void Start()
    {
        int numberOfRow = 5;
        //int numberOfCol = 5;
        //Vector2 anchorPos = new Vector2(-8, -4);
        //for (int i = 0; i < numberOfRow; i++)
        //{
        //    Row newRow = new Row();
        //    for (int j = 0; j < numberOfCol; j++)
        //    {
        //        box.ResetFruit();
        //        Box newBox = Instantiate(box);
        //        newBox.transform.position = new Vector2(j* 2, i*2) + anchorPos;
        //        newRow.AddBox(newBox);
        //    }
        //    listRows.Add(newRow);
        //}
        int x = -4, y = -3;
        int j = numberOfRow;
        int t = 0;
        int i=0;
        Vector2 anchorPos = new Vector2(x, y);
        while (j>=1)
        {
            Row newRow = new Row();
            while (t!=j)
            {
                box.ResetFruit();
                Box newBox = Instantiate(box);
                newBox.transform.position = new Vector2(t * 2,  i * 2) + anchorPos;
                newRow.AddBox(newBox);
                t++;
                
            }
            t = 0;
            i++;
            j = j - 2;
            listRows.Add(newRow);
            x += 2;
            anchorPos = new Vector2(x, y);
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.name = Time.time.ToString();
       
    }
}
