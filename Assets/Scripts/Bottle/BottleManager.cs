using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleManager : MonoBehaviour
{
  [HideInInspector]
  public int index = -1;
  [HideInInspector]
  public Stack bottles;

  public void bottleDestroy(){
    Destroy(this.gameObject);
  }
}
