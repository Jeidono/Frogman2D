using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject platformPrefab;
    public int platformCount = 300;

    void Start()
    {
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < platformCount; i++)
        {
            spawnPosition.y += Random.Range(.5f, 2f);
            spawnPosition.x += Random.Range(-5f, 5f);

            // Use the prefab's rotation
            Instantiate(platformPrefab, spawnPosition, platformPrefab.transform.rotation);
        }
    }
}
