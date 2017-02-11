using UnityEngine;
using System.Collections;

public class Generate : MonoBehaviour {

	public Vector3 spawnValues;
	public GameObject bar;
	public GameObject[] powerUps;

	//int score = 0;
	// Use this for initialization
	void Start () {
		InvokeRepeating("CreateObstacle", 0f, 1.2f);
		InvokeRepeating("CreatePowerUps", 0f, 1.2f);
	}
	/*void OnGUI () 
	{
		GUI.color = Color.white;
		GUILayout.Label(" Score: " + score.ToString());
	}*/
	void CreateObstacle()
	{
		//Vector3 spawnPosition = new Vector3 (spawnValues.x, spawnValues.y, Random.Range (-spawnValues.z, spawnValues.z));
		Vector3 spawnPosition = new Vector3 (spawnValues.x, spawnValues.y, Random.Range (-21,-4 ));
		Quaternion spawnRotation = Quaternion.identity;
		Instantiate (bar, spawnPosition, spawnRotation);
		//Instantiate(bar);
		//score++;
		//PlayerPrefs.SetInt ("Score",score);
	}

	void CreatePowerUps()
	{
		if (Random.value > .8f) {
			Vector3 spawnPosition = new Vector3 (10, spawnValues.y+1.5f, Random.Range (-spawnValues.z, spawnValues.z));
			Quaternion spawnRotation = Quaternion.identity;
			Instantiate (powerUps[Random.Range(0,powerUps.GetLength(0))], spawnPosition, spawnRotation);
		}
	}


}
