using UnityEngine;
using System.Collections;

public class PlayerEnemyCollision : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D collision)
	{
		GameObject other = collision.gameObject;

		if (other.CompareTag("Enemy"))
		{
			gameObject.SetActive(false);
		}
	}

}
