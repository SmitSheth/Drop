using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	//public GUIText gameOverText;
	// Use this for initialization
	public float playerScore=0;

	void Start () {
		
		//gameOverText.text = "";
	}
	void Update()
	{
		playerScore += Time.deltaTime;
		PlayerPrefs.SetInt ("Score",(int)playerScore*100);
	}
	public void GameOver()
	{
		SceneManager.LoadScene(1);
		//Debug.Log("Dead");
		//gameOverText.text = "Game Over";
	}

	void OnGUI () 
	{
		GUI.color = Color.white;
		GUILayout.Label(" Score: " + (int)playerScore * 10);
	}
}
