using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
  public Animator playerAnim;
  
  public void startAnim(){
    playerAnim.SetBool("started", true);
  }

  public void winAnim(){
    playerAnim.SetBool("win", true);
  }

  public void failAnim(){
    playerAnim.SetBool("failed", true);
  }

}
