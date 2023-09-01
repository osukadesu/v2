using UnityEngine;
using UnityEngine.UI;
public class CardCraftingMonera : MonoBehaviour
{
    [SerializeField] CanvasManager _canvasManager;
    [SerializeField] Button btnBackCraftMoneras, btnViewMonera1, btnViewMonera2, btnViewMonera3, btnViewMonera4, btnViewMonera5;
    [SerializeField] GameObject _cardCraftingMoneras, _cardCraftingMonera1, _cardCraftingMonera2, _cardCraftingMonera3, _cardCraftingMonera4, _cardCraftingMonera5;
    void Start()
    {
        _cardCraftingMoneras.SetActive(false);
    }
    void Awake()
    {
        btnBackCraftMoneras.onClick.AddListener(() => _canvasManager.CloseCraft());
        btnViewMonera1.onClick.AddListener(() => _canvasManager.ViewMonera1());
        btnViewMonera2.onClick.AddListener(() => _canvasManager.ViewMonera2());
        btnViewMonera3.onClick.AddListener(() => _canvasManager.ViewMonera3());
        btnViewMonera4.onClick.AddListener(() => _canvasManager.ViewMonera4());
        btnViewMonera5.onClick.AddListener(() => _canvasManager.ViewMonera5());
    }
    public void Configure(CanvasManager canvasManager)
    {
        _canvasManager = canvasManager;
    }
    public void Show()
    {
        _cardCraftingMoneras.SetActive(true);
    }
    public void Hide()
    {
        _cardCraftingMoneras.SetActive(false);
    }
    public void ThisViewMonera1()
    {
        Show();
        _cardCraftingMonera1.SetActive(true);
        _cardCraftingMonera2.SetActive(false);
        _cardCraftingMonera3.SetActive(false);
        _cardCraftingMonera4.SetActive(false);
        _cardCraftingMonera5.SetActive(false);
    }
    public void ThisViewMonera2()
    {
        Show();
        _cardCraftingMonera1.SetActive(false);
        _cardCraftingMonera2.SetActive(true);
        _cardCraftingMonera3.SetActive(false);
        _cardCraftingMonera4.SetActive(false);
        _cardCraftingMonera5.SetActive(false);
    }
    public void ThisViewMonera3()
    {
        Show();
        _cardCraftingMonera1.SetActive(false);
        _cardCraftingMonera2.SetActive(false);
        _cardCraftingMonera3.SetActive(true);
        _cardCraftingMonera4.SetActive(false);
        _cardCraftingMonera5.SetActive(false);
    }
    public void ThisViewMonera4()
    {
        Show();
        _cardCraftingMonera1.SetActive(false);
        _cardCraftingMonera2.SetActive(false);
        _cardCraftingMonera3.SetActive(false);
        _cardCraftingMonera4.SetActive(true);
        _cardCraftingMonera5.SetActive(false);
    }
    public void ThisViewMonera5()
    {
        Show();
        _cardCraftingMonera1.SetActive(false);
        _cardCraftingMonera2.SetActive(false);
        _cardCraftingMonera3.SetActive(false);
        _cardCraftingMonera4.SetActive(false);
        _cardCraftingMonera5.SetActive(true);
    }
}
