using UnityEngine;
using System.Collections;

public class Destroy_Thunderball : MonoBehaviour {

	public GameObject _Thunderball;
	// Use this for initialization
	void Start () {
	
	}
	//=====================
	void OnCollisionEnter2D(Collision2D coll) {

		if (coll.transform.tag == "Destroy") {

			Destroy(_Thunderball);
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
