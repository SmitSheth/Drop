using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed;
	public Material[] materialsCopy;

	void Start()
	{
		Renderer rend = GetComponent<Renderer> (); 
		rend.material = materialsCopy[0];
		speed = 15;
	}
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		//float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (0.0f,-.49f,moveHorizontal);
		GetComponent<Rigidbody>().velocity = movement*speed;
	
		//GetComponent<Rigidbody>().AddForce = movement*speed;
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
		//Debug.Log (speed);
		StartCoroutine(StopSpeedUp());
	}
	IEnumerator StopSpeedUp()
	{
		//WaitForSeconds (2.5f);
		speed=30; 
		transform.GetChild (0).gameObject.SetActive (true);    //for trail flare
		yield return new WaitForSeconds (2.5f);
		transform.GetChild (0).gameObject.SetActive (false);
		speed = 15;
	}
	public void speedDown()
	{
		//Debug.Log (speed);
		StartCoroutine(StopSpeedDown());
	}
	IEnumerator StopSpeedDown()
	{
		//WaitForSeconds (2.5f);
		speed=8; 
		yield return new WaitForSeconds (2.5f);
		speed = 15;
	}

}
