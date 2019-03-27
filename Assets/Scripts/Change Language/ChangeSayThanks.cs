using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using UnityEngine.UI;

public class ChangeSayThanks : MonoBehaviour {

	public TextAsset LangTextFile;
	private string StringReadLang;
	private List<string> LineofLang;
	private string[] StringReadIndex;
	private int _selection;

	public Text _thanks;
	public Text _reset;
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
			_thanks.text = LineofLang [0];
			_reset.text = LineofLang [8];
			break;

		case 1:
			_thanks.text = LineofLang [1];
			_reset.text = LineofLang [9];
			break;

		case 2:
			_thanks.text = LineofLang [2];
			_reset.text = LineofLang [10];
			break;

		case 3:
			_thanks.text = LineofLang [3];
			_reset.text = LineofLang [11];
			break;

		case 4:
			_thanks.text = LineofLang [4];
			_reset.text = LineofLang [12];
			break;

		case 5:
			_thanks.text = LineofLang [5];
			_reset.text = LineofLang [13];
			break;

		case 6:
			_thanks.text = LineofLang [6];
			_reset.text = LineofLang [14];
			break;

		case 7:
			_thanks.text = LineofLang [7];
			_reset.text = LineofLang [15];
			break;

		/*case 8:
			_thanks.text = LineofLang [8];
			_reset.text = LineofLang [14];
			break;*/
		}
	}
}
