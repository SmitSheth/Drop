using UnityEngine;
using System.Collections;

public class Sample : MonoBehaviour {
	public float speed;

	void Start()
	{
		speed = 20;
	}
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		//float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (0.0f,-.49f,moveHorizontal);
		GetComponent<Rigidbody>().velocity = movement*speed;
		//Vector3 movement = new Vector3(0.0f,0.0f,moveHorizontal);
		//transform.Translate(movement * Time.deltaTime*speed);

		//GetComponent<Rigidbody> ().position.z = Mathf.Clamp (GetComponent<Rigidbody> ().position.z, -10f, 10f);

		GetComponent<Rigidbody>().position = new Vector3 
			(
				10.0f, 
				Mathf.Clamp (GetComponent<Rigidbody>().position.y, -4.5f, 8f), 
				Mathf.Clamp (GetComponent<Rigidbody>().position.z, -10f, 10f)
			);
	}
	public void speedUp()
	{
		Debug.Log (speed);
		StartCoroutine(StopSpeedUp());
	}
	IEnumerator StopSpeedUp()
	{
		//WaitForSeconds (2.5f);
		speed=50; 
		yield return new WaitForSeconds (2.5f);
		speed = 20;
	}

}
