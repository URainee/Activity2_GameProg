using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class SimpleSpawner : MonoBehaviour
{
    private List<string> activeEnemies = new List<string>();
    [SerializeField] private TextMeshProUGUI enemyList;
    

    public void SpawnEnemy(string enemyName)
    {
        activeEnemies.Add(enemyName);
        UpdateUI();
    }

    public void DefeatEnemy(string enemyName)
    {
        if(activeEnemies.Remove(enemyName))
        {
            Debug.Log($"Defeated {activeEnemies}");
        }
        else
        {
            Debug.LogWarning($"{activeEnemies} cannot be identified");
        }

        UpdateUI();
    }

    public void ClearEnemy()
    {
        activeEnemies.Clear();
        UpdateUI();
    }

    private void UpdateUI()
    {
        if (enemyList == null)
            return;
        
        enemyList.text = "Enemies: \n";
        
        for (int i = 0; i < activeEnemies.Count; i++)
        {
            enemyList.text += $"- {activeEnemies[i]}\n";
        }
    }

}
