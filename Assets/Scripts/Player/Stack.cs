using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stack : MonoBehaviour
{
  public List<GameObject> bottles; //ilk elemanda her zaman oyuncu olacak, basitleştirmek için bottles ismi koyuldu
  public GameObject[] GFXs;

  private void Start() {
    AddBottle(this.gameObject); //oyuncuyu ekler
  }

  public void AddBottle(GameObject bottle){
    if(bottle.GetComponent<BottleManager>() != null){
      switch (bottle.GetComponent<BottleManager>().tier)
      {
        case -1:
          bottle.tag = "can";
          
        break;
        case 0:
          bottle.tag = "glass bottle";
        break;
        case 1:
          bottle.tag = "plastic bottle";
        break;
        default:
        break;
      }
      //dağıldığında tekrardan yerden alabilmek için
      bottle.GetComponent<Rigidbody>().freezeRotation = true;
      bottle.GetComponent<Rigidbody>().useGravity = false;

      bottle.transform.rotation = Quaternion.identity;
      bottle.GetComponent<Collider>().isTrigger = true;

      bottle.GetComponent<BottleManager>().index = bottles.Count;
      bottle.GetComponent<BottleManager>().stack = this;
    }
    bottles.Add(bottle);
  }

  public void PopBottles(int index){

    if(index > bottles.Count - 1){ //?
      return;
    }
    for(int i = index; i < bottles.Count - 1 ; i++){
      bottles[i].tag = "bottle";
      bottles[i].GetComponent<Rigidbody>().freezeRotation = false;
      bottles[i].GetComponent<Collider>().isTrigger = false;
      bottles[i].GetComponent<Rigidbody>().useGravity = true;
      bottles[i].GetComponent<BottleManager>().fly();
    }
    bottles.RemoveRange(index, bottles.Count - index - 1);
  }

}
