using UnityEngine;
using System.Collections;

public class MoveCameraInTouch : MonoBehaviour {

	public float smoothing;

	// Use this for initialization
	void Start () {
	
	}
	// move camera from left when it overdoses moving -1.8
	private void RemoveFromLeft(){

		Vector3 temp1;
		temp1 = transform.position;
		temp1.x += 0.1f;
		transform.position = temp1;
	}
	// move camera from right when it overdoses moving -1.8
	private void RemoveFromRight(){

		Vector3 temp2;
		temp2 = transform.position;
		temp2.x -= 0.1f;
		transform.position = temp2;
	}
	// Update is called once per frame
	void Update () {
	
		if (transform.position.x > -1.5) {	
			if (transform.position.x < 5.5) {					// if camera.position.x is between -1.79 to 1.79
				if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Moved) {		// use vector 2 to get point of finger on screen
					Vector2 touchDeltaPosition = Input.GetTouch (0).deltaPosition;				// move camera in position.x
					transform.Translate (-touchDeltaPosition.x * smoothing * Time.deltaTime, 0, 0);

				} else {
					Debug.Log (transform.position);
				}
			} else {
				//RemoveFromLeft ();
				RemoveFromRight ();
			}
		}
		else {
				RemoveFromLeft ();
			//RemoveFromRight ();
		}
	}
}



