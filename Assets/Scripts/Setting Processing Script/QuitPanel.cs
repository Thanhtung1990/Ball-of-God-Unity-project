using UnityEngine;
using System.Collections;
using StartApp;

public class QuitPanel : MonoBehaviour {

	public GameObject _quitpanel;
	// Use this for initialization
	void Start () {
		_quitpanel.SetActive (false);
	}
	//================================

	//================================
	public void ShowQuitPanel(){
		Time.timeScale = 0;	// this code make time in game frezze and it seem like game in pause.
			_quitpanel.SetActive (true);
#if UNITY_ANDROID
        StartAppWrapper.init();
        StartAppWrapper.loadAd();
        ShowSplash();
#endif
    }
    //=============Show Splash======================
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
