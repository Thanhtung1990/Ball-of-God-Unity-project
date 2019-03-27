using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using UnityEngine.UI;

public class SaveSoundSetting : MonoBehaviour {

	private float _selection;
	public AudioSource _audioBG;
	private string[] StringSoundIndex;
	// Use this for initialization
	void Start () {
		_audioBG.Play ();
		string pathofsound = Path.Combine(Application.persistentDataPath+"/", "data2.bin");
		StringSoundIndex = File.ReadAllLines (pathofsound);
		_selection = float.Parse(StringSoundIndex[0]); 

		AudioListener.volume = _selection;
	}
	
	// Update is called once per frame
	void Update () {
	

	}

}
