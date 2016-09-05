using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float speed = 15f;
	public float mapWidth = 5f;

	private Rigidbody2D rb;

	private GameManager gm;

	void Start() {
		gm = GameManager.instance;
		rb = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate() {
		float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;

		Vector2 newPosition = rb.position + Vector2.right * x;

		newPosition.x = Mathf.Clamp(newPosition.x, -mapWidth, mapWidth);

		rb.MovePosition(newPosition);
	}

	void OnCollisionEnter2D() {
		gm.EndGame();
	}	

}
