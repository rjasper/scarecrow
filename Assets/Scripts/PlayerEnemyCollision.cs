using UnityEngine;
using System.Collections;

public class PlayerEnemyCollision : MonoBehaviour {

	private EventController eventManager;

	void Awake()
	{
		eventManager = EventController.instance;
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		GameObject other = collision.gameObject;

		if (other.CompareTag("Enemy"))
		{
			eventManager.OnPlayerEnemyCollision();
		}
	}

}
