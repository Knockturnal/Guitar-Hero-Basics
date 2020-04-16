using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum NoteType {Red, Blue };

public class NoteTarget : MonoBehaviour
{
	[SerializeField]
	[Range(0.3f, 2f)]
	private float detectionRange;
	[SerializeField]
	private NoteType type;
	[SerializeField]
	private LayerMask noteMask;

	private void OnMouseDown()
	{
		Collider2D[] hit = Physics2D.OverlapCircleAll(transform.position, detectionRange, noteMask);
		if (hit != null)
		{
			foreach (Collider2D current in hit)
			{
				if (current.TryGetComponent(out NoteMover m))
				{
					if (m.type == type)
					{
						Debug.Log(Vector2.Distance(transform.position, current.transform.position));
						Destroy(current.gameObject);
					}
				}
			}
		}

    }

	private void OnDrawGizmos()
	{
		Gizmos.DrawWireSphere(transform.position, detectionRange);
	}
}
