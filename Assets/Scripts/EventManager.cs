using UnityEngine;
using System.Collections;

public class EventManager : MonoBehaviour {

	GameObject player;

	public static EventManager instance
	{
		get { return GameObject.FindGameObjectWithTag("EventManager").GetComponent<EventManager>(); }
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
		Debug.Log("player triggered switch");
	}

}
