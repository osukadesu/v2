using UnityEngine;
using UnityEngine.UI;
public class CardCraftingAnimals : MonoBehaviour
{
    [SerializeField] CanvasManager _canvasManager;
    [SerializeField] Button btnBackCraftAnimals, btnViewAnimal1, btnViewAnimal2, btnViewAnimal3, btnViewAnimal4, btnViewAnimal5;
    [SerializeField] GameObject _cardCraftingAnimals, _cardCraftingAnimal1, _cardCraftingAnimal2, _cardCraftingAnimal3, _cardCraftingAnimal4, _cardCraftingAnimal5;
    void Start()
    {
        _cardCraftingAnimals.SetActive(false);
    }
    void Awake()
    {
        btnBackCraftAnimals.onClick.AddListener(() => _canvasManager.CloseCraft());
        btnViewAnimal1.onClick.AddListener(() => _canvasManager.ViewAnimal1());
        btnViewAnimal2.onClick.AddListener(() => _canvasManager.ViewAnimal2());
        btnViewAnimal3.onClick.AddListener(() => _canvasManager.ViewAnimal3());
        btnViewAnimal4.onClick.AddListener(() => _canvasManager.ViewAnimal4());
        btnViewAnimal5.onClick.AddListener(() => _canvasManager.ViewAnimal5());
    }
    public void Configure(CanvasManager canvasManager)
    {
        _canvasManager = canvasManager;
    }
    public void Show()
    {
        _cardCraftingAnimals.SetActive(true);
    }
    public void Hide()
    {
        _cardCraftingAnimals.SetActive(false);
    }
    public void ThisViewAnimal1()
    {
        Show();
        _cardCraftingAnimal1.SetActive(true);
        _cardCraftingAnimal2.SetActive(false);
        _cardCraftingAnimal3.SetActive(false);
        _cardCraftingAnimal4.SetActive(false);
        _cardCraftingAnimal5.SetActive(false);
    }
    public void ThisViewAnimal2()
    {
        Show();
        _cardCraftingAnimal1.SetActive(false);
        _cardCraftingAnimal2.SetActive(true);
        _cardCraftingAnimal3.SetActive(false);
        _cardCraftingAnimal4.SetActive(false);
        _cardCraftingAnimal5.SetActive(false);
    }
    public void ThisViewAnimal3()
    {
        Show();
        _cardCraftingAnimal1.SetActive(false);
        _cardCraftingAnimal2.SetActive(false);
        _cardCraftingAnimal3.SetActive(true);
        _cardCraftingAnimal4.SetActive(false);
        _cardCraftingAnimal5.SetActive(false);
    }
    public void ThisViewAnimal4()
    {
        Show();
        _cardCraftingAnimal1.SetActive(false);
        _cardCraftingAnimal2.SetActive(false);
        _cardCraftingAnimal3.SetActive(false);
        _cardCraftingAnimal4.SetActive(true);
        _cardCraftingAnimal5.SetActive(false);
    }
    public void ThisViewAnimal5()
    {
        Show();
        _cardCraftingAnimal1.SetActive(false);
        _cardCraftingAnimal2.SetActive(false);
        _cardCraftingAnimal3.SetActive(false);
        _cardCraftingAnimal4.SetActive(false);
        _cardCraftingAnimal5.SetActive(true);
    }
}