﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.IO;
using System;

public class ChangeNickName : MonoBehaviour {

	public InputField _inputText;
	public GameObject _panel;
	private string _username;
	private string _encryptText;
	// Use this for initialization
	void Start () {


	}

	// Get text from inputfield after that write it to file
	public void WriteNameToFile(){

		string path = Path.Combine(Application.persistentDataPath+"/", "username.bin");
		if (!File.Exists (path)) {

			_encryptText = _inputText.text;

			_username = Encrypt.EncryptString (_encryptText);
			string[] lines = { _username };

			File.WriteAllLines (path, lines);

			_panel.SetActive (false);
			SceneManager.LoadScene (3, LoadSceneMode.Single);
		} else {

			_encryptText = _inputText.text;

			_username = Encrypt.EncryptString (_encryptText);
			string[] lines = { _username };

			File.WriteAllLines (path, lines);

			_panel.SetActive (false);
			SceneManager.LoadScene (3, LoadSceneMode.Single);
		}

	}

	// Update is called once per frame
	void Update () {


	}
}
