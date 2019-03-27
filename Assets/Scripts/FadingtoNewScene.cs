using UnityEngine;
using System.Collections;

public class FadingtoNewScene : MonoBehaviour {

		public Texture2D FadeOutTexture;	// Sử dụng texture để phủ lên màn hình. Đây có thể là một ảnh màu đen hoặc một ảnh loading.
		public float FadeSpeed = 0.8f;		// Tốc độ chuyển cảnh

		private int DrawDepth = -1000;		// Chiều sâu của texture chuyển cảnh được vẽ ra.
		private float Alpha = 1.0f;			// Giá trị của texture Alpha nằm giữa 0 và 1
		private int FadeDir = -1;			// Hướng của chuyển cảnh, vào = -1, ra = 1.
		//=======================================

		void OnGUI(){
				// Chuyển cảnh vào/ra của biến Alpha có hướng và tốc độ chuyển cảnh
				Alpha += FadeDir * FadeSpeed * Time.deltaTime;
				// Tác dụng của hàm Clamd01 là để đặt khoảng giá trị từ 0 và 1, bởi vì GUI.color sẽ sử dụng giá trị của Alpha từ 0 đến 1
				Alpha = Mathf.Clamp01(Alpha);

				// Đặt giá trị màu cho GUI và dung nó để vẽ ra khung chuyển cảnh 
				GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, Alpha);		// Đặt giá trị cho biến Alpha.
				GUI.depth = DrawDepth;														// Tạo texture màu đen cho việc vẽ chuyển cảnh.
				GUI.DrawTexture (new Rect(0,0,Screen.width,Screen.height),FadeOutTexture);  // Vẽ texture cho vừa với khung màn hình.

		}
		//=====================================
		//  Đặt biến FadeDir thành tham số có hướng để chuyển cảnh từ tham số vào = -1 và ra = 1
		public float BeginFade(int Direction){
				
				FadeDir = Direction;
				return (FadeSpeed);		// Trả lại giá trị cho biến FadeSpeed. Việc này có thể đặt thời gian tùy ý cho việc LoadScene.
		}
		//=====================================

		void OnLevelWasLoad(){

				//Alpha = 1; 	// Sử dụng biến Alpha này nếu giá trị -1 không được đặt mặc định.
				BeginFade (-1); // Gọi hàm BeginFade.
		}
}
