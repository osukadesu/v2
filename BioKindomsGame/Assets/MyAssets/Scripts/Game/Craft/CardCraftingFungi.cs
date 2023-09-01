using UnityEngine;
using UnityEngine.UI;
public class CardCraftingFungi : MonoBehaviour
{
    [SerializeField] CanvasManager _canvasManager;
    [SerializeField] Button btnBackCraftFungis, btnViewFungi1, btnViewFungi2, btnViewFungi3, btnViewFungi4, btnViewFungi5;
    [SerializeField] GameObject _cardCraftingFungis, _cardCraftingFungi1, _cardCraftingFungi2, _cardCraftingFungi3, _cardCraftingFungi4, _cardCraftingFungi5;
    void Start()
    {
        _cardCraftingFungis.SetActive(false);
    }
    void Awake()
    {
        btnBackCraftFungis.onClick.AddListener(() => _canvasManager.CloseCraft());
        btnViewFungi1.onClick.AddListener(() => _canvasManager.ViewFungi1());
        btnViewFungi2.onClick.AddListener(() => _canvasManager.ViewFungi2());
        btnViewFungi3.onClick.AddListener(() => _canvasManager.ViewFungi3());
        btnViewFungi4.onClick.AddListener(() => _canvasManager.ViewFungi4());
        btnViewFungi5.onClick.AddListener(() => _canvasManager.ViewFungi5());
    }
    public void Configure(CanvasManager canvasManager)
    {
        _canvasManager = canvasManager;
    }
    public void Show()
    {
        _cardCraftingFungis.SetActive(true);
    }
    public void Hide()
    {
        _cardCraftingFungis.SetActive(false);
    }
    public void ThisViewFungi1()
    {
        Show();
        _cardCraftingFungi1.SetActive(true);
        _cardCraftingFungi2.SetActive(false);
        _cardCraftingFungi3.SetActive(false);
        _cardCraftingFungi4.SetActive(false);
        _cardCraftingFungi5.SetActive(false);
    }
    public void ThisViewFungi2()
    {
        Show();
        _cardCraftingFungi1.SetActive(false);
        _cardCraftingFungi2.SetActive(true);
        _cardCraftingFungi3.SetActive(false);
        _cardCraftingFungi4.SetActive(false);
        _cardCraftingFungi5.SetActive(false);
    }
    public void ThisViewFungi3()
    {
        Show();
        _cardCraftingFungi1.SetActive(false);
        _cardCraftingFungi2.SetActive(false);
        _cardCraftingFungi3.SetActive(true);
        _cardCraftingFungi4.SetActive(false);
        _cardCraftingFungi5.SetActive(false);
    }
    public void ThisViewFungi4()
    {
        Show();
        _cardCraftingFungi1.SetActive(false);
        _cardCraftingFungi2.SetActive(false);
        _cardCraftingFungi3.SetActive(false);
        _cardCraftingFungi4.SetActive(true);
        _cardCraftingFungi5.SetActive(false);
    }
    public void ThisViewFungi5()
    {
        Show();
        _cardCraftingFungi1.SetActive(false);
        _cardCraftingFungi2.SetActive(false);
        _cardCraftingFungi3.SetActive(false);
        _cardCraftingFungi4.SetActive(false);
        _cardCraftingFungi5.SetActive(true);
    }
}