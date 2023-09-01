using UnityEngine;
using UnityEngine.UI;
public class CraftingAnimal1 : MonoBehaviour
{
    [SerializeField] CardCraftingAnimals cardCraftingAnimals;
    [SerializeField] CanvasManager _canvasManager;
    [SerializeField] InventoryItemData animal1T1, animal1T2, animal1T3, animal1T4, animal1T5;
    [SerializeField] bool canUnlockAnimal1, isCreatedAnimal1;
    [SerializeField] Button btnBuildAnimal1, btnItemCraft;
    [SerializeField] Animator animCheckAnimal1, animInfoAnimal1, animFillImgItem, animLock, animUnLock, animFillICA2;
    public void Configure(CanvasManager canvasManager)
    {
        _canvasManager = canvasManager;
    }
    void Start()
    {
        isCreatedAnimal1 = false;
        canUnlockAnimal1 = false;
        btnBuildAnimal1.interactable = false;
        btnItemCraft.interactable = true;
        animFillImgItem.SetBool("fillimgitem", false);
        animFillICA2.SetBool("fillitemcraft", false);
        animLock.SetBool("itemlock", false);
        animUnLock.SetBool("itemunlock", false);
    }
    void Awake()
    {
        btnBuildAnimal1.onClick.AddListener(() => _canvasManager.ButtonBuildAnimal1());
    }
    void Update()
    {
        UnlockAnimal1();
    }
    public void UnlockAnimal1()
    {
        if (animal1T1.itemIsCheck && animal1T2.itemIsCheck && animal1T3.itemIsCheck && animal1T4.itemIsCheck && animal1T5.itemIsCheck)
        {
            btnBuildAnimal1.interactable = true;
            canUnlockAnimal1 = true;
        }
        else
        {
            btnBuildAnimal1.interactable = false;
            canUnlockAnimal1 = false;
        }
    }
    public void MyButtonBuildAnimal1()
    {
        cardCraftingAnimals.Hide();
        btnBuildAnimal1.interactable = false;
        btnItemCraft.interactable = false;
        animCheckAnimal1.SetBool("check", true);
        animInfoAnimal1.SetBool("btninfoview", true);
        animFillImgItem.SetBool("fillimgitem", true);
        canUnlockAnimal1 = false;
        isCreatedAnimal1 = true;
        animFillICA2.SetBool("fillitemcraft", true);
        animLock.SetBool("itemlock", true);
        animUnLock.SetBool("itemunlock", true);
    }
}