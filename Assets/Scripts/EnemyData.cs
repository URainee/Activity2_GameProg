using UnityEngine;

//Add this to the right click menu in Unity
[CreateAssetMenu(fileName = "New Enemy", menuName = "Game Data/Enemy")]
public class EnemyData : ScriptableObject
{
    [Header("Basic Info")]
    public int enemyID;

    public string enemyName;

    public Sprite enemyIcon;

    public GameObject enemyModel;

    [Header("Combat Stats")]
    public int baseDamage;

    public int baseHealth;

    public float baseSpeed;

    [Header("Audio")]

    public AudioClip enemySound;
}
