using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class ShowAvatar : MonoBehaviour {

	public GameObject _cylinder;// = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
	public Material _matImage;
	private Texture2D _tex;
	private string fileName;

	// Use this for initialization
	void Awake () {

		// hieu chinh vi tri va do xoay cua Cylinder 
		_cylinder.SetActive (false);
		Show_Avatar ();
	}

	private void Show_Avatar(){

		_cylinder.SetActive (true);
		Vector3 _cylinderPosition = new Vector3 (_cylinder.transform.position.x,_cylinder.transform.position.y,-6);
		_cylinder.transform.position = _cylinderPosition;
		Vector3 _cylinderScale = new Vector3 ((float)0.2f,(float)0.2f,(float)0.2f);
		_cylinder.transform.localScale = _cylinderScale;
		_cylinder.transform.rotation = Quaternion.Euler(-270, -90, 90);

		_tex = new Texture2D (Screen.width,Screen.height,TextureFormat.RGB24,false);
		fileName = Path.Combine(Application.persistentDataPath+"/","photoedited.png");
		byte[] bytes = File.ReadAllBytes (fileName);
		_tex.LoadImage (bytes);
		_matImage.mainTexture = _tex;
		MeshRenderer _render = _cylinder.GetComponent<MeshRenderer> ();
		_render.material = _matImage;
	}
	
	// Update is called once per frame
	void Update () {
	 
		//Show_Avatar ();
	}
}
