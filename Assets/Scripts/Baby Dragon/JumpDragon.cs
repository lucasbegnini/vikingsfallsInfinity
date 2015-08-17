using UnityEngine;
using System.Collections;

public class JumpDragon : MonoBehaviour {

	[SerializeField] private Vector2 jumpForce = new Vector2(0, 300);
	private GameObject _player;
	
	void Start()
	{
		_player = GameObject.FindGameObjectWithTag ("Player");
	}
	void Update () {
	
		// Jump
		if (Input.GetKeyUp("space") )
		{
			GetComponent<Rigidbody2D>().velocity = Vector2.zero;
			GetComponent<Rigidbody2D>().AddForce(jumpForce);
		}
	}
}
