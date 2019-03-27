using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;
using System.IO;

public class Fading_Play_Game : MonoBehaviour {
		
	public GameObject _SettingPanel;
	private string pathofsaveScene;
	//private string pathofsaveEasyScene;
	private string[] StringSceneIndex;
	//private string[] StringEasySceneIndex;
	private string _encryptedValue;
	//private string _encryptedValueEasylevel;
	private string numberOfScene;
	//private string numberOfEasyScene;
	private int scene;
	//private int easyscene;
		//=======================
	void Start(){


	}
		//=======================
		public IEnumerator TimeToFade (){

			//  Chuyển cảnh để load level 0 cho người chơi chơi game.
			float FadeTime = GameObject.Find ("Canvas").GetComponent<FadingtoNewScene> ().BeginFade (1);
				yield return new WaitForSeconds (FadeTime);

		}
				
		//========================

		public void ChangeToScene(int NumberOfScene) {


				TimeToFade ();
					Time.timeScale = 1;		// this code make time in game run normally and it seem like game is running. 
						SceneManager.LoadScene(NumberOfScene,LoadSceneMode.Single);
		}

		//=========================



		//========================

		public void StayScene(){
			Time.timeScale = 1;
				GameObject _ob;
					_ob = GameObject.FindWithTag ("Quit panel");
						_ob.SetActive (false);
		}
    
		//========================
		public void OpenSettingPanel(){

			_SettingPanel.SetActive (true);
		}
		//========================
	public void HardLevelLoadScene(int _number){

			pathofsaveScene = Path.Combine(Application.persistentDataPath+"/", "data1.bin");
				if (File.Exists (pathofsaveScene)) {

					StringSceneIndex = File.ReadAllLines (pathofsaveScene);
					_encryptedValue = StringSceneIndex [0]; 
					numberOfScene = Decrypt.DecryptString (_encryptedValue);
					scene = Int32.Parse (numberOfScene);
					SceneManager.LoadScene(scene,LoadSceneMode.Single);
			} else {
				SceneManager.LoadScene(_number,LoadSceneMode.Single);
			}
			
		}
		//========================
	public void HardLevelSaveScene(int _Scene){

		pathofsaveScene = Path.Combine(Application.persistentDataPath+"/", "data1.bin");

			string temp = _Scene.ToString ();
			string _encryptNumber = Encrypt.EncryptString (temp);
			string[] lines = { _encryptNumber };
			File.WriteAllLines (pathofsaveScene, lines);
			SceneManager.LoadScene(_Scene,LoadSceneMode.Single);

	}
		//========================
		public void OnExit(){

		Application.Quit();

		}
       //===================================
	public void OpenLinkFacebook(){

		Application.OpenURL ("https://www.facebook.com/Ball.Of.God/");
	}
    //========================
	public void OpenLinkTwitter(){

		Application.OpenURL ("https://twitter.com/Charlie_Games_");
	}
    //=========================
	public void OpenLinkYoutube(){

		Application.OpenURL ("https://www.youtube.com/channel/UCkdhh3XOIqbHO-4Nm4aKi7w");
	}
	//==========================
	public void RateGame(){

		Application.OpenURL ("https://play.google.com/store/apps/details?id=com.charliegames.ballofgod");
	}
}
