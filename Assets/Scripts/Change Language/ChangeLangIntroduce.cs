using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using UnityEngine.UI;

public class ChangeLangIntroduce : MonoBehaviour {

	// some attribute to read file index of lang
	public TextAsset LangTextFile;
	private string StringReadLang;
	private List<string> LineofLang;
	private string[] StringReadIndex;
	private int _selection;

	// input text from Canvas screen to change language
	public Text _howtoplay;
	public Text _text1;
	public Text _text2;
	public Text _text3;
	public Text _text4;
	public Text _button;

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

			_howtoplay.text = LineofLang [0];
			_text1.text = LineofLang [1];
			_text2.text = LineofLang [2];
			_text3.text = LineofLang[3];
			//_text4.text = LineofLang [4];
			_button.text = LineofLang [5];
			break;

		case 1:
			_howtoplay.text = LineofLang [6];
			_text1.text = LineofLang [7];
			_text2.text = LineofLang [8];
			_text3.text = LineofLang[9];
			//_text4.text = LineofLang [10];
			_button.text = LineofLang [11];
			break;

		case 2:
			_howtoplay.text = LineofLang [12];
			_text1.text = LineofLang [13];
			_text2.text = LineofLang [14];
			_text3.text = LineofLang[15];
			//_text4.text = LineofLang [16];
			_button.text = LineofLang [17];
			break;

		case 3:
			_howtoplay.text = LineofLang [18];
			_text1.text = LineofLang [19];
			_text2.text = LineofLang [20];
			_text3.text = LineofLang[21];
			//_text4.text = LineofLang [22];
			_button.text = LineofLang [23];
			break;

		case 4:
			_howtoplay.text = LineofLang [24];
			_text1.text = LineofLang [25];
			_text2.text = LineofLang [26];
			_text3.text = LineofLang[27];
			//_text4.text = LineofLang [28];
			_button.text = LineofLang [29];
			break;

		case 5:
			_howtoplay.text = LineofLang [30];
			_text1.text = LineofLang [31];
			_text2.text = LineofLang [32];
			_text3.text = LineofLang[33];
			//_text4.text = LineofLang [24];
			_button.text = LineofLang [35];
			break;

		case 6:
			_howtoplay.text = LineofLang [36];
			_text1.text = LineofLang [37];
			_text2.text = LineofLang [38];
			_text3.text = LineofLang[39];
			//_text4.text = LineofLang [40];
			_button.text = LineofLang [41];
			break;

		case 7:
			_howtoplay.text = LineofLang [42];
			_text1.text = LineofLang [43];
			_text2.text = LineofLang [44];
			_text3.text = LineofLang[45];
			//_text4.text = LineofLang [46];
			_button.text = LineofLang [47];
			break;

		/*case 8:
			_howtoplay.text = LineofLang [48];
			_text1.text = LineofLang [49];
			_text2.text = LineofLang [50];
			_text3.text = LineofLang[51];
			//_text4.text = LineofLang [52];
			_button.text = LineofLang [53];
			break;*/
		}
	}
}
