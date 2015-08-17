using UnityEngine;

public class Generate : MonoBehaviour
{
	public GameObject obstacle;
	private Score _score;
	// Use this for initialization
	void Start()
	{
		InvokeRepeating("CreateObstacle", 1f, 2.5f);
		_score = GameObject.FindGameObjectWithTag ("Score").GetComponent<Score> ();
	}
	
	void CreateObstacle()
	{
		Instantiate(obstacle);
		_score.UpScore ();
	}
}