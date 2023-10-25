using UnityEngine;
using UnityEngine.SceneManagement;
public class TimerPresentation : MonoBehaviour
{
    [SerializeField] float myTimer;
    void Start()
    {
        myTimer = 0f;
    }
    void Update()
    {
        MyTimer();
    }
    public void MyTimer()
    {
        myTimer += 1f * Time.deltaTime;
        if (myTimer >= 4.2f)
        {
            SceneManager.LoadScene(2);
        }
    }
}
