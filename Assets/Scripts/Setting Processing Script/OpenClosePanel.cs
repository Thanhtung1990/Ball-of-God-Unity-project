using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OpenClosePanel : MonoBehaviour {

	public GameObject _panel;
	//public GameObject _purchasePanel;

	// Use this for initialization
	void Start () {
	
		_panel.SetActive (false);
		//_purchasePanel.SetActive (false);
	}
	//==================
	public void OpenPanel(){

		_panel.SetActive (true);
	}
	//==================
	public void OpenPurchasePanel(){

		//_purchasePanel.SetActive (true);
	}
	//==================
	public void ClosePanel(){

		_panel.SetActive (false);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
