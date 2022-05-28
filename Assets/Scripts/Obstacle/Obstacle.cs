using UnityEngine;

public abstract class Obstacle : MonoBehaviour
{
  public TypeOfManager tom;

  internal float lostScoreAmount;
  public void DecreaseScore()
  { 
    tom.DecreaseinitialScore(lostScoreAmount);
    tom.UpdateScoreText();
  }
}
