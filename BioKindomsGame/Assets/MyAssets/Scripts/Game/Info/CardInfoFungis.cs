using UnityEngine;
using UnityEngine.UI;
public class CardInfoFungis : MonoBehaviour
{
    [SerializeField] CanvasManager _canvasManager;
    [SerializeField] Button btnBackInfoFungis, btnInfoFungi1, btnInfoFungi2, btnInfoFungi3, btnInfoFungi4, btnInfoFungi5;
    [SerializeField] GameObject _cardInfoFungis, _cardInfoFungi1, _cardInfoFungi2, _cardInfoFungi3, _cardInfoFungi4, _cardInfoFungi5;
    void Start()
    {
        _cardInfoFungis.SetActive(false);
    }
    void Awake()
    {
        btnBackInfoFungis.onClick.AddListener(() => _canvasManager.CloseInfo());
        btnInfoFungi1.onClick.AddListener(() => _canvasManager.InfoFungi1());
        btnInfoFungi2.onClick.AddListener(() => _canvasManager.InfoFungi2());
        btnInfoFungi3.onClick.AddListener(() => _canvasManager.InfoFungi3());
        btnInfoFungi4.onClick.AddListener(() => _canvasManager.InfoFungi4());
        btnInfoFungi5.onClick.AddListener(() => _canvasManager.InfoFungi5());
    }
    public void Configure(CanvasManager canvasManager)
    {
        _canvasManager = canvasManager;
    }
    public void Show()
    {
        _cardInfoFungis.SetActive(true);
    }
    public void Hide()
    {
        _cardInfoFungis.SetActive(false);
    }
    public void ThisInfoFungi1()
    {
        Show();
        _cardInfoFungi1.SetActive(true);
        _cardInfoFungi2.SetActive(false);
        _cardInfoFungi3.SetActive(false);
        _cardInfoFungi4.SetActive(false);
        _cardInfoFungi5.SetActive(false);
    }
    public void ThisInfoFungi2()
    {
        Show();
        _cardInfoFungi1.SetActive(false);
        _cardInfoFungi2.SetActive(true);
        _cardInfoFungi3.SetActive(false);
        _cardInfoFungi4.SetActive(false);
        _cardInfoFungi5.SetActive(false);
    }
    public void ThisInfoFungi3()
    {
        Show();
        _cardInfoFungi1.SetActive(false);
        _cardInfoFungi2.SetActive(false);
        _cardInfoFungi3.SetActive(true);
        _cardInfoFungi4.SetActive(false);
        _cardInfoFungi5.SetActive(false);
    }
    public void ThisInfoFungi4()
    {
        Show();
        _cardInfoFungi1.SetActive(false);
        _cardInfoFungi2.SetActive(false);
        _cardInfoFungi3.SetActive(false);
        _cardInfoFungi4.SetActive(true);
        _cardInfoFungi5.SetActive(false);
    }
    public void ThisInfoFungi5()
    {
        Show();
        _cardInfoFungi1.SetActive(false);
        _cardInfoFungi2.SetActive(false);
        _cardInfoFungi3.SetActive(false);
        _cardInfoFungi4.SetActive(false);
        _cardInfoFungi5.SetActive(true);
    }
}