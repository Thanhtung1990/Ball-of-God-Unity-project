using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.IO;
using System;
using System.Linq;
using System.Collections.Generic;

public class ShowUsername : MonoBehaviour {

	public Text _username;
	private string[] StringReadIndex;
	private string _decrypt;
	// Use this for initialization
	void Start () {

		string path = Path.Combine(Application.persistentDataPath+"/", "username.bin");
		if (File.Exists (path)) {
			StringReadIndex = File.ReadAllLines (path);
			string username = StringReadIndex [0]; 
			_decrypt = Decrypt.DecryptString (username);
			_username.text = _decrypt;

		} else
			Debug.Log ("File not found.");
	}
	
	// Update is called once per frame
	void Update () {


	}
}
