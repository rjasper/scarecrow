using UnityEngine;
using System.Collections;

public class GoalEnemyTrigger : MonoBehaviour {

	private ColorState colorState;

	void Start () {
		colorState = GetComponent<ColorState>();
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.CompareTag("Enemy") && !collider.isTrigger)
		{
			Debug.Log("enemy triggered goal");
		}
	}

}
