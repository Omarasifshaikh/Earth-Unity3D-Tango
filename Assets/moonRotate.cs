using UnityEngine;
using System.Collections;

public class moonRotate : MonoBehaviour {

	public Vector3 origin = new Vector3(0.0f,0.0f,1.18f);

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround(transform.parent.position, transform.up, -Time.deltaTime * 10f);

	}
}
