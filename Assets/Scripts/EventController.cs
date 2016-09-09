using UnityEngine;
using System.Collections;

public class EventController : MonoBehaviour {

	private GameController gameController;

	private GameObject player;

	public static EventController instance
	{
		get { return GameObject.FindObjectOfType<EventController>(); }
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
		gameController.KillPlayer();
	}

	public void OnPlayerSwitchTrigger(GameObject switchInstance)
	{
		ColorState color = switchInstance.GetComponent<ColorState>();
		gameController.SetGoalColor(color);
	}

	public void OnGoalEnemyTrigger(GameObject goal, GameObject enemy)
	{
		string goalColor = goal.GetComponent<ColorState>().colorState;
		string enemyColor = enemy.GetComponent<ColorState>().colorState;

		if (goalColor == enemyColor)
			gameController.CollectEnemy(enemy);
		else
			gameController.CollectMismatchedEnemy(enemy);
	}

}
