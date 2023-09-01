using UnityEngine;
using UnityEngine.UI;
public class CardCraftingVegetals : MonoBehaviour
{
    [SerializeField] CanvasManager _canvasManager;
    [SerializeField] Button btnBackCraftVegetals, btnViewVegetal1, btnViewVegetal2, btnViewVegetal3, btnViewVegetal4, btnViewVegetal5;
    [SerializeField] GameObject _cardCraftingVegetals, _cardCraftingVegetal1, _cardCraftingVegetal2, _cardCraftingVegetal3, _cardCraftingVegetal4, _cardCraftingVegetal5;
    void Start()
    {
        _cardCraftingVegetals.SetActive(false);
    }
    void Awake()
    {
        btnBackCraftVegetals.onClick.AddListener(() => _canvasManager.CloseCraft());
        btnViewVegetal1.onClick.AddListener(() => _canvasManager.ViewVegetal1());
        btnViewVegetal2.onClick.AddListener(() => _canvasManager.ViewVegetal2());
        btnViewVegetal3.onClick.AddListener(() => _canvasManager.ViewVegetal3());
        btnViewVegetal4.onClick.AddListener(() => _canvasManager.ViewVegetal4());
        btnViewVegetal5.onClick.AddListener(() => _canvasManager.ViewVegetal5());
    }
    public void Configure(CanvasManager canvasManager)
    {
        _canvasManager = canvasManager;
    }
    public void Show()
    {
        _cardCraftingVegetals.SetActive(true);
    }
    public void Hide()
    {
        _cardCraftingVegetals.SetActive(false);
    }
    public void ThisViewVegetal1()
    {
        Show();
        _cardCraftingVegetal1.SetActive(true);
        _cardCraftingVegetal2.SetActive(false);
        _cardCraftingVegetal3.SetActive(false);
        _cardCraftingVegetal4.SetActive(false);
        _cardCraftingVegetal5.SetActive(false);
    }
    public void ThisViewVegetal2()
    {
        Show();
        _cardCraftingVegetal1.SetActive(false);
        _cardCraftingVegetal2.SetActive(true);
        _cardCraftingVegetal3.SetActive(false);
        _cardCraftingVegetal4.SetActive(false);
        _cardCraftingVegetal5.SetActive(false);
    }
    public void ThisViewVegetal3()
    {
        Show();
        _cardCraftingVegetal1.SetActive(false);
        _cardCraftingVegetal2.SetActive(false);
        _cardCraftingVegetal3.SetActive(true);
        _cardCraftingVegetal4.SetActive(false);
        _cardCraftingVegetal5.SetActive(false);
    }
    public void ThisViewVegetal4()
    {
        Show();
        _cardCraftingVegetal1.SetActive(false);
        _cardCraftingVegetal2.SetActive(false);
        _cardCraftingVegetal3.SetActive(false);
        _cardCraftingVegetal4.SetActive(true);
        _cardCraftingVegetal5.SetActive(false);
    }
    public void ThisViewVegetal5()
    {
        Show();
        _cardCraftingVegetal1.SetActive(false);
        _cardCraftingVegetal2.SetActive(false);
        _cardCraftingVegetal3.SetActive(false);
        _cardCraftingVegetal4.SetActive(false);
        _cardCraftingVegetal5.SetActive(true);
    }
}