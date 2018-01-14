using UnityEngine;
using System.Collections;


public class PlayerController : MonoBehaviour {
	public float speed = 15.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.LeftArrow)) {
			MoveLeft();
		}
		else if(Input.GetKeyDown(KeyCode.RightArrow)) {
			MoveRight();
		}
	}


	void MoveLeft () {
		transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
	}

	void MoveRight () {
		transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
	}
}