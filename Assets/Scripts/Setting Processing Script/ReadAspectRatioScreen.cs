using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using System.IO;
using System;

public class ReadAspectRatioScreen : MonoBehaviour {

	private string [] StringReadIndex;
	private float heightOfphone;
	private float widthOfphone;
	protected string aspect16_9 = "1.777";
	protected string aspect16_10 = "1.6";
	protected string aspect4_3 = "1.3";
	protected string aspect3_2 = "1.5";
	private float _calculate;			// bien float de chua gia tri tinh toan ty le man hinh 
	private string _result;				// bien string dung de chua gia tri tinh toan ty le man hinh
	protected string _ratioCalculate;		// bien string de lay 3 ky tu dau cua day so: 1.7 hoac 1.6


	// Use this for initialization
	void Start () {
	
		string pathoffile = Path.Combine(Application.persistentDataPath+"/", "indexofscreen.bin");
		if (File.Exists (pathoffile)) {

			StringReadIndex = File.ReadAllLines (pathoffile);
			heightOfphone = float.Parse (StringReadIndex [0]); 
			widthOfphone = float.Parse (StringReadIndex [1]); 
			_calculate = widthOfphone / heightOfphone;
			_result = _calculate.ToString ();
			_ratioCalculate = _result.Substring (0, 5);
		} else {

			SceneManager.LoadScene (1, LoadSceneMode.Single);
		}
	}

	// Make button select scene when finish calculating aspect ratio;
	public void ButtonSelectScene(){

		bool _compare16_9 = _ratioCalculate.Equals (aspect16_9,StringComparison.Ordinal);
		bool _compare16_10 = _ratioCalculate.Equals (aspect16_10,StringComparison.Ordinal);
		if (_compare16_9)
			SceneManager.LoadScene (1, LoadSceneMode.Single);
		else if (_compare16_10)
			SceneManager.LoadScene (55, LoadSceneMode.Single);
		else
			SceneManager.LoadScene (55, LoadSceneMode.Single);
		/*} else if (_result == aspect16) {

			SceneManager.LoadScene (55, LoadSceneMode.Single);
		} else {
			
			SceneManager.LoadScene (55, LoadSceneMode.Single);
		}*/
	}

	// Update is called once per frame
	void Update () {
	

	}
}
