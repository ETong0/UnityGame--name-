
using UnityEngine;

public class PlayerMovement : MonoBehaviour
	{

	[SerializeField]private float speed;
	private Rigidbody2D body;

	private void Awake()
	{
		body = GetComponent<Rigidbody2D>();
	}

    private void Update()
    {
		//move left and right
		float horizontalInupt = Input.GetAxis("Horizontal");
		body.velocity = new Vector2(horizontalInupt * speed, body.velocity.y);

		//flip sprite when facing left and right
		if (horizontalInupt > 0.01f)
			transform.localScale = Vector3.one;
		else if (horizontalInupt > -0.01f)
			transform.localScale = new Vector3(-1,1,1);

		//jump
		if (Input.GetKey(KeyCode.Space))
			body.velocity = new Vector2(body.velocity.x, speed);
    }

}
