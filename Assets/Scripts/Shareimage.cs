using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;


public class Shareimage : MonoBehaviour {

    //=================== propertive here =================
    private bool isProcessing = false;
    private string shareText = "Unbelievable.I have made a miracle.\n";
	private string gameLink = "Download the game on google play at " + "https://play.google.com/store/apps/details?id=com.charliegames.ballofgod\n";
    private string subject = "Let's play Ball of God. And share an awesome moment";
    
    //==================== method here =====================
    public void shareImage()
    {

        if (isProcessing=true)
            StartCoroutine(ShareScreenshot());

    }
    //=========================================================

    public IEnumerator ShareScreenshot()
    {

             
             //== take screenshot ==
             yield return new WaitForEndOfFrame();
             Texture2D tex = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
             tex.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
             tex.Apply();

             byte[] dataToSave = tex.EncodeToPNG();
             Object.Destroy(tex);
            
             string destination = Path.Combine(Application.persistentDataPath+"/","photo.png");
             File.WriteAllBytes(destination, dataToSave);


       

        //== This code use Android Javaclass to take photo in cache and share it by another social app ==
       
        
            AndroidJavaClass intentClass = new AndroidJavaClass("android.content.Intent");
            AndroidJavaObject intentObject = new AndroidJavaObject("android.content.Intent");
            intentObject.Call<AndroidJavaObject>("setAction", intentClass.GetStatic<string>("ACTION_SEND"));
            AndroidJavaClass uriClass = new AndroidJavaClass("android.net.Uri");
            AndroidJavaObject uriObject = uriClass.CallStatic<AndroidJavaObject>("parse", "file://" + destination);
            intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_STREAM"), uriObject);
            intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_TEXT"), shareText + gameLink);
            intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_SUBJECT"), subject);
            intentObject.Call<AndroidJavaObject>("setType", "image/png");
            AndroidJavaClass unity = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            AndroidJavaObject currentActivity = unity.GetStatic<AndroidJavaObject>("currentActivity");

            // option one WITHOUT chooser:
            currentActivity.Call("startActivity", intentObject);
        
      
        
    }
}
