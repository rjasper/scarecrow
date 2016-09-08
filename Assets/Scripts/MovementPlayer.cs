using UnityEngine;
using System.Collections;

public class MovementPlayer : MonoBehaviour {

	public float inputSpeedFactor = 1f;

	private new Rigidbody2D rigidbody;

	void Start () {
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
