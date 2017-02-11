using UnityEngine;
using System.Collections;

public class BackgroundScroll : MonoBehaviour {

	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
		MeshRenderer mesh = GetComponent<MeshRenderer> ();

		Material mat = mesh.material;
		Vector2 offset = mat.mainTextureOffset;
		offset.x += Time.deltaTime;
		mat.mainTextureOffset = offset;
	}
}
