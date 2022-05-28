using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishCollision : MonoBehaviour
{
  public GameManager gm;
  private void OnTriggerEnter(Collider other) {
    gm.win();
  }
}
