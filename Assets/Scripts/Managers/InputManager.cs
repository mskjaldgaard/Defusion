using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		int amountOfTouches = Input.touchCount;

		for(int i = 0; i < amountOfTouches; i++){
			if(Input.GetTouch(i).phase == TouchPhase.Moved) {
				
			}
		}
	}
}
