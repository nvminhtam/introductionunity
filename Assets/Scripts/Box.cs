using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public List<Fruit> availableFruit;
    public Fruit fruit;
    void Start()
    {
        int randIndex = Random.Range(0, availableFruit.Count);
        fruit = Instantiate(availableFruit[randIndex], transform);
        fruit.transform.localPosition = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ResetFruit()
    {
        int randIndex = Random.Range(0, availableFruit.Count);
        fruit = availableFruit[randIndex];
    }

   
}
