using UnityEngine;
public class GameOver : MonoBehaviour
{
    [SerializeField] PrincipalMenuView PrincipalMenuView;
    private void Awake()
    {
        PrincipalMenuView = FindObjectOfType<PrincipalMenuView>();
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PrincipalMenuView.MethodPM();
        }
    }
}