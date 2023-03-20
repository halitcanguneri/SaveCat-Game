using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{

    [SerializeField] GameObject glassPrefab;
    [SerializeField] float secondSpawn = 1.0f;
    [SerializeField] float minTras;
    [SerializeField] float maxTras;
    void Start()
    {
        StartCoroutine(spawner());

    }

    IEnumerator spawner()
    {
        while (true)
        {
            var wanted = Random.Range(minTras, maxTras);
            var position = new Vector2(wanted, transform.position.y);
            GameObject gameObject = Instantiate(glassPrefab,
            position, Quaternion.identity);
            yield return new WaitForSeconds(secondSpawn);
            Destroy(gameObject, 9f);
        }

    }

}


