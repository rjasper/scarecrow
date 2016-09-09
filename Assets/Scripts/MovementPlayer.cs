using UnityEngine;
using System.Collections;

public class MovementPlayer : MonoBehaviour {

	GameObject gameManager;
	float inputSpeedFactor = gameManager.GetComponent<GameManager>().GetComponent<playerInputSpeedFactor>();

	private new Rigidbody2D rigidbody;

	void Start () {

		gameManager = GameObject.Find("GameManager");
		
		rigidbody = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate()
	{
		UpdateMovement();
	}

	private void UpdateMovement()
	{
		float horizontalInput = Input.GetAxis("Horizontal");
		float verticalInput = Input.GetAxis("Vertical");

		Vector2 inputVector = new Vector2(horizontalInput, verticalInput);
		
		if (inputVector.sqrMagnitude > 1)
			inputVector.Normalize();

		rigidbody.velocity = inputSpeedFactor * inputVector;
	}

}
