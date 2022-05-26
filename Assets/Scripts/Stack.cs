using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stack : MonoBehaviour
{
  public List<GameObject> bottles; //ilk elemanda her zaman oyuncu olacak, basitleştirmek için bottles ismi koyuldu

  private void Start() {
    AddBottle(this.gameObject);
  }

  public void AddBottle(GameObject bottle){
    bottles.Add(bottle);
  }

  private void PopBottles(int index){
    bottles.RemoveRange(index, bottles.Count - index - 1);
  }
}
