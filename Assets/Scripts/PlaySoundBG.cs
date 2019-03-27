using UnityEngine;
using System;
using System.Collections;
using System.IO;
using System.Linq;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class PlaySoundBG : MonoBehaviour {

	public TextAsset LangTextFile;
	private string[] StringReadIndex;
	private string StringReadLang;
	private List<string> LineofLang;
	private string pathoflang;
	private string[] StringLangIndex;
	public Dropdown _dropdownLanguage;
	public Slider _sliderMusic;
	private int _languageIndex;
	//===========================
	private string _index;
	public Text _captionText;
	public Text _sound;
	public Text _language;
	public Text _back;
	public Text _introduction;
	//===========================
	//public TextAsset SoundIndex;
	private string[] StringSoundIndex;
	public Text mute_text;
	private string pathofsound;
	private float soundVolume;
	public AudioSource _audioBG;
	//===========================
	public int _numberofScene;
	public GameObject _SettingPanel;


	//===============================
	//List<string> option = new List<string> (){"English", "日本語", "中文《简体》", "한국어"};

	// Use this for initialization
	void Awake () {

		//=== play music from starting and read value of indexoflang.txt
		_audioBG.Play();
		pathofsound = Path.Combine(Application.persistentDataPath+"/", "data2.bin"); // file soundsetting.bin has changed to data2.bin
		if (File.Exists (pathofsound)) {

			StringSoundIndex = File.ReadAllLines (pathofsound);
			soundVolume = float.Parse (StringSoundIndex [0]); 
			AudioListener.volume = soundVolume;
			_sliderMusic.value = soundVolume;

		} else {

			_sliderMusic.value = 1;
		}

		//=== read text from lang.txt
		pathoflang = Path.Combine(Application.persistentDataPath+"/", "data3.bin"); // file indexoflang.bin has changed to data3.bin
		if (File.Exists (pathoflang)) {

			StringReadLang = LangTextFile.text;
			LineofLang = new List<string> ();
			LineofLang.AddRange (StringReadLang.Split ("\n" [0]));
			StringReadIndex = File.ReadAllLines (pathoflang);
			_languageIndex = Int32.Parse (StringReadIndex [0]); 
			_dropdownLanguage.value = _languageIndex;

		} else {

			_dropdownLanguage.value = 0;
		}

	}
	//=====================================

	//====================================
	public void SelectLanguage(int index){
		
		switch(index){

		case 0: 
			_languageIndex = 0;
			_sound.text = LineofLang [5];
			_language.text = LineofLang [6];
			_back.text = LineofLang [7];
			_introduction.text = LineofLang [8];
			break;

		case 1: 
			_languageIndex = 1;
			_sound.text = LineofLang [14];
			_language.text = LineofLang [15];
			_back.text = LineofLang [16];
			_introduction.text = LineofLang [17];
			break;

		case 2: 
			
			_languageIndex = 2;
			_sound.text = LineofLang [23];
			_language.text = LineofLang [24];
			_back.text = LineofLang [25];
			_introduction.text = LineofLang [26];
			break;

		case 3: 

			_languageIndex = 3;
			_sound.text = LineofLang [32];
			_language.text = LineofLang [33];
			_back.text = LineofLang [34];
			_introduction.text = LineofLang [35];
			break;

		case 4: 

			_languageIndex = 4;
			_sound.text = LineofLang [41];
			_language.text = LineofLang [42];
			_back.text = LineofLang [43];
			_introduction.text = LineofLang [44];
			break;

		case 5: 

			_languageIndex = 5;
			_sound.text = LineofLang [50];
			_language.text = LineofLang [51];
			_back.text = LineofLang [52];
			_introduction.text = LineofLang [53];
			break;

		case 6: 

			_languageIndex = 6;
			_sound.text = LineofLang [59];
			_language.text = LineofLang [60];
			_back.text = LineofLang [61];
			_introduction.text = LineofLang [62];
			break;

		case 7: 

			_languageIndex = 7;
			_sound.text = LineofLang [68];
			_language.text = LineofLang [69];
			_back.text = LineofLang [70];
			_introduction.text = LineofLang [71];
			break;

		/*case 8: 

			_languageIndex = 8;
			_sound.text = LineofLang [77];
			_language.text = LineofLang [78];
			_back.text = LineofLang [79];
			_introduction.text = LineofLang [80];
			break;*/
		}

	}
		
	//===================================
	public void ComfirmOK(){



			string _index = _languageIndex.ToString();
			string[] Lang_lines = { _index};
			File.WriteAllLines (pathoflang,Lang_lines);
			//=================================
			string _indexofsound = soundVolume.ToString ();
			string[] lines = { _indexofsound};
			File.WriteAllLines (pathofsound,lines);
			SceneManager.LoadScene (_numberofScene, LoadSceneMode.Single);

	}
	//==================================
	void Update(){

		soundVolume = _sliderMusic.value;
		AudioListener.volume = _sliderMusic.value;
    }
}