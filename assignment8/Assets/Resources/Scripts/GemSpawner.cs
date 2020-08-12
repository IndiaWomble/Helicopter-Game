using UnityEngine;
using System.Collections;

public class GemSpawner : MonoBehaviour
{
	public GameObject[] prefabs;

	// Use this for initialization
	void Start()
	{
		StartCoroutine(SpawnGems());
	}

	IEnumerator SpawnGems()
	{
		while (true)
		{
			Instantiate(prefabs[Random.Range(0, prefabs.Length)], new Vector3(26, Random.Range(-10, 10), 10), Quaternion.identity);
			yield return new WaitForSeconds(Random.Range(5, 10));
		}
	}
}
