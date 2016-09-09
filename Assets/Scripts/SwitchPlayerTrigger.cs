using UnityEngine;
using System.Collections;

public class SwitchPlayerTrigger : MonoBehaviour {

	private EventController eventManager;

	void Start()
	{
		eventManager = EventController.instance;
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.CompareTag("Player") && !collider.isTrigger)
		{
			eventManager.OnPlayerSwitchTrigger(gameObject);
		}
	}

}
