using UnityEngine.UI;
using UnityEngine;

public class TypeOfManager : MonoBehaviour
{
  public Text scoreText;
  private float initialScore = 200f;

  internal void DecreaseinitialScore(float amount){
    initialScore -= amount;
  }

  public void UpdateScoreText(){
    Debug.Log(initialScore);
    scoreText.text = initialScore.ToString();
  }
}
