using UnityEngine;
using System.Collections;

public class MovementPlayer : MonoBehaviour {

	
	void Start () {
	
	}
	//using arrow buttons or WASD for player character movements
	void Update () {
        Transform t = GetComponent<Transform>();

        if ((Input.GetKeyDown("right")) || (Input.GetKeyDown(KeyCode.D)))
        {
            t.Translate (new Vector2(1, 0));
        }

        if ((Input.GetKeyDown("left")) || (Input.GetKeyDown(KeyCode.A)))
                {
            t.Translate (new Vector2(-1, 0));
        }

        if ((Input.GetKeyDown("up")) || (Input.GetKeyDown(KeyCode.W)))
        {
            t.Translate(new Vector2(0, 1));
        }

        if ((Input.GetKeyDown("down")) || (Input.GetKeyDown(KeyCode.S)))
        {
            t.Translate(new Vector2(0, -1));
        }
    }
}
