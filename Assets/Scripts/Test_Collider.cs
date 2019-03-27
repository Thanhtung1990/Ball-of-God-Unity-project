using UnityEngine;
using System.Collections;

public class Test_Collider : MonoBehaviour {

		// File này dùng để tạo hiệu ứng khi dùng một vật thể 1 bắn vào vật thể 2. Sau đó, vật thể 2 biến mất và effect lóe sang xuất hiện.
		public AudioClip _audioDestroy;
		public AudioClip _audioPlayer;
		public Transform explosionPrefab; 
		public GameObject _EffectPrefab;  // Khai báo biến để đưa hiệu ứng nổ lóe sáng từ Prefab vào Script.// Khai báo biến để đưa hiệu ứng nổ lóe sáng từ Prefab vào Script.
		//public AudioClip soundCollision;	

		//== Hàm này có tác dụng tạo ra hiệu ứng va chạm của hai vật thể và them hiệu ứng lóe sang tại điểm tiếp xúc ==

		void OnCollisionEnter2D(Collision2D coll) {
				if (coll.gameObject.tag == "Destroy") {
						
						AudioSource.PlayClipAtPoint(_audioDestroy,transform.position);
						Instantiate (explosionPrefab, transform.position, transform.rotation);
						Destroy (gameObject);	// Xóa đối tượng thứ 2 bị va chạm.
				}
				else if(coll.transform.tag == "Player"){

					foreach(ContactPoint2D missileHit in coll.contacts)
					{
						Vector2 hitPoint = missileHit.point;  // Tạo đối tượng Vector 2 có lưu trữ điểm tiếp xúc
						AudioSource.PlayClipAtPoint(_audioPlayer,transform.position);
						// Gọi hàm Instantiate với input là: effect đưa từ Prefab, tọa độ x;y của điểm tiếp xúc, xoay đối tượng.
						Instantiate(_EffectPrefab,new Vector3(hitPoint.x, hitPoint.y, 0), transform.rotation);
					}
				}
		}
}
