using UnityEngine.UI;
using UnityEngine;

public class TypeOfManager : MonoBehaviour
{
  public Text scoreText;
  private float initialScore = 200f;

  internal void DecreaseinitialScore(float amount){
    initialScore -= amount;
  }

  internal void IncreaseinitialScore(float amount){
    initialScore += amount;
  }

  public void UpdateScoreText(){
    scoreText.text = initialScore.ToString();
  }
}
