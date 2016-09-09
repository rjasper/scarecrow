using UnityEngine;
using System.Collections;

public class GoalEnemyTrigger : MonoBehaviour
{

	private EventController eventManager;

	void Start()
	{
		eventManager = EventController.instance;
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.CompareTag("Enemy") && !collider.isTrigger)
		{
			eventManager.OnGoalEnemyTrigger(gameObject, collider.gameObject);
		}
	}

}
