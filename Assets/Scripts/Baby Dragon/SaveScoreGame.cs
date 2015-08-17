using UnityEngine;
using System.Collections;

public class SaveScoreGame : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D other)
	{
		GameObject.FindGameObjectWithTag ("Score").GetComponent<Score> ().SaveScore ();
	}
}
