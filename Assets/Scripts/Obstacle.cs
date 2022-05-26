public abstract class Obstacle : TypeOfManager
{
  internal float lostScoreAmount;
  public void DecreaseScore()
  { 
    DecreaseinitialScore(lostScoreAmount);
    UpdateScoreText(); 
  }
}
