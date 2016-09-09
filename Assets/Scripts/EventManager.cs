using UnityEngine;
using System.Collections;

public class EventManager : MonoBehaviour {

	private GameController gameController;

	private GameObject player;

	public static EventManager instance
	{
		get { return GameObject.FindObjectOfType<EventManager>(); }
	}

	void Awake ()
	{
		gameController = GameController.instance;
	}
	
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
	}

	public void OnPlayerEnemyCollision()
	{
		player.SetActive(false);
	}

	public void OnPlayerSwitchCollision(GameObject switchInstance)
	{
		ColorState color = switchInstance.GetComponent<ColorState>();
		gameController.SetGoalColor(color);
	}

}
