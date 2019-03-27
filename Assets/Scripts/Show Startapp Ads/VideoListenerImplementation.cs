using UnityEngine;
using System.Collections;
using StartApp;

#if UNITY_ANDROID
public class VideoListenerImplementation : StartAppWrapper.VideoListener {

	public void onVideoCompleted() {
		// Grant user with the reward
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
#endif
