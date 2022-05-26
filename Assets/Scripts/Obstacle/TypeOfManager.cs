using UnityEngine.UI;

public class TypeOfManager
{
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
