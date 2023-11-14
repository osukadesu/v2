using UnityEngine;
public class ChanginLevelCollision : MonoBehaviour
{
    [SerializeField] LevelSystem levelSystem;
    void Awake()
    {
        levelSystem = FindObjectOfType<LevelSystem>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            levelSystem.ChangeLevel();
        }
    }
}