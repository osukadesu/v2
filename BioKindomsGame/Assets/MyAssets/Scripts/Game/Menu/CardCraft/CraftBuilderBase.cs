using UnityEngine;
using UnityEngine.UI;

public abstract class CraftBuilderBase : MonoBehaviour
{
    [SerializeField] protected CanvasManager _canvasManager;
    [SerializeField] protected Button btnBuilder, btnItemCraft;
    [SerializeField] protected bool isCreated;
    [SerializeField] protected Animator animCheck, animInfo, animFillImgItem, animUnLock;
    [SerializeField] protected InventoryItemData[] _inventoryItemDatas;
    public void Configure(CanvasManager canvasManager)
    {
        _canvasManager = canvasManager;
    }
    void Update()
    {
        UnlockBuild();
    }
    protected internal abstract void UnlockBuild();
    protected internal abstract void ButtonBuild();
}