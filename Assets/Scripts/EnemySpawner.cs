using UnityEngine;
using System.Collections.Generic;

public class EnemySpawner : MonoBehaviour
{

    public GameObject slimePrefab;

    public GameObject goblinPrefab;

    public GameObject banditPrefab;

    public GameObject dragonPrefab;

    public Dictionary<int, GameObject> levelEnemies = new Dictionary<int, GameObject>();

    void Start()
    {
        levelEnemies.Add(1, slimePrefab);
        levelEnemies.Add(2, goblinPrefab);
        levelEnemies.Add(2, banditPrefab);
        levelEnemies.Add(3, dragonPrefab);

        SpawnEnemyForLevel(2, levelEnemies);
        SpawnEnemyForLevel(3, levelEnemies);
    }

    public void SpawnEnemyForLevel(int levelNumber, Dictionary<int, GameObject> enemyLookUpTable)
    {
        if (enemyLookUpTable.ContainsKey(levelNumber))
        {
            GameObject prefabsToSpawn = enemyLookUpTable[levelNumber];

            Instantiate(prefabsToSpawn);
        }
        else
        {
            Debug.Log("No number level you input is set up in the dictionary");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
