using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StartApp;

public class SmallBannerAds : MonoBehaviour {

	// Use this for initialization
	void Start () {

//#if UNITY_ANDROID
        //StartAppWrapper.init();
       // StartAppWrapper.loadAd();
        //ShowBanner();
//#endif
    }

    //=============Show banner====================
   /* public void ShowBanner()
    {
#if UNITY_ANDROID
        StartAppWrapper.addBanner(
			StartAppWrapper.BannerType.AUTOMATIC,
                                  StartAppWrapper.BannerPosition.BOTTOM);
#endif
    }*/

	// =============Remove banner=================
	/*public void RemoveBanner(){
		#if UNITY_ANDROID
		StartAppWrapper.removeBanner(StartAppWrapper.BannerPosition.BOTTOM);
		#endif
	}*/
    // Update is called once per frame
    void Update () {
		
	}
}
