using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteMover : MonoBehaviour
{
	[SerializeField]
	[Range(1f, 10f)]
	private float speed;
	public NoteType type;
	void Update()
    {
		transform.position += Vector3.left * Time.deltaTime * speed * 3f;
    }
}
