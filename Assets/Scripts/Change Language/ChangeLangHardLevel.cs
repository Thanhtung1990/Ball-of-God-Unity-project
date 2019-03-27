using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using UnityEngine.UI;

public class ChangeLangHardLevel : MonoBehaviour {

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
	public Text _stage0;
	public Text _stage1;
	public Text _stage2;
	public Text _stage3;
	public Text _stage4;
	public Text _stage5;

	public Text _level0;
	public Text _level1;
	public Text _level2;
	public Text _level3;
	public Text _level4;
	public Text _level5;
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

		switch (_selection) {

		case 0:

			_howtoplay.text = LineofLang [0];
			_text1.text = LineofLang [1];
			_text2.text = LineofLang [2];
			_text3.text = LineofLang [3];
			_stage0.text = LineofLang [4];
			_stage1.text = LineofLang [4];
			_stage2.text = LineofLang [4];
			_stage3.text = LineofLang [4];
			_stage4.text = LineofLang [4];
			_stage5.text = LineofLang [4];

			_level0.text = LineofLang [5];
			_level1.text = LineofLang [5];
			_level2.text = LineofLang [5];
			_level3.text = LineofLang [5];
			_level4.text = LineofLang [5];
			_level5.text = LineofLang [5];
			_button.text = LineofLang [6];
			break;

		case 1:
			_howtoplay.text = LineofLang [7];
			_text1.text = LineofLang [8];
			_text2.text = LineofLang [9];
			_text3.text = LineofLang [10];
			_stage0.text = LineofLang [11];
			_stage1.text = LineofLang [11];
			_stage2.text = LineofLang [11];
			_stage3.text = LineofLang [11];
			_stage4.text = LineofLang [11];
			_stage5.text = LineofLang [11];

			_level0.text = LineofLang [12];
			_level1.text = LineofLang [12];
			_level2.text = LineofLang [12];
			_level3.text = LineofLang [12];
			_level4.text = LineofLang [12];
			_level5.text = LineofLang [12];
			_button.text = LineofLang [13];
			break;

		case 2:
			_howtoplay.text = LineofLang [14];
			_text1.text = LineofLang [15];
			_text2.text = LineofLang [16];
			_text3.text = LineofLang [17];
			_stage0.text = LineofLang [18];
			_stage1.text = LineofLang [18];
			_stage2.text = LineofLang [18];
			_stage3.text = LineofLang [18];
			_stage4.text = LineofLang [18];
			_stage5.text = LineofLang [18];

			_level0.text = LineofLang [19];
			_level1.text = LineofLang [19];
			_level2.text = LineofLang [19];
			_level3.text = LineofLang [19];
			_level4.text = LineofLang [19];
			_level5.text = LineofLang [19];
			_button.text = LineofLang [20];
			break;

		case 3:
			_howtoplay.text = LineofLang [21];
			_text1.text = LineofLang [22];
			_text2.text = LineofLang [23];
			_text3.text = LineofLang [24];
			_stage0.text = LineofLang [25];
			_stage1.text = LineofLang [25];
			_stage2.text = LineofLang [25];
			_stage3.text = LineofLang [25];
			_stage4.text = LineofLang [25];
			_stage5.text = LineofLang [25];

			_level0.text = LineofLang [26];
			_level1.text = LineofLang [26];
			_level2.text = LineofLang [26];
			_level3.text = LineofLang [26];
			_level4.text = LineofLang [26];
			_level5.text = LineofLang [26];
			_button.text = LineofLang [27];
			break;

		case 4:
			_howtoplay.text = LineofLang [28];
			_text1.text = LineofLang [29];
			_text2.text = LineofLang [30];
			_text3.text = LineofLang [31];
			_stage0.text = LineofLang [32];
			_stage1.text = LineofLang [32];
			_stage2.text = LineofLang [32];
			_stage3.text = LineofLang [32];
			_stage4.text = LineofLang [32];
			_stage5.text = LineofLang [32];

			_level0.text = LineofLang [33];
			_level1.text = LineofLang [33];
			_level2.text = LineofLang [33];
			_level3.text = LineofLang [33];
			_level4.text = LineofLang [33];
			_level5.text = LineofLang [33];
			_button.text = LineofLang [34];
			break;

		case 5:
			_howtoplay.text = LineofLang [35];
			_text1.text = LineofLang [36];
			_text2.text = LineofLang [37];
			_text3.text = LineofLang [38];
			_stage0.text = LineofLang [39];
			_stage1.text = LineofLang [39];
			_stage2.text = LineofLang [39];
			_stage3.text = LineofLang [39];
			_stage4.text = LineofLang [39];
			_stage5.text = LineofLang [39];

			_level0.text = LineofLang [40];
			_level1.text = LineofLang [40];
			_level2.text = LineofLang [40];
			_level3.text = LineofLang [40];
			_level4.text = LineofLang [40];
			_level5.text = LineofLang [40];
			_button.text = LineofLang [41];
			break;

		case 6:
			_howtoplay.text = LineofLang [42];
			_text1.text = LineofLang [43];
			_text2.text = LineofLang [44];
			_text3.text = LineofLang [45];
			_stage0.text = LineofLang [46];
			_stage1.text = LineofLang [46];
			_stage2.text = LineofLang [46];
			_stage3.text = LineofLang [46];
			_stage4.text = LineofLang [46];
			_stage5.text = LineofLang [46];

			_level0.text = LineofLang [47];
			_level1.text = LineofLang [47];
			_level2.text = LineofLang [47];
			_level3.text = LineofLang [47];
			_level4.text = LineofLang [47];
			_level5.text = LineofLang [47];
			_button.text = LineofLang [48];
			break;

		case 7:
			_howtoplay.text = LineofLang [49];
			_text1.text = LineofLang [50];
			_text2.text = LineofLang [51];
			_text3.text = LineofLang [52];
			_stage0.text = LineofLang [53];
			_stage1.text = LineofLang [53];
			_stage2.text = LineofLang [53];
			_stage3.text = LineofLang [53];
			_stage4.text = LineofLang [53];
			_stage5.text = LineofLang [53];

			_level0.text = LineofLang [54];
			_level1.text = LineofLang [54];
			_level2.text = LineofLang [54];
			_level3.text = LineofLang [54];
			_level4.text = LineofLang [54];
			_level5.text = LineofLang [54];
			_button.text = LineofLang [55];
			break;

		/*case 8:
			_howtoplay.text = LineofLang [56];
			_text1.text = LineofLang [57];
			_text2.text = LineofLang [58];
			_text3.text = LineofLang [59];
			_stage0.text = LineofLang [60];
			_stage1.text = LineofLang [60];
			_stage2.text = LineofLang [60];
			_stage3.text = LineofLang [60];
			_stage4.text = LineofLang [60];
			_stage5.text = LineofLang [60];

			_level0.text = LineofLang [61];
			_level1.text = LineofLang [61];
			_level2.text = LineofLang [61];
			_level3.text = LineofLang [61];
			_level4.text = LineofLang [61];
			_level5.text = LineofLang [61];
			_button.text = LineofLang [62];
			break;*/
		}
	}
}
