using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class CardCraftingContent : MonoBehaviour
{
    [SerializeField] CanvasManager _canvasManager;
    [SerializeField] Button[] buttonCraftView;
    [SerializeField] Button btnBackCraft;
    [SerializeField] CanvasGroup[] canvasGroup;
    void Start()
    {
        Hide();
    }
    void Awake()
    {
        btnBackCraft.onClick.AddListener(() => _canvasManager.BackCraft());
        buttonCraftView[0].onClick.AddListener(() => _canvasManager.ViewAnimal1());
        buttonCraftView[1].onClick.AddListener(() => _canvasManager.ViewAnimal2());
        buttonCraftView[2].onClick.AddListener(() => _canvasManager.ViewAnimal3());
        buttonCraftView[3].onClick.AddListener(() => _canvasManager.ViewAnimal4());
        buttonCraftView[4].onClick.AddListener(() => _canvasManager.ViewAnimal5());
        buttonCraftView[5].onClick.AddListener(() => _canvasManager.ViewVegetal1());
    }
    public void Configure(CanvasManager canvasManager)
    {
        _canvasManager = canvasManager;
    }
    public void Show()
    {
        canvasGroup[5].alpha = 1; canvasGroup[5].interactable = true; canvasGroup[5].blocksRaycasts = true;
    }
    public void Hide()
    {
        canvasGroup[5].alpha = 0; canvasGroup[5].interactable = false; canvasGroup[5].blocksRaycasts = false;
        canvasGroup[0].alpha = 0; canvasGroup[0].interactable = false; canvasGroup[0].blocksRaycasts = false;
        canvasGroup[1].alpha = 0; canvasGroup[1].interactable = false; canvasGroup[1].blocksRaycasts = false;
        canvasGroup[2].alpha = 0; canvasGroup[2].interactable = false; canvasGroup[2].blocksRaycasts = false;
        canvasGroup[3].alpha = 0; canvasGroup[3].interactable = false; canvasGroup[3].blocksRaycasts = false;
        canvasGroup[4].alpha = 0; canvasGroup[4].interactable = false; canvasGroup[4].blocksRaycasts = false;
        canvasGroup[6].alpha = 0; canvasGroup[6].interactable = false; canvasGroup[6].blocksRaycasts = false;
    }
    public void SetCrafting()
    {
        switch (_canvasManager.CraftinCode)
        {
            case 1:
                Show();
                canvasGroup[0].alpha = 1; canvasGroup[0].interactable = true; canvasGroup[0].blocksRaycasts = true;
                break;
            case 2:
                Show();
                canvasGroup[1].alpha = 1; canvasGroup[1].interactable = true; canvasGroup[1].blocksRaycasts = true;
                break;
            case 3:
                Show();
                canvasGroup[2].alpha = 1; canvasGroup[2].interactable = true; canvasGroup[2].blocksRaycasts = true;
                break;
            case 4:
                Show();
                canvasGroup[3].alpha = 1; canvasGroup[3].interactable = true; canvasGroup[3].blocksRaycasts = true;
                break;
            case 5:
                Show();
                canvasGroup[4].alpha = 1; canvasGroup[4].interactable = true; canvasGroup[4].blocksRaycasts = true;
                break;
            case 6:
                Show();
                canvasGroup[6].alpha = 1; canvasGroup[6].interactable = true; canvasGroup[6].blocksRaycasts = true;
                break;
            case 26:
                Hide();
                break;
            default:
                Hide();
                break;
        }
    }
}
