using System.Collections;
using System.Collections.Generic;
using UnityEngine.iOS;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  public GameObject joystick;
  public GameObject player;
  public GameObject winPanel;

  public TypeOfManager tom;

  private PlayerMovement pmov;
  private PlayerManager pmag;
  private GameState gamestate;

  private void Start() 
  {
    pmov = player.GetComponent<PlayerMovement>();
    pmag = player.GetComponent<PlayerManager>();

    tom.UpdateScoreText();

    gamestate = GameState.initiliaze;
    pmov.enabled = false;
  }
  private void Update()
  {
      switch (gamestate)
		{
			case GameState.initiliaze:
        if(joystick.activeSelf == true){
          pmov.enabled = true;
          pmag.startAnim();
          gamestate = GameState.start;
        }
				break;
			case GameState.start:
				break;
			case GameState.stay:
          pmov.enabled = false;
        if(joystick.activeSelf == true){
          gamestate = GameState.restart;
        }
				break;
			case GameState.restart:
        restart();
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
    pmag.winAnim();
    winPanel.SetActive(true);
    gamestate = GameState.stay;
  }
  public void lose(){
    pmag.failAnim();
    gamestate = GameState.stay;
  }
}