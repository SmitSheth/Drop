using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	//public GUIText gameOverText;
	// Use this for initialization
	public float playerScore=0;
	public float gameTime=0;
	public int temp=10;
	public GUIText guiText;


	void Start () {
		//gameOverText.text = "";
	}
	void Update()
	{
		Debug.Log (gameTime/temp);
		gameTime += Time.deltaTime;             //levelupscript
		if (gameTime/temp ==1)
			LevelUp ();
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

	void LevelUp() {
		StartCoroutine(ShowMessage("LEVEL UP", 2));
	}
	IEnumerator ShowMessage (string message, float delay) {
		guiText.text = message;
		guiText.enabled = true;
		yield return new WaitForSeconds(delay);
		guiText.enabled = false;
	}
}
