using UnityEngine;
using System.Collections;

public class MovementPlayer : MonoBehaviour {

    public float inputSpeedFactor = 1f;

    public float minimumInput
    {
        get { return Mathf.Sqrt(minimumSqrInput); }
        set { minimumSqrInput = Mathf.Pow(value, 2f); }
    }

    private new Rigidbody2D rigidbody;

    private float minimumSqrInput = Mathf.Pow(.1f, 2f);

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

        if (inputVector.SqrMagnitude() < minimumSqrInput)
            rigidbody.velocity = Vector2.zero;
        else
            rigidbody.velocity = inputSpeedFactor * inputVector.normalized;
    }

}
