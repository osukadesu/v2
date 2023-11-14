using UnityEngine;
public class GameOver : MonoBehaviour
{
    [SerializeField] PrincipalMenuView PrincipalMenuView;
    void Awake()
    {
        PrincipalMenuView = FindObjectOfType<PrincipalMenuView>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PrincipalMenuView.MethodPrincipalMenu();
        }
    }
}