using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.IO;
using System;

public class DetectingScreenPixels : MonoBehaviour {

	//== parameters
	// The logical density of the display
	public float Density {get; protected set; }

	// the screen density expressed as dots-per-inch
	public int DensityDPI {get; protected set; }

	// the absolute height of the display in pixels
	public int HeightPixels {get; protected set; }

	// the absolute width of the display in pixels
	public int WidthPixels {get; protected set; }

	// a calling factor for fonts displayed on the display
	public float ScaledDensity {get; protected set; }

	// the exact physical pixels per inch of the screen in the X dimension
	public float XDPI {get; protected set; }

	// the exact physical pixels per inch of the screen in the Y dimension
	public float YDPI {get; protected set; }

	//== creat some parameters to calculate aspect ratio of screen phone
	protected string aspect16_9 = "1.7777";
	protected string aspect16_10 = "1.6000";
	protected string aspect4_3 = "1.3";
	protected string aspect3_2 = "1.5";
	private float _calculate;			// bien float de chua gia tri tinh toan ty le man hinh 
	private string _result;				// bien string dung de chua gia tri tinh toan ty le man hinh
	protected string _ratioCalculate;   // bien string de lay 3 ky tu dau cua day so: 1.7 hoac 1.6


	// Use this for initialization
	void Awake () {
	
		// early out if we are not on an android device
		if(Application.platform != RuntimePlatform.Android){
			return;
		}

		using (
			AndroidJavaClass unityPlayerClass = new AndroidJavaClass ("com.unity3d.player.UnityPlayer"),
			metricsClass = new AndroidJavaClass ("android.util.DisplayMetrics")) {
			using (
				AndroidJavaObject metricsInstance = new AndroidJavaObject ("android.util.DisplayMetrics"),
				activityInstance = unityPlayerClass.GetStatic<AndroidJavaObject> ("currentActivity"),
				windowManagerInstance = activityInstance.Call<AndroidJavaObject> ("getWindowManager"),
				displayInstance = windowManagerInstance.Call<AndroidJavaObject> ("getDefaultDisplay")) {
				displayInstance.Call ("getMetrics", metricsInstance);
				Density = metricsInstance.Get<float> ("density");
				DensityDPI = metricsInstance.Get<int> ("densityDpi");
				HeightPixels = metricsInstance.Get<int> ("heightPixels");
				WidthPixels = metricsInstance.Get<int> ("widthPixels");
				ScaledDensity = metricsInstance.Get<float> ("scaledDensity");
				XDPI = metricsInstance.Get<float> ("xdpi");
				YDPI = metricsInstance.Get<float> ("ydpi");
			}
		}

		float heightOfphone = float.Parse(HeightPixels.ToString());
		float widthOfphone = float.Parse(WidthPixels.ToString());
		//string[] lines = { heightOfphone, widthOfphone};
		//string path = Path.Combine(Application.persistentDataPath+"/", "indexofscreen.bin");
		//File.WriteAllLines (path,lines);
		_calculate = widthOfphone / heightOfphone;
		_result = _calculate.ToString ();
		_ratioCalculate = _result.Substring (0, 6);

	}
	// Creat button Enter Game to calculate aspect ratio and go to right scene of that aspect.
	public void SelectScene(){

		bool _compare16_9 = _ratioCalculate.Equals (aspect16_9,StringComparison.Ordinal);
		bool _compare16_10 = _ratioCalculate.Equals (aspect16_10,StringComparison.Ordinal);

		if (_compare16_9)
			SceneManager.LoadScene (1, LoadSceneMode.Single);
		else if (_compare16_10)
			SceneManager.LoadScene (108, LoadSceneMode.Single);
		else
			SceneManager.LoadScene (108, LoadSceneMode.Single);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
