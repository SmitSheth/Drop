using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {

	// Use this for initialization
	public Vector3 velocity = new Vector3(0,4,0);
	public float range = 13;
	// Use this for initialization
	void Start()
	{
		GetComponent<Rigidbody> ().transform.Translate (velocity * Time.deltaTime);
		//transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z-range*Random.value);
	}
	void FixedUpdate () {
		GetComponent<Rigidbody>().transform.Translate(velocity*Time.deltaTime);
	}



}
