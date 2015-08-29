using UnityEngine;
using System.Collections;

public class earthRotate : MonoBehaviour {


	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround(transform.position, transform.up, -Time.deltaTime * 5f);
		
	}
}
