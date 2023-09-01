using UnityEngine;
using UnityEngine.UI;
public class CardInfoVegetals : MonoBehaviour
{
    [SerializeField] CanvasManager _canvasManager;
    [SerializeField] Button btnBackInfoVegetals, btnInfoVegetal1, btnInfoVegetal2, btnInfoVegetal3, btnInfoVegetal4, btnInfoVegetal5;
    [SerializeField] GameObject _cardInfoVegetals, _cardInfoVegetal1, _cardInfoVegetal2, _cardInfoVegetal3, _cardInfoVegetal4, _cardInfoVegetal5;
    void Start()
    {
        _cardInfoVegetals.SetActive(false);
    }
    void Awake()
    {
        btnBackInfoVegetals.onClick.AddListener(() => _canvasManager.CloseInfo());
        btnInfoVegetal1.onClick.AddListener(() => _canvasManager.InfoVegetal1());
        btnInfoVegetal2.onClick.AddListener(() => _canvasManager.InfoVegetal2());
        btnInfoVegetal3.onClick.AddListener(() => _canvasManager.InfoVegetal3());
        btnInfoVegetal4.onClick.AddListener(() => _canvasManager.InfoVegetal4());
        btnInfoVegetal5.onClick.AddListener(() => _canvasManager.InfoVegetal5());
    }
    public void Configure(CanvasManager canvasManager)
    {
        _canvasManager = canvasManager;
    }
    public void Show()
    {
        _cardInfoVegetals.SetActive(true);
    }
    public void Hide()
    {
        _cardInfoVegetals.SetActive(false);
    }
    public void ThisInfoVegetal1()
    {
        Show();
        _cardInfoVegetal1.SetActive(true);
        _cardInfoVegetal2.SetActive(false);
        _cardInfoVegetal3.SetActive(false);
        _cardInfoVegetal4.SetActive(false);
        _cardInfoVegetal5.SetActive(false);
    }
    public void ThisInfoVegetal2()
    {
        Show();
        _cardInfoVegetal1.SetActive(false);
        _cardInfoVegetal2.SetActive(true);
        _cardInfoVegetal3.SetActive(false);
        _cardInfoVegetal4.SetActive(false);
        _cardInfoVegetal5.SetActive(false);
    }
    public void ThisInfoVegetal3()
    {
        Show();
        _cardInfoVegetal1.SetActive(false);
        _cardInfoVegetal2.SetActive(false);
        _cardInfoVegetal3.SetActive(true);
        _cardInfoVegetal4.SetActive(false);
        _cardInfoVegetal5.SetActive(false);
    }
    public void ThisInfoVegetal4()
    {
        Show();
        _cardInfoVegetal1.SetActive(false);
        _cardInfoVegetal2.SetActive(false);
        _cardInfoVegetal3.SetActive(false);
        _cardInfoVegetal4.SetActive(true);
        _cardInfoVegetal5.SetActive(false);
    }
    public void ThisInfoVegetal5()
    {
        Show();
        _cardInfoVegetal1.SetActive(false);
        _cardInfoVegetal2.SetActive(false);
        _cardInfoVegetal3.SetActive(false);
        _cardInfoVegetal4.SetActive(false);
        _cardInfoVegetal5.SetActive(true);
    }
}