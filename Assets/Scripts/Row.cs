using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Row
{
    private List<Box> listBoxs = new List<Box>();

  
    public void AddBox(Box box)
    {
        listBoxs.Add(box);
       
    }
}
