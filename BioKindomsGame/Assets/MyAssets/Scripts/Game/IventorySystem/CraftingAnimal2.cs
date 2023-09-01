using UnityEngine;
using UnityEngine.UI;
public class CraftingAnimal2 : MonoBehaviour
{
    [SerializeField] CardCraftingAnimals cardCraftingAnimals;
    [SerializeField] CanvasManager _canvasManager;
    [SerializeField] InventoryItemData animal2T1, animal2T2, animal2T3, animal2T4, animal2T5;
    [SerializeField] bool canUnlockAnimal2, isCreatedAnimal2;
    [SerializeField] Button btnBuildAnimal2, btnItemCraft;
    [SerializeField] Animator animCheckanimal2, animInfoanimal2, animFillImgItem, animLock, animUnLock, animFillICA3;
    public void Configure(CanvasManager canvasManager)
    {
        _canvasManager = canvasManager;
    }
    void Start()
    {
        isCreatedAnimal2 = false;
        canUnlockAnimal2 = false;
        btnBuildAnimal2.interactable = false;
        btnItemCraft.interactable = true;
        animFillImgItem.SetBool("fillimgitem", false);
        animFillICA3.SetBool("fillitemcraft", false);
        animLock.SetBool("itemlock", false);
        animUnLock.SetBool("itemunlock", false);
    }
    void Awake()
    {
        btnBuildAnimal2.onClick.AddListener(() => _canvasManager.ButtonBuildAnimal2());
    }
    void Update()
    {
        Unlockanimal2();
    }
    public void Unlockanimal2()
    {
        if (animal2T1.itemIsCheck && animal2T2.itemIsCheck && animal2T3.itemIsCheck && animal2T4.itemIsCheck && animal2T5.itemIsCheck)
        {
            btnBuildAnimal2.interactable = true;
            canUnlockAnimal2 = true;
        }
        else
        {
            btnBuildAnimal2.interactable = false;
            canUnlockAnimal2 = false;
        }
    }
    public void MyButtonBuildAnimal2()
    {
        cardCraftingAnimals.Hide();
        btnBuildAnimal2.interactable = false;
        btnItemCraft.interactable = false;
        animCheckanimal2.SetBool("check", true);
        animInfoanimal2.SetBool("btninfoview", true);
        animFillImgItem.SetBool("fillimgitem", true);
        canUnlockAnimal2 = false;
        isCreatedAnimal2 = true;
        animFillICA3.SetBool("fillitemcraft", true);
        animLock.SetBool("itemlock", true);
        animUnLock.SetBool("itemunlock", true);
    }
}