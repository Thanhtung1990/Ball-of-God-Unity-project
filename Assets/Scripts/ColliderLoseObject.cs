using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//using StartApp;

public class ColliderLoseObject : MonoBehaviour {

		public GameObject _CanvasLose;
		//public GameObject _Fireball1;
        //public GameObject _Fireball2;
        public GameObject _Thunderball;
		public AudioClip _audio;
		public int scene;
        public GameObject[] _cloneBall;
        public Text _shownumberofBall;
		//================================

		void Awake(){
            int i;
		    _CanvasLose.SetActive (false);
                for (i = 0; i < _cloneBall.Length; i++)
                {
                    Instantiate(_cloneBall[i], _cloneBall[i].transform.position, _cloneBall[i].transform.rotation);
                    _shownumberofBall.text =  i.ToString();
                    if (i==9) {
                        ChangeToScene();
                    }
                }
        }

		//===============================
	public IEnumerator TimeToFace(){
		
		float FadeTime = GameObject.Find ("Canvas").GetComponent<FadingtoNewScene> ().BeginFade (1);
		yield return new WaitForSeconds (FadeTime);
	}
		//===============================
	public void ChangeToScene(){

		TimeToFace ();
		Time.timeScale = 1;
		SceneManager.LoadScene (scene,LoadSceneMode.Single);
	}
	//===================================
		/*void OnCollisionEnter2D(Collision2D coll) {
        int i = 0;
			Destroy(_Thunderball);
        //_cloneBall = new GameObject[20];
        // Tìm vật thể có tag là: Player

        for (i=0; i<_cloneBall.Length; i++) {

           

            if (coll.transform.tag == "Player")  // unity finds out object by tag"Player"
            {
                AudioSource.PlayClipAtPoint(_audio, transform.position);
                _CanvasLose.SetActive(false);

                _cloneBall[i].SetActive(false);
                //Destroy(_Fireball1);
                //_Fireball1.SetActive(false);
                
                //ChangeToScene ();
            }
            
        }              
            

        }*/

    // Use this for initialization
    /* public void ShowBanner()
     {
         #if UNITY_ANDROID
         StartAppWrapper.addBanner(
                                   StartAppWrapper.BannerType.AUTOMATIC,
                                   StartAppWrapper.BannerPosition.BOTTOM);
         #endif
     }*/
}
