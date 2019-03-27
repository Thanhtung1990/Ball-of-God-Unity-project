using UnityEngine;
using System.Collections;

public class Control_Moving_Barrier : MonoBehaviour {

		public Transform[] Path;
		public float speed = 5.5f;
		public float reachDist=1.0f;
		public int CurrentPoint = 0;

		// Update is called once per frame
		void Update () {

				float dist = Vector3.Distance (Path[CurrentPoint].position,transform.position);

				transform.position = Vector3.MoveTowards (transform.position,Path[CurrentPoint].position,Time.deltaTime*speed);

				if (dist <= reachDist) {
						CurrentPoint++;
				}

				if (CurrentPoint >= Path.Length) {
						CurrentPoint = 0;
				}
						
		}

		//===========================

		void OnDrawGizmos(){

				if (Path.Length > 0)
						for (int i = 0; i < Path.Length; i++) {
								if (Path [i] != null) {
										Gizmos.DrawSphere (Path[i].position,reachDist);
								}
						}
		}
}
