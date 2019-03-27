using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using StartApp;

public class NectLevelWithPlashAds : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	//
	public IEnumerator TimeToFade (){

		//  Chuyển cảnh để load level 0 cho người chơi chơi game.
		float FadeTime = GameObject.Find ("Canvas").GetComponent<FadingtoNewScene> ().BeginFade (1);
		yield return new WaitForSeconds (FadeTime);

	}

	// 
	public void ChangeToScene(int NumberOfScene) {
		TimeToFade ();
		Time.timeScale = 1;		// this code make time in game run normally and it seem like game is running. 
		SceneManager.LoadScene(NumberOfScene,LoadSceneMode.Single);
		#if UNITY_ANDROID
		StartAppWrapper.init();
		StartAppWrapper.loadAd();
		ShowSplash();
		#endif
	}
	//
	public void ShowSplash()
	{
		#if UNITY_ANDROID
		StartAppWrapper.showSplash();
		#endif
	}
	// Update is called once per frame
	void Update () {
	
	}
}
