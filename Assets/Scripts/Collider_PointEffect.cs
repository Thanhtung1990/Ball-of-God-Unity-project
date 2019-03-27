using UnityEngine;
using System.Collections;

public class Collider_PointEffect : MonoBehaviour {

		// File này dùng để tạo hiệu ứng khi bắn quả bóng vào một vật thể thì sẽ có một vụ nổ lóe ra tại điểm tiếp xúc.

		public GameObject _EffectPrefab;  // Khai báo biến để đưa hiệu ứng nổ lóe sáng từ Prefab vào Script.
		public AudioClip _audio;

	void Start(){

		_EffectPrefab.SetActive (false);
	}
		//== Hàm này có tác dụng tạo ra hiệu ứng va chạm của hai vật thể và them hiệu ứng lóe sang tại điểm tiếp xúc ==
		void OnCollisionEnter2D(Collision2D coll) 
		{
			_EffectPrefab.SetActive (true);
				// Tìm vật thể có tag là: Player
				if(coll.transform.tag == "Player" || coll.transform.tag == "Destroy")
				{
						
						// Tạo một vòng lặp để tìm tất cả các điểm tiếp xúc giữa hai vật thể
						foreach(ContactPoint2D missileHit in coll.contacts)
						{
								Vector2 hitPoint = missileHit.point;  // Tạo đối tượng Vector 2 có lưu trữ điểm tiếp xúc
								AudioSource.PlayClipAtPoint(_audio,transform.position);
								// Gọi hàm Instantiate với input là: effect đưa từ Prefab, tọa độ x;y của điểm tiếp xúc, xoay đối tượng.
								Instantiate(_EffectPrefab,new Vector3(hitPoint.x, hitPoint.y, 0), transform.rotation);
						}
				}
		}
}
