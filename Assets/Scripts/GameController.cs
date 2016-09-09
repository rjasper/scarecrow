using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

	public static GameController instance
	{
		get { return GameObject.FindObjectOfType<GameController>();  }
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

}
