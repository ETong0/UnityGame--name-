
using UnityEngine;

public class PlayerMovement : MonoBehaviour
	{

	[SerializeField]private float speed;
	private Rigidbody2D body;
	private Animator anim;
	private bool grounded;

	private void Awake()
	{
		body = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
	}

    private void Update()
    {
		//move left and right
		float horizontalInupt = Input.GetAxis("Horizontal");
		body.velocity = new Vector2(horizontalInupt * speed, body.velocity.y);

		//flip sprite when facing left and right
		if (horizontalInupt > 0.01f)
			transform.localScale = Vector3.one;
		else if (horizontalInupt < -0.01f)
			transform.localScale = new Vector3(-1,1,1);

		//jump
		if (Input.GetKey(KeyCode.Space) && grounded)
			Jump();

		//Set animator peramitor
		anim.SetBool("run", horizontalInupt != 0);
		anim.SetBool("grounded", grounded);
    }

	//Jump function
	private void Jump()
    {
		body.velocity = new Vector2(body.velocity.x, speed);
		anim.SetTrigger("jump");
		grounded = false;
    }

    //check for collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
		if (collision.gameObject.tag == "Ground")
			grounded = true;
    }

}
