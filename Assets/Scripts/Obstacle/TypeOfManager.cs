using UnityEngine.UI;
using UnityEngine;

public class TypeOfManager : MonoBehaviour
{
  [HideInInspector]
  public Text scoreText;
  private float initialScore = 200f;

  public void DecreaseinitialScore(float amount){
    initialScore -= amount;
  }

  public void IncreaseinitialScore(float amount){
    initialScore += amount;
  }

  public void UpdateScoreText(){
    scoreText.text = initialScore.ToString();
  }
}
