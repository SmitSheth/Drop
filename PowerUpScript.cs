using UnityEngine;
using System.Collections;

public class PowerUpScript : MonoBehaviour {

	public Vector3 velocity = new Vector3(0,4,0);
	private PlayerController playerController;

	void Start()
	{
		
		GetComponent<Rigidbody> ().transform.Translate (velocity * Time.deltaTime);

		GameObject playerControllerObject = GameObject.FindWithTag ("Player");	
		if (playerControllerObject != null) {
			playerController = playerControllerObject.GetComponent<PlayerController> ();
		} 
		if (playerController == null) {
			Debug.Log ("Cannot find 'PlayerController' Script");
		}

	}

	void FixedUpdate () {
		GetComponent<Rigidbody>().transform.Translate(velocity*Time.deltaTime);
	}

	void OnTriggerEnter(Collider other)
	{
		
		if (other.name == "Player") {
			if (this.tag == "Fast_PowerUp") {
				playerController.speedUp ();
			} else if (this.tag == "Slow_PowerUp") {
				playerController.speedDown ();
			}
		}
		Destroy (this.gameObject);
	}

}
