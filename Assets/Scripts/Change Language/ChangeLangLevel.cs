using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using UnityEngine.UI;

public class ChangeLangLevel : MonoBehaviour {

	public TextAsset LangTextFile;
	private string StringReadLang;
	private List<string> LineofLang;
	private string[] StringReadIndex;
	private int _selection;
	//==================================

	public Text _level;
	public Text _back;
	public Text _congratulation;
	public Text _share;
	public Text _nextlevel;
	public Text _unfortunately;
	public Text _youtry;
	public Text _playagain;
	public Text _doyouwant;
	public Text _yes;
	public Text _no;

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

			_level.text = LineofLang [0];
			_back.text = LineofLang [1];
			_congratulation.text = LineofLang [2];
			_share.text = LineofLang[3];
			_nextlevel.text = LineofLang [4];
			_unfortunately.text = LineofLang [5];
			_youtry.text = LineofLang [6];
			_playagain.text = LineofLang [7];
			_doyouwant.text = LineofLang [8];
			_yes.text = LineofLang [9];
			_no.text = LineofLang [10];
			break;

		case 1:
			_level.text = LineofLang [11];
			_back.text = LineofLang [12];
			_congratulation.text = LineofLang [13];
			_share.text = LineofLang[14];
			_nextlevel.text = LineofLang [15];
			_unfortunately.text = LineofLang [16];
			_youtry.text = LineofLang [17];
			_playagain.text = LineofLang [18];
			_doyouwant.text = LineofLang [19];
			_yes.text = LineofLang [20];
			_no.text = LineofLang [21];
			break;

		case 2:
			_level.text = LineofLang [22];
			_back.text = LineofLang [23];
			_congratulation.text = LineofLang [24];
			_share.text = LineofLang[25];
			_nextlevel.text = LineofLang [26];
			_unfortunately.text = LineofLang [27];
			_youtry.text = LineofLang [28];
			_playagain.text = LineofLang [29];
			_doyouwant.text = LineofLang [30];
			_yes.text = LineofLang [31];
			_no.text = LineofLang [32];
			break;

		case 3:
			_level.text = LineofLang [33];
			_back.text = LineofLang [34];
			_congratulation.text = LineofLang [35];
			_share.text = LineofLang[36];
			_nextlevel.text = LineofLang [37];
			_unfortunately.text = LineofLang [38];
			_youtry.text = LineofLang [39];
			_playagain.text = LineofLang [40];
			_doyouwant.text = LineofLang [41];
			_yes.text = LineofLang [42];
			_no.text = LineofLang [43];
			break;

		case 4:
			_level.text = LineofLang [44];
			_back.text = LineofLang [45];
			_congratulation.text = LineofLang [46];
			_share.text = LineofLang[47];
			_nextlevel.text = LineofLang [48];
			_unfortunately.text = LineofLang [49];
			_youtry.text = LineofLang [50];
			_playagain.text = LineofLang [51];
			_doyouwant.text = LineofLang [52];
			_yes.text = LineofLang [53];
			_no.text = LineofLang [54];
			break;

		case 5:
			_level.text = LineofLang [55];
			_back.text = LineofLang [56];
			_congratulation.text = LineofLang [57];
			_share.text = LineofLang[58];
			_nextlevel.text = LineofLang [59];
			_unfortunately.text = LineofLang [60];
			_youtry.text = LineofLang [61];
			_playagain.text = LineofLang [62];
			_doyouwant.text = LineofLang [63];
			_yes.text = LineofLang [64];
			_no.text = LineofLang [65];
			break;

		case 6:
			_level.text = LineofLang [66];
			_back.text = LineofLang [67];
			_congratulation.text = LineofLang [68];
			_share.text = LineofLang[69];
			_nextlevel.text = LineofLang [70];
			_unfortunately.text = LineofLang [71];
			_youtry.text = LineofLang [72];
			_playagain.text = LineofLang [73];
			_doyouwant.text = LineofLang [74];
			_yes.text = LineofLang [75];
			_no.text = LineofLang [76];
			break;

		case 7:
			_level.text = LineofLang [77];
			_back.text = LineofLang [78];
			_congratulation.text = LineofLang [79];
			_share.text = LineofLang[80];
			_nextlevel.text = LineofLang [81];
			_unfortunately.text = LineofLang [82];
			_youtry.text = LineofLang [83];
			_playagain.text = LineofLang [84];
			_doyouwant.text = LineofLang [85];
			_yes.text = LineofLang [86];
			_no.text = LineofLang [87];
			break;

		/*case 8:
			_level.text = LineofLang [88];
			_back.text = LineofLang [89];
			_congratulation.text = LineofLang [90];
			_share.text = LineofLang[91];
			_nextlevel.text = LineofLang [92];
			_unfortunately.text = LineofLang [93];
			_youtry.text = LineofLang [94];
			_playagain.text = LineofLang [95];
			_doyouwant.text = LineofLang [96];
			_yes.text = LineofLang [97];
			_no.text = LineofLang [98];
			break;*/
		}
	}
}
