using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stack : MonoBehaviour
{
  public Stack<GameObject>
  public List<GameObject> bottles;

  public void AddBottle(GameObject bottle){
    bottles.Add(bottle);
  }
  public void PopBottles(int index){
    bottles.RemoveRange(index, bottles.Count - (1 + index)); //şişenin yok olduğu yerden en uca kadarki şişeler stackden çıakrtılır.
  }
}
