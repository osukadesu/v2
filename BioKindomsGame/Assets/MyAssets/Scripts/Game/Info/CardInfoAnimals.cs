using UnityEngine;
using UnityEngine.UI;
public class CardInfoAnimals : MonoBehaviour
{
    [SerializeField] CanvasManager _canvasManager;
    [SerializeField] Button btnBackInfoAnimals, btnInfoAnimal1, btnInfoAnimal2, btnInfoAnimal3, btnInfoAnimal4, btnInfoAnimal5;
    [SerializeField] GameObject _cardInfoAnimals, _cardInfoAnimal1, _cardInfoAnimal2, _cardInfoAnimal3, _cardInfoAnimal4, _cardInfoAnimal5;
    void Start()
    {
        _cardInfoAnimals.SetActive(false);
    }
    void Awake()
    {
        btnBackInfoAnimals.onClick.AddListener(() => _canvasManager.CloseInfo());
        btnInfoAnimal1.onClick.AddListener(() => _canvasManager.InfoAnimal1());
        btnInfoAnimal2.onClick.AddListener(() => _canvasManager.InfoAnimal2());
        btnInfoAnimal3.onClick.AddListener(() => _canvasManager.InfoAnimal3());
        btnInfoAnimal4.onClick.AddListener(() => _canvasManager.InfoAnimal4());
        btnInfoAnimal5.onClick.AddListener(() => _canvasManager.InfoAnimal5());
    }
    public void Configure(CanvasManager canvasManager)
    {
        _canvasManager = canvasManager;
    }
    public void Show()
    {
        _cardInfoAnimals.SetActive(true);
    }
    public void Hide()
    {
        _cardInfoAnimals.SetActive(false);
    }
    public void ThisInfoAnimal1()
    {
        Show();
        _cardInfoAnimal1.SetActive(true);
        _cardInfoAnimal2.SetActive(false);
        _cardInfoAnimal3.SetActive(false);
        _cardInfoAnimal4.SetActive(false);
        _cardInfoAnimal5.SetActive(false);
    }
    public void ThisInfoAnimal2()
    {
        Show();
        _cardInfoAnimal1.SetActive(false);
        _cardInfoAnimal2.SetActive(true);
        _cardInfoAnimal3.SetActive(false);
        _cardInfoAnimal4.SetActive(false);
        _cardInfoAnimal5.SetActive(false);
    }
    public void ThisInfoAnimal3()
    {
        Show();
        _cardInfoAnimal1.SetActive(false);
        _cardInfoAnimal2.SetActive(false);
        _cardInfoAnimal3.SetActive(true);
        _cardInfoAnimal4.SetActive(false);
        _cardInfoAnimal5.SetActive(false);
    }
    public void ThisInfoAnimal4()
    {
        Show();
        _cardInfoAnimal1.SetActive(false);
        _cardInfoAnimal2.SetActive(false);
        _cardInfoAnimal3.SetActive(false);
        _cardInfoAnimal4.SetActive(true);
        _cardInfoAnimal5.SetActive(false);
    }
    public void ThisInfoAnimal5()
    {
        Show();
        _cardInfoAnimal1.SetActive(false);
        _cardInfoAnimal2.SetActive(false);
        _cardInfoAnimal3.SetActive(false);
        _cardInfoAnimal4.SetActive(false);
        _cardInfoAnimal5.SetActive(true);
    }
}