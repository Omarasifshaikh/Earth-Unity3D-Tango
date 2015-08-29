using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class touch : MonoBehaviour {


	Text status;
	bool togg = true;


	// Use this for initialization
	void Start () {
		Debug.Log ("touch script has started");
		status = GetComponent<Text>();
		status.text = "TANGO STATUS";
	}
	
	// Update is called once per frame
	void Update () {
		int fingerCount = 0;
		foreach (Touch touch in Input.touches) {
			if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)
				fingerCount++;
			
		}
		if (fingerCount > 2) {

			togg = !togg;
		}
		else if (fingerCount > 0){
			status.text = "User has " + fingerCount + " finger(s) touching the screen";

		}
		if (togg) {
			gameObject.GetComponentInParent<CanvasGroup>().alpha = 1f;
		} else {
			gameObject.GetComponentInParent<CanvasGroup>().alpha = 0f;
		}
}
}