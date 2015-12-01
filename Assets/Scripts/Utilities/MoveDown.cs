using UnityEngine;
using System.Collections;

public class MoveDown : MonoBehaviour {

	public float speed = 1f;

	void Update () {
		transform.Translate(-Vector2.up * Time.deltaTime * speed);
	}
}
