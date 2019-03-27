using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using UnityEngine.UI;

public class MainButtonChangeLanguage : MonoBehaviour {


	public TextAsset LangTextFile;
	private string StringReadLang;
	private List<string> LineofLang;
	private string[] StringReadIndex;
	//==================================

	public Text _easylevel;
	public Text _hardlevel;
	public Text _setting;
	public Text _makeprofile;
	public Text _exit;
	private int _selection;
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
	//=========================================
	// Update is called once per frame
	void Update () {
		
		switch(_selection){

		case 0:

			_easylevel.text = LineofLang [0];
			_hardlevel.text = LineofLang [1];
			_setting.text = LineofLang [2];
			//_makeprofile.text = LineofLang[3];
			_exit.text = LineofLang [4];
			break;

		case 1:
			_easylevel.text = LineofLang [9];
			_hardlevel.text = LineofLang [10];
			_setting.text = LineofLang [11];
			//_makeprofile.text = LineofLang[12];
			_exit.text = LineofLang [13];
			break;

		case 2:
			_easylevel.text = LineofLang [18];
			_hardlevel.text = LineofLang [19];
			_setting.text = LineofLang [20];
			//_makeprofile.text = LineofLang[21];
			_exit.text = LineofLang [22];
			break;

		case 3:
			_easylevel.text = LineofLang [27];
			_hardlevel.text = LineofLang [28];
			_setting.text = LineofLang [29];
			//_makeprofile.text = LineofLang[30];
			_exit.text = LineofLang [31];
			break;

		case 4:
			_easylevel.text = LineofLang [36];
			_hardlevel.text = LineofLang [37];
			_setting.text = LineofLang [38];
			//_makeprofile.text = LineofLang[39];
			_exit.text = LineofLang [40];
			break;

		case 5:
			_easylevel.text = LineofLang [45];
			_hardlevel.text = LineofLang [46];
			_setting.text = LineofLang [47];
			//_makeprofile.text = LineofLang[48];
			_exit.text = LineofLang [49];
			break;

		case 6:
			_easylevel.text = LineofLang [54];
			_hardlevel.text = LineofLang [55];
			_setting.text = LineofLang [56];
			//_makeprofile.text = LineofLang[57];
			_exit.text = LineofLang [58];
			break;

		case 7:
			_easylevel.text = LineofLang [63];
			_hardlevel.text = LineofLang [64];
			_setting.text = LineofLang [65];
			//_makeprofile.text = LineofLang[65];
			_exit.text = LineofLang [67];
			break;

		/*case 8:
			_easylevel.text = LineofLang [72];
			_hardlevel.text = LineofLang [73];
			_setting.text = LineofLang [74];
			//_makeprofile.text = LineofLang[75];
			_exit.text = LineofLang [76];
			break;*/
		}
	
	}
}
