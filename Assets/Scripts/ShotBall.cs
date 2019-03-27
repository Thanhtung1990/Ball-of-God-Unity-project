using UnityEngine;
using System.Collections;

public class ShotBall : MonoBehaviour {

	public Transform Dotblur1; // khai bien kieu LineRenderer
	private SpringJoint2D spring; // khai bien kieu SpringJoint2D
	private Ray rayTomouse;
	public GameObject _fireballForce;
	public GameObject _thunderballForce;
	public GameObject _scope;
	//
	private bool clickedOn; // bien de thiet lap trang thai click chuot hoac cam ung
	private float maxStretchSqr; // bien dung de dieu chinh luc co dan de ban qua bong
	public float maxStretch; // bien dung de thiet lap khoang cach tu ngoi sao den qua bong
	private Vector2 preVelocity; // bien dung de thiet lap van toc ban dau cua qua bong
	// Use this for initialization
	void Awake(){

		spring = GetComponent<SpringJoint2D> ();
		Dotblur1 = spring.connectedBody.transform;
	}
	// Use this for initialization
	void Start () {

		_thunderballForce.SetActive (false);
		_fireballForce.SetActive (false);
		maxStretchSqr = maxStretch; 	
		rayTomouse = new Ray (Dotblur1.transform.position,Vector3.zero);
	}
	// ===================================================================================
	void OnMouseDown(){

		spring.enabled = false;
		clickedOn = true;
	}
	//======================================================================================
	void OnMouseUp(){

		spring.enabled = true;
		GetComponent<Rigidbody2D>().isKinematic = false;
		clickedOn = false;
	}	
	//==Ham nay co tac dung bat lay vi tri con tro chuot va lay vi tri day gan vao qua bong==
	void Dragging(){

		_fireballForce.SetActive (true);
		_thunderballForce.SetActive (true);
		//foreach(Touch touch in Input.touches){
		//if (touch.phase != TouchPhase.Ended) {
		///if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved){
		//Vector3 mouseWorldPoint = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
		Vector3 mouseWorldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition); // co the thay the bien TOUCH de dung cho mobile
		//Vector2 DotballTomouse = mouseWorldPoint - Dotblur.position;					// ham nay dung de bat vi tri cua chuot va de keo 
		Vector2 DotballTomouse = mouseWorldPoint - Dotblur1.transform.position;
		// qua bong de tao ra luc
		if (DotballTomouse.magnitude > maxStretchSqr) {
			rayTomouse.direction = DotballTomouse;
			mouseWorldPoint = rayTomouse.GetPoint (maxStretch);
			_fireballForce.transform.localScale = new Vector3 (_fireballForce.transform.localScale.x, maxStretch, _fireballForce.transform.localScale.z);
			_thunderballForce.transform.localScale = new Vector3 (_thunderballForce.transform.localScale.x, maxStretch, _thunderballForce.transform.localScale.z);
		} else {
			_fireballForce.transform.localScale = new Vector3(_fireballForce.transform.localScale.x, DotballTomouse.magnitude, _fireballForce.transform.localScale.z);
			_thunderballForce.transform.localScale = new Vector3 (_thunderballForce.transform.localScale.x, DotballTomouse.magnitude, _thunderballForce.transform.localScale.z);
		}
		mouseWorldPoint.z = 0f;
		transform.position = mouseWorldPoint;

		_scope.transform.position = Dotblur1.position - (transform.position - Dotblur1.position); // position of scope = position of star - distance of fireball and star.

	}

	//}				
	//}

	//==Hàm này có tác dụng bắn quả bóng đi==
	void ShotTheBall(){

		if (spring != null) {
			if (!GetComponent<Rigidbody2D>().isKinematic && preVelocity.sqrMagnitude > GetComponent<Rigidbody2D>().velocity.sqrMagnitude) {
				Destroy (spring);                  // Xóa lực kéo của qủa bóng trước đó
				GetComponent<Rigidbody2D>().velocity = preVelocity;// Gán vận tốc của qủa bóng bằng với vận tốc trước đó
			}
			else if (!clickedOn) {							//Nếu không có click từ con trỏ chuột đúng với vị trí quả bóng
				preVelocity = GetComponent<Rigidbody2D>().velocity;	//Thì gán vận tốc của đối tượng Rigidbody2D vào vận tốc trước đó
							
			}

		}	else{
			//Dotblur1.enabled = false;
		
		}
	}

	// Update is called once per frame
	void Update () {
	
		if (clickedOn) 
			Dragging ();
			ShotTheBall ();	
	}
}
