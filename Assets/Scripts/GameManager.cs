using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  public PlayerMovement pm;
  private GameState gamestate;

  private void Start() 
  {
    gamestate = GameState.initiliaze;
    pm.enabled = false;
  }
  private void Update()
  {
      switch (gamestate)
		{
			case GameState.initiliaze:
				break;
			case GameState.start:
				break;
			case GameState.stay:
				break;
			case GameState.restart:
				break;
			default:
				break;
		}
  }
 
  public void restart()
	{
		SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
	}

  public void win(){
    
  }
  public void lose(){
    gamestate = GameState.restart;
  }
}