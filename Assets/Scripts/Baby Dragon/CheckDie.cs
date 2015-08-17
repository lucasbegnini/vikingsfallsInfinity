using UnityEngine;

public class CheckDie : MonoBehaviour
{
	private GameObject _menuPopUP;
	public bool isLive;

	void Start()
	{	
		isLive = true;
		_menuPopUP = GameObject.FindGameObjectWithTag ("MenuPopUp");
		_menuPopUP.SetActive (false);
	}
	// Update is called once per frame
	void Update ()
	{
		// Die by being off screen
		Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
		if (screenPosition.y > Screen.height || screenPosition.y < 0)
		{
			Die();
		}
	}
	
	// Die by collision
	void OnCollisionEnter2D(Collision2D other)
	{
		Die();
	}
	
	void Die()
	{
		isLive = false;
//		Application.LoadLevel (Application.loadedLevel);
		//Application.LoadLevel(Application.loadedLevel);
		_menuPopUP.SetActive (true);
	}
}
