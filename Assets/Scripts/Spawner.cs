using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	public Vector2 DelayRange;
	public GameObject PlayerPrefab;

	private float delay;

	private void Start()
	{
		delay = Random.Range(DelayRange.x, DelayRange.y);
	}

	void Update()
    {
		delay -= Time.deltaTime;
		if(delay <= 0f)
		{
			delay = Random.Range(DelayRange.x, DelayRange.y);
			Instantiate(PlayerPrefab, transform.position,Quaternion.identity);
		}
    }
}
