using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using UnityEngine.UI;

public class ChangeLangMakeAvatar : MonoBehaviour {

	// some attribute to read file index of lang
	public TextAsset LangTextFile;
	private string StringReadLang;
	private List<string> LineofLang;
	private string[] StringReadIndex;
	private int _selection;

	// input text from Canvas screen to change language
	public Text _makeyourname;
	public Text _takephoto;
	public Text _back;
	public Text _yournickname;
	public Text _typenickname;
	public Text _ok;

	// Use this for initialization
	void Start () {
	
		//  Read all text in lang.txt, after that add element into list string LineofLang
		StringReadLang = LangTextFile.text;
		LineofLang = new List<string>();
		LineofLang.AddRange(StringReadLang.Split("\n"[0]) );

		// Read index in indexofsound.txt, after that add index into list string LineofIndex
		string pathoflang = Path.Combine(Application.persistentDataPath+"/", "data3.bin");
		StringReadIndex = File.ReadAllLines (pathoflang);
		_selection = Int32.Parse (StringReadIndex[0]); 
	}
	
	// Update is called once per frame
	void Update () {
	
		switch(_selection){

		case 0:

			_makeyourname.text = LineofLang [0];
			_takephoto.text = LineofLang [1];
			_back.text = LineofLang [2];
			_yournickname.text = LineofLang[3];
			_typenickname.text = LineofLang [4];
			_ok.text = LineofLang [5];
			break;

		case 1:
			_makeyourname.text = LineofLang [6];
			_takephoto.text = LineofLang [7];
			_back.text = LineofLang [8];
			_yournickname.text = LineofLang[9];
			_typenickname.text = LineofLang [10];
			_ok.text = LineofLang [11];
			break;

		case 2:
			_makeyourname.text = LineofLang [12];
			_takephoto.text = LineofLang [13];
			_back.text = LineofLang [14];
			_yournickname.text = LineofLang[15];
			_typenickname.text = LineofLang [16];
			_ok.text = LineofLang [17];
			break;

		case 3:
			_makeyourname.text = LineofLang [18];
			_takephoto.text = LineofLang [19];
			_back.text = LineofLang [20];
			_yournickname.text = LineofLang[21];
			_typenickname.text = LineofLang [22];
			_ok.text = LineofLang [23];
			break;
		}
	}
}
