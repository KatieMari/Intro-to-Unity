using System.Threading;
using UnityEngine;
using UnityEngine.AI;

public class SpawnAnimal : MonoBehaviour
{
    public GameObject myPrefab;
    float timestamp;
    float spawnRate = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timestamp = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float elapsedTime = Time.time;
        if (elapsedTime > timestamp + spawnRate)
        {
            GameObject kitty = Instantiate(myPrefab, new Vector3(Random.Range(-5f, 5f), 0f, Random.Range(-5f, 5f)), Quaternion.AngleAxis(Random.Range(0, 360), transform.up));
            float scaleFactor = Random.Range(0.9f, 5f);
            kitty.transform.localScale *= scaleFactor;
            timestamp = elapsedTime;
        }
    }
}
