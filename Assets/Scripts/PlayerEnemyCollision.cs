using UnityEngine;
using System.Collections;

public class PlayerEnemyCollision : MonoBehaviour {

	private EventManager eventManager;

	void Awake()
	{
		eventManager = EventManager.instance;
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
