using UnityEngine;
using System.Collections;

public class Moving_Circle_Reverse : MonoBehaviour {

	public float TimeCounter;
	public float speed;
	public float width;
	public float height;

	public float axis_x;
	public float axis_y;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		TimeCounter += Time.deltaTime * speed;

		float x = axis_x - (Mathf.Cos (TimeCounter) * width);
		float y = axis_y - (Mathf.Sin (TimeCounter) * height);
		float z = 0;

		transform.position = new Vector3 (x,y,z);
		transform.Rotate (0,0,speed);
	}
}
