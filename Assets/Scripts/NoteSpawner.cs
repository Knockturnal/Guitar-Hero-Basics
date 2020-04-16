using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpawner : MonoBehaviour
{
	[SerializeField]
	private GameObject noteType1Prefab, noteType2Prefab, noteType1Spawn, noteType2Spawn;

	private void Start()
	{
		StartCoroutine(SpawnWave());
	}

	private IEnumerator SpawnWave() 
	{
		Instantiate(noteType1Prefab, noteType1Spawn.transform.position, Quaternion.identity);
		yield return new WaitForSeconds(0.5f);
		Instantiate(noteType2Prefab, noteType2Spawn.transform.position, Quaternion.identity);
		yield return new WaitForSeconds(0.5f);
		Instantiate(noteType1Prefab, noteType1Spawn.transform.position, Quaternion.identity);
		yield return new WaitForSeconds(0.5f);
		Instantiate(noteType1Prefab, noteType1Spawn.transform.position, Quaternion.identity);
		yield return new WaitForSeconds(0.5f);
		Instantiate(noteType2Prefab, noteType2Spawn.transform.position, Quaternion.identity);
		yield return new WaitForSeconds(0.5f);
		Instantiate(noteType1Prefab, noteType1Spawn.transform.position, Quaternion.identity);
		Instantiate(noteType2Prefab, noteType2Spawn.transform.position, Quaternion.identity);
	}

}
