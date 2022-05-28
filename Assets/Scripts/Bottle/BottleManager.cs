using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleManager : MonoBehaviour
{
  [HideInInspector]
  public int index = -1;
  [HideInInspector]
  public int tier = -1; 
  [HideInInspector]
  public Stack stack;

  public ParticleSystem particle;

  public void bottleDestroy(){
    particle.Stop();
    particle.Play();

    Destroy(this.gameObject);
  }

  public void fly(){
    GetComponent<Rigidbody>().AddForce((Vector3.back * Random.Range(-1f, 1f) + 
                                        Vector3.right * Random.Range(2f, 3f)) * 100f);
  }

  public void changeGFX(){
    tier++;
    particle.Stop();
    particle.Play();

    foreach (Transform item in transform)
    {
      if(item.tag == "gfx"){
        Destroy(item.gameObject);
      }
    }

    Instantiate(stack.GFXs[tier], transform.position, Quaternion.identity, transform);
  }
}
