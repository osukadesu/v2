using UnityEngine;
using UnityEngine.UI;
public class CardCraftingProtista : MonoBehaviour
{
    [SerializeField] CanvasManager _canvasManager;
    [SerializeField] Button btnBackCraftProtistas, btnViewProtista1, btnViewProtista2, btnViewProtista3, btnViewProtista4, btnViewProtista5;
    [SerializeField] GameObject _cardCraftingProtistas, _cardCraftingProtista1, _cardCraftingProtista2, _cardCraftingProtista3, _cardCraftingProtista4, _cardCraftingProtista5;
    void Start()
    {
        _cardCraftingProtistas.SetActive(false);
    }
    void Awake()
    {
        btnBackCraftProtistas.onClick.AddListener(() => _canvasManager.CloseCraft());
        btnViewProtista1.onClick.AddListener(() => _canvasManager.ViewProtista1());
        btnViewProtista2.onClick.AddListener(() => _canvasManager.ViewProtista2());
        btnViewProtista3.onClick.AddListener(() => _canvasManager.ViewProtista3());
        btnViewProtista4.onClick.AddListener(() => _canvasManager.ViewProtista4());
        btnViewProtista5.onClick.AddListener(() => _canvasManager.ViewProtista5());
    }
    public void Configure(CanvasManager canvasManager)
    {
        _canvasManager = canvasManager;
    }
    public void Show()
    {
        _cardCraftingProtistas.SetActive(true);
    }
    public void Hide()
    {
        _cardCraftingProtistas.SetActive(false);
    }
    public void ThisViewProtista1()
    {
        Show();
        _cardCraftingProtista1.SetActive(true);
        _cardCraftingProtista2.SetActive(false);
        _cardCraftingProtista3.SetActive(false);
        _cardCraftingProtista4.SetActive(false);
        _cardCraftingProtista5.SetActive(false);
    }
    public void ThisViewProtista2()
    {
        Show();
        _cardCraftingProtista1.SetActive(false);
        _cardCraftingProtista2.SetActive(true);
        _cardCraftingProtista3.SetActive(false);
        _cardCraftingProtista4.SetActive(false);
        _cardCraftingProtista5.SetActive(false);
    }
    public void ThisViewProtista3()
    {
        Show();
        _cardCraftingProtista1.SetActive(false);
        _cardCraftingProtista2.SetActive(false);
        _cardCraftingProtista3.SetActive(true);
        _cardCraftingProtista4.SetActive(false);
        _cardCraftingProtista5.SetActive(false);
    }
    public void ThisViewProtista4()
    {
        Show();
        _cardCraftingProtista1.SetActive(false);
        _cardCraftingProtista2.SetActive(false);
        _cardCraftingProtista3.SetActive(false);
        _cardCraftingProtista4.SetActive(true);
        _cardCraftingProtista5.SetActive(false);
    }
    public void ThisViewProtista5()
    {
        Show();
        _cardCraftingProtista1.SetActive(false);
        _cardCraftingProtista2.SetActive(false);
        _cardCraftingProtista3.SetActive(false);
        _cardCraftingProtista4.SetActive(false);
        _cardCraftingProtista5.SetActive(true);
    }
}
