using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.IO;
//using StartApp;

public class WinStatus : MonoBehaviour {

		public GameObject _Fireball;
		public GameObject _CanvasWin;
		public GameObject _Prefab;
		public AudioClip _audio;
		public AudioClip _audioFirework;
		public GameObject _FirewokPosition;
		// cac parameters dung cho viec hien avatar

		void Awake(){
			_Prefab.SetActive (false);
			_CanvasWin.SetActive (false);
			
			
		}
		//======================================================

		//======================================================
		void OnCollisionEnter2D(Collision2D coll) {
		//Transform _FirewokPosition;
		//_FirewokPosition.position.x = -1.92;
		//_FirewokPosition.position.y = 1.28;
				// Tìm vật thể có tag là: Player
			
				if (coll.transform.tag == "Player") {
						_Prefab.SetActive (true);
						AudioSource.PlayClipAtPoint(_audio,transform.position);
						AudioSource.PlayClipAtPoint(_audioFirework,transform.position);
						Instantiate (_Prefab, _FirewokPosition.transform.position, _FirewokPosition.transform.rotation);
						_CanvasWin.SetActive (true);
						Destroy(_Fireball);
				}
				
/*#if UNITY_ANDROID
        StartAppWrapper.init();
        StartAppWrapper.loadAd();
        ShowBanner();
#endif*/
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
}
