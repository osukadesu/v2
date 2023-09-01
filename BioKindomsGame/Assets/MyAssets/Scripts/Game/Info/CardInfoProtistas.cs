using UnityEngine;
using UnityEngine.UI;
public class CardInfoProtistas : MonoBehaviour
{
    [SerializeField] CanvasManager _canvasManager;
    [SerializeField] Button btnBackInfoProtistas, btnInfoProtista1, btnInfoProtista2, btnInfoProtista3, btnInfoProtista4, btnInfoProtista5;
    [SerializeField] GameObject _cardInfoProtistas, _cardInfoProtista1, _cardInfoProtista2, _cardInfoProtista3, _cardInfoProtista4, _cardInfoProtista5;
    void Start()
    {
        _cardInfoProtistas.SetActive(false);
    }
    void Awake()
    {
        btnBackInfoProtistas.onClick.AddListener(() => _canvasManager.CloseInfo());
        btnInfoProtista1.onClick.AddListener(() => _canvasManager.InfoProtista1());
        btnInfoProtista2.onClick.AddListener(() => _canvasManager.InfoProtista2());
        btnInfoProtista3.onClick.AddListener(() => _canvasManager.InfoProtista3());
        btnInfoProtista4.onClick.AddListener(() => _canvasManager.InfoProtista4());
        btnInfoProtista5.onClick.AddListener(() => _canvasManager.InfoProtista5());
    }
    public void Configure(CanvasManager canvasManager)
    {
        _canvasManager = canvasManager;
    }
    public void Show()
    {
        _cardInfoProtistas.SetActive(true);
    }
    public void Hide()
    {
        _cardInfoProtistas.SetActive(false);
    }
    public void ThisInfoProtista1()
    {
        Show();
        _cardInfoProtista1.SetActive(true);
        _cardInfoProtista2.SetActive(false);
        _cardInfoProtista3.SetActive(false);
        _cardInfoProtista4.SetActive(false);
        _cardInfoProtista5.SetActive(false);
    }
    public void ThisInfoProtista2()
    {
        Show();
        _cardInfoProtista1.SetActive(false);
        _cardInfoProtista2.SetActive(true);
        _cardInfoProtista3.SetActive(false);
        _cardInfoProtista4.SetActive(false);
        _cardInfoProtista5.SetActive(false);
    }
    public void ThisInfoProtista3()
    {
        Show();
        _cardInfoProtista1.SetActive(false);
        _cardInfoProtista2.SetActive(false);
        _cardInfoProtista3.SetActive(true);
        _cardInfoProtista4.SetActive(false);
        _cardInfoProtista5.SetActive(false);
    }
    public void ThisInfoProtista4()
    {
        Show();
        _cardInfoProtista1.SetActive(false);
        _cardInfoProtista2.SetActive(false);
        _cardInfoProtista3.SetActive(false);
        _cardInfoProtista4.SetActive(true);
        _cardInfoProtista5.SetActive(false);
    }
    public void ThisInfoProtista5()
    {
        Show();
        _cardInfoProtista1.SetActive(false);
        _cardInfoProtista2.SetActive(false);
        _cardInfoProtista3.SetActive(false);
        _cardInfoProtista4.SetActive(false);
        _cardInfoProtista5.SetActive(true);
    }
}