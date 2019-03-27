using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;
using System.IO;

public class EasylevelSave : MonoBehaviour {


	private string pathofsaveEasyScene;

	private string[] StringEasySceneIndex;

	private string _encryptedValueEasylevel;
	private	string _encryptNumber;
	private string numberOfEasyScene;

	private int easyscene;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//=======================
	public void LoadEasyScene(int easy_number){

		pathofsaveEasyScene = Path.Combine(Application.persistentDataPath+"/", "data4.bin");
		if (File.Exists (pathofsaveEasyScene)) {

			StringEasySceneIndex = File.ReadAllLines (pathofsaveEasyScene);
			_encryptedValueEasylevel = StringEasySceneIndex [0]; 
			numberOfEasyScene = Decrypt.DecryptString (_encryptedValueEasylevel);
			easyscene = Int32.Parse (numberOfEasyScene);
			SceneManager.LoadScene(easyscene,LoadSceneMode.Single);
		} else {
			SceneManager.LoadScene(easy_number,LoadSceneMode.Single);
		}
	}

	//==========================
	public void EasyLevelSave(int NumberOfScene) {

		pathofsaveEasyScene = Path.Combine(Application.persistentDataPath+"/", "data4.bin");

		string temp = NumberOfScene.ToString ();
		_encryptNumber = Encrypt.EncryptString (temp);
		string[] lines = { _encryptNumber };
		File.WriteAllLines (pathofsaveEasyScene, lines);
		Time.timeScale = 1;		// this code make time in game run normally and it seem like game is running. 
		SceneManager.LoadScene(NumberOfScene,LoadSceneMode.Single);
	}
}
