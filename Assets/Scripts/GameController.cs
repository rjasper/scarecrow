using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

	public static GameController instance
	{
		get { return GameObject.FindObjectOfType<GameController>();  }
	}

	public void KillPlayer()
	{
		GameObject player = GameObject.FindGameObjectWithTag("Player");

		player.SetActive(false);
	}

	public void SetGoalColor(ColorState colorState)
	{
		GameObject[] goals = GameObject.FindGameObjectsWithTag("Goal");

		foreach (GameObject goal in goals)
		{
			goal.GetComponent<ColorState>().colorState = colorState.colorState;
			// TODO change goal's displayed color
		}
	}

	public void CollectEnemy(GameObject enemy)
	{
		Debug.Log("collected enemy");
		enemy.SetActive(false);
	}

	public void CollectMismatchedEnemy(GameObject enemy)
	{
		Debug.Log("collected mismatched enemy");
		enemy.SetActive(false);
	}

}
