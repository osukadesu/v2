using UnityEngine;
using UnityEngine.UI;
public class CardInfoMoneras : MonoBehaviour
{
    [SerializeField] CanvasManager _canvasManager;
    [SerializeField] Button btnBackInfoMoneras, btnInfoMonera1, btnInfoMonera2, btnInfoMonera3, btnInfoMonera4, btnInfoMonera5;
    [SerializeField] GameObject _cardInfoMoneras, _cardInfoMonera1, _cardInfoMonera2, _cardInfoMonera3, _cardInfoMonera4, _cardInfoMonera5;
    void Start()
    {
        _cardInfoMoneras.SetActive(false);
    }
    void Awake()
    {
        btnBackInfoMoneras.onClick.AddListener(() => _canvasManager.CloseInfo());
        btnInfoMonera1.onClick.AddListener(() => _canvasManager.InfoMonera1());
        btnInfoMonera2.onClick.AddListener(() => _canvasManager.InfoMonera2());
        btnInfoMonera3.onClick.AddListener(() => _canvasManager.InfoMonera3());
        btnInfoMonera4.onClick.AddListener(() => _canvasManager.InfoMonera4());
        btnInfoMonera5.onClick.AddListener(() => _canvasManager.InfoMonera5());
    }
    public void Configure(CanvasManager canvasManager)
    {
        _canvasManager = canvasManager;
    }
    public void Show()
    {
        _cardInfoMoneras.SetActive(true);
    }
    public void Hide()
    {
        _cardInfoMoneras.SetActive(false);
    }
    public void ThisInfoMonera1()
    {
        Show();
        _cardInfoMonera1.SetActive(true);
        _cardInfoMonera2.SetActive(false);
        _cardInfoMonera3.SetActive(false);
        _cardInfoMonera4.SetActive(false);
        _cardInfoMonera5.SetActive(false);
    }
    public void ThisInfoMonera2()
    {
        Show();
        _cardInfoMonera1.SetActive(false);
        _cardInfoMonera2.SetActive(true);
        _cardInfoMonera3.SetActive(false);
        _cardInfoMonera4.SetActive(false);
        _cardInfoMonera5.SetActive(false);
    }
    public void ThisInfoMonera3()
    {
        Show();
        _cardInfoMonera1.SetActive(false);
        _cardInfoMonera2.SetActive(false);
        _cardInfoMonera3.SetActive(true);
        _cardInfoMonera4.SetActive(false);
        _cardInfoMonera5.SetActive(false);
    }
    public void ThisInfoMonera4()
    {
        Show();
        _cardInfoMonera1.SetActive(false);
        _cardInfoMonera2.SetActive(false);
        _cardInfoMonera3.SetActive(false);
        _cardInfoMonera4.SetActive(true);
        _cardInfoMonera5.SetActive(false);
    }
    public void ThisInfoMonera5()
    {
        Show();
        _cardInfoMonera1.SetActive(false);
        _cardInfoMonera2.SetActive(false);
        _cardInfoMonera3.SetActive(false);
        _cardInfoMonera4.SetActive(false);
        _cardInfoMonera5.SetActive(true);
    }
}