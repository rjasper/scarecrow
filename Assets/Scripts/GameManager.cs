using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	private static GameManager instanceHolder = null;

	public static GameManager instance
	{
		get { return instanceHolder; }
	}

	void Awake ()
	{
		InitInstanceOrDestroy();
	}

	private void InitInstanceOrDestroy ()
	{
		if (instanceHolder == null)
			instanceHolder = this;
		else
			Destroy(this);
	}

	void Start () {

	}
	

	void Update () {
	
	}

}
