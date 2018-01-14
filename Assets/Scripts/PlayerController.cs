using UnityEngine;
using System.Collections;


public class PlayerController : MonoBehaviour {
	public float speed = 15.0f;
	public float padding = 1f;
	float xmin;
	float xmax;

	// Use this for initialization
	void Start () {
		float distance = transform.position.z - Camera.main.transform.position.z;
		Vector3 leftedge = Camera.main.ViewportToWorldPoint(new Vector3(0,0,distance));
		Vector3 rightedge = Camera.main.ViewportToWorldPoint(new Vector3(1,0,distance));
		xmin = leftedge.x + padding;
		xmax = rightedge.x - padding;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.LeftArrow)) {
			MoveLeft();
		}
		else if(Input.GetKeyDown(KeyCode.RightArrow)) {
			MoveRight();
		}

		//Restrict the player to the gamespace
		float newX = Mathf.Clamp (transform.position.x, xmin, xmax);
		transform.position = new Vector3 (newX, transform.position.y, transform.position.z);
	}


	void MoveLeft () {
		//transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
		transform.position += Vector3.left * speed * Time.deltaTime;
	}

	void MoveRight () {
		//transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
		transform.position += Vector3.right * speed * Time.deltaTime;
	}
}