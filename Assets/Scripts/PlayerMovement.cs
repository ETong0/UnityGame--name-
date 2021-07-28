
using UnityEngine;

public class PlayerMovement : MonoBehaviour
	{

	[SerializeField]private float speed;
	[SerializeField] private LayerMask groundLayer;
	[SerializeField] private LayerMask wallLayer;
	private Rigidbody2D body;
	private Animator anim;
	private BoxCollider2D boxCollider;


	private void Awake()
	{
		body = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
		boxCollider = GetComponent<BoxCollider2D>();
	}

	private void Update()
	{
		//move left and right

		float horizontalInupt = Input.GetAxis("Horizontal");

		if (!isWall())
			body.velocity = new Vector2(horizontalInupt * speed, body.velocity.y);

		//flip sprite when facing left and right
		if (horizontalInupt > 0.01f)
			transform.localScale = Vector3.one;
		
		else if (horizontalInupt < -0.01f)
			transform.localScale = new Vector3(-1, 1, 1);

		//jump
		if (Input.GetKey(KeyCode.UpArrow) && isGrounded())
		{
			Jump();
		}
		//Set animator peramitor
		anim.SetBool("run", horizontalInupt != 0);
		anim.SetBool("grounded", isGrounded());
	}

	//Jump function
	private void Jump()
    {
		body.velocity = new Vector2(body.velocity.x, speed*2);
		anim.SetTrigger("jump");
    }

    //check for collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
		
    }


	private bool isGrounded()
    {
		RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center,boxCollider.bounds.size,0, Vector2.down, 0.1f, groundLayer);
		return raycastHit.collider!=null;
    }

	private bool isWall()
	{
		RaycastHit2D HitLeft = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, Vector2.left, 0.1f, wallLayer);
		RaycastHit2D HitRight = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, Vector2.right, 0.1f, wallLayer);
		return HitLeft.collider != null || HitRight.collider != null;
	}

	public bool canAttack()
    {
		return true;
    }
}
