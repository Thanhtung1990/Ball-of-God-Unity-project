using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using UnityEngine.UI;

public class ChangeLangLevelInHard : MonoBehaviour {

	public TextAsset LangTextFile;
	private string StringReadLang;
	private List<string> LineofLang;
	private string[] StringReadIndex;
	private int _selection;
	//==================================

	public Text _stage;
	public Text _level;
	public Text _levelofzero;
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

			_stage.text = LineofLang [0];
			_level.text = LineofLang [1];
			_levelofzero.text = LineofLang [1];
			_back.text = LineofLang [2];
			_congratulation.text = LineofLang [3];
			_share.text = LineofLang[4];
			_nextlevel.text = LineofLang [5];
			_unfortunately.text = LineofLang [6];
			_youtry.text = LineofLang [7];
			_playagain.text = LineofLang [8];
			_doyouwant.text = LineofLang [9];
			_yes.text = LineofLang [10];
			_no.text = LineofLang [11];
			break;

		case 1:
			_stage.text = LineofLang [12];
			_level.text = LineofLang [13];
			_levelofzero.text = LineofLang [13];
			_back.text = LineofLang [14];
			_congratulation.text = LineofLang [15];
			_share.text = LineofLang[16];
			_nextlevel.text = LineofLang [17];
			_unfortunately.text = LineofLang [18];
			_youtry.text = LineofLang [19];
			_playagain.text = LineofLang [20];
			_doyouwant.text = LineofLang [21];
			_yes.text = LineofLang [22];
			_no.text = LineofLang [23];
			break;

		case 2:
			_stage.text = LineofLang [24];
			_level.text = LineofLang [25];
			_levelofzero.text = LineofLang [25];
			_back.text = LineofLang [26];
			_congratulation.text = LineofLang [27];
			_share.text = LineofLang[28];
			_nextlevel.text = LineofLang [29];
			_unfortunately.text = LineofLang [30];
			_youtry.text = LineofLang [31];
			_playagain.text = LineofLang [32];
			_doyouwant.text = LineofLang [33];
			_yes.text = LineofLang [34];
			_no.text = LineofLang [35];
			break;

		case 3:
			_stage.text = LineofLang [36];
			_level.text = LineofLang [37];
			_levelofzero.text = LineofLang [37];
			_back.text = LineofLang [38];
			_congratulation.text = LineofLang [39];
			_share.text = LineofLang[40];
			_nextlevel.text = LineofLang [41];
			_unfortunately.text = LineofLang [42];
			_youtry.text = LineofLang [43];
			_playagain.text = LineofLang [44];
			_doyouwant.text = LineofLang [45];
			_yes.text = LineofLang [46];
			_no.text = LineofLang [47];
			break;

		case 4:
			_stage.text = LineofLang [48];
			_level.text = LineofLang [49];
			_levelofzero.text = LineofLang [49];
			_back.text = LineofLang [50];
			_congratulation.text = LineofLang [51];
			_share.text = LineofLang[52];
			_nextlevel.text = LineofLang [53];
			_unfortunately.text = LineofLang [54];
			_youtry.text = LineofLang [55];
			_playagain.text = LineofLang [56];
			_doyouwant.text = LineofLang [57];
			_yes.text = LineofLang [58];
			_no.text = LineofLang [59];
			break;

		case 5:
			_stage.text = LineofLang [60];
			_level.text = LineofLang [61];
			_levelofzero.text = LineofLang [61];
			_back.text = LineofLang [62];
			_congratulation.text = LineofLang [63];
			_share.text = LineofLang[64];
			_nextlevel.text = LineofLang [65];
			_unfortunately.text = LineofLang [66];
			_youtry.text = LineofLang [67];
			_playagain.text = LineofLang [68];
			_doyouwant.text = LineofLang [69];
			_yes.text = LineofLang [70];
			_no.text = LineofLang [71];
			break;

		case 6:
			_stage.text = LineofLang [72];
			_level.text = LineofLang [73];
			_levelofzero.text = LineofLang [73];
			_back.text = LineofLang [74];
			_congratulation.text = LineofLang [75];
			_share.text = LineofLang[76];
			_nextlevel.text = LineofLang [77];
			_unfortunately.text = LineofLang [78];
			_youtry.text = LineofLang [79];
			_playagain.text = LineofLang [80];
			_doyouwant.text = LineofLang [81];
			_yes.text = LineofLang [82];
			_no.text = LineofLang [83];
			break;

		case 7:
			_stage.text = LineofLang [84];
			_level.text = LineofLang [85];
			_levelofzero.text = LineofLang [85];
			_back.text = LineofLang [86];
			_congratulation.text = LineofLang [87];
			_share.text = LineofLang[88];
			_nextlevel.text = LineofLang [89];
			_unfortunately.text = LineofLang [90];
			_youtry.text = LineofLang [91];
			_playagain.text = LineofLang [92];
			_doyouwant.text = LineofLang [93];
			_yes.text = LineofLang [94];
			_no.text = LineofLang [95];
			break;

		/*case 8:
			_stage.text = LineofLang [96];
			_level.text = LineofLang [97];
			_levelofzero.text = LineofLang [97];
			_back.text = LineofLang [98];
			_congratulation.text = LineofLang [99];
			_share.text = LineofLang[100];
			_nextlevel.text = LineofLang [101];
			_unfortunately.text = LineofLang [102];
			_youtry.text = LineofLang [103];
			_playagain.text = LineofLang [104];
			_doyouwant.text = LineofLang [105];
			_yes.text = LineofLang [106];
			_no.text = LineofLang [107];
			break;*/
		}
	}
}
