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
    if(bottle.GetComponent<BottleManager>() != null){
      bottle.GetComponent<BottleManager>().index = bottles.Count;
      bottle.GetComponent<BottleManager>().bottles = this;
    }
    bottles.Add(bottle);
  }

  public void PopBottles(int index){
    bottles.RemoveRange(index, bottles.Count - index - 1);
  }
}
