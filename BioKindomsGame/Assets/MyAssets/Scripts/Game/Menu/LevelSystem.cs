using UnityEngine;
public class LevelSystem : MonoBehaviour
{
    [SerializeField] int currentLevel;
    [SerializeField] LoadController loadController;
    void Awake()
    {
        loadController = FindObjectOfType<LoadController>();
    }
    void Start()
    {
        currentLevel = loadController.ValueLevel;
        ProcesarNivel(currentLevel);
    }
    public void ChangeLevel()
    {
        currentLevel++;
        ProcesarNivel(currentLevel);
        Debug.Log("Nivel actual: " + currentLevel);
    }
    public void ProcesarNivel(int level)
    {
        switch (level)
        {
            case 1:
                Debug.Log("Bienvenido al Nivel 1");
                break;
            case 2:
                Debug.Log("Bienvenido al Nivel 2");
                break;
            default:
                Debug.Log("Haz finalizado");
                break;
        }
    }
}