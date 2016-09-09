using UnityEngine;
using System.Collections;

public class SwitchPlayerTrigger : MonoBehaviour {

	private EventManager eventManager;

	void Awake()
	{
		eventManager = EventManager.instance;
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.CompareTag("Player") && !collider.isTrigger)
		{
			eventManager.OnPlayerSwitchCollision(gameObject);
		}
	}

}
