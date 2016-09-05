using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {

	public float difficultyScale = 20f;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / difficultyScale;
	}

}
