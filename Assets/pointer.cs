using UnityEngine;
using System.Collections;

public class pointer : MonoBehaviour {

	/*
	 * TODO:
	 * http://answers.unity3d.com/questions/64509/get-a-gui-2d-arrow-to-turn-to-a-specific-position.html
	 * Working with rotations can be really tricky especially when you have to work with 2d to 3d coordinates. If someone want to implement this here's a quick version:
	*/
	/*
	var cam : Camera; //Camera to use
	var target : Transform; //Target to point at (you could set this to any gameObject dynamically)
	private var targetPos : Vector3; //Target position on screen
	private var screenMiddle : Vector3; //Middle of the screen


	function Update() {
	    //Get the targets position on screen into a Vector3
	    targetPos = cam.WorldToScreenPoint (target.transform.position);
	    //Get the middle of the screen into a Vector3
	    screenMiddle = Vector3(Screen.width/2, Screen.height/2, 0); 
	    //Compute the angle from screenMiddle to targetPos
	    var tarAngle = (Mathf.Atan2(targetPos.x-screenMiddle.x,Screen.height-targetPos.y-screenMiddle.y) * Mathf.Rad2Deg)+90;
	    if (tarAngle < 0) tarAngle +=360;


	 //Calculate the angle from the camera to the target
	 var targetDir = target.transform.position - cam.transform.position;
	 var forward = cam.transform.forward;
	 var angle = Vector3.Angle(targetDir, forward);
	 //If the angle exceeds 90deg inverse the rotation to point correctly
	 if(angle&lt;90){
	     transform.localRotation = Quaternion.Euler(-tarAngle,90,270);
	 } else {
	     transform.localRotation = Quaternion.Euler(tarAngle,270,90);
	 }

	}
	*/
	/**
 	* The GUI in 3d-space has to be put relative to the camera at all times (child to main camera or a camera only seeing the GUI-element rendered on top of the main camera). Preferably the last mentioned as you mostly wouldn't want the GUI to fall behind objects in 3d-space. Big thanks to The_r0nin and the tarAngle computation.
	*/		


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
