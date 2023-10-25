using System;
using UnityEngine;
public class CanvasManager : MonoBehaviour
{
    [SerializeField] ViewMenu _viewMenu;
    [SerializeField] CardMenu _cardMenu;
    [SerializeField] CardCraftingContent _cardCraftingContent;
    [SerializeField] InfoContent _infoContent;
    [SerializeField] CraftAnimal1 _craftAnimal1;
    [SerializeField] CraftAnimal2 _craftAnimal2;
    [SerializeField] CraftAnimal3 _craftAnimal3;
    [SerializeField] CraftAnimal4 _craftAnimal4;
    [SerializeField] CraftAnimal5 _craftAnimal5;
    [SerializeField] int menuCode, infoCodes, craftinCode, buildCode;
    public int MenuCode { get { return menuCode; } set { menuCode = value; } }
    public int InfoCode { get { return infoCodes; } set { infoCodes = value; } }
    public int CraftinCode { get { return craftinCode; } set { craftinCode = value; } }
    public int BuildCode { get { return buildCode; } set { buildCode = value; } }
    void Awake()
    {
        _viewMenu.Configure(this);
        _cardMenu.Configure(this);
        _infoContent.Configure(this);
        _cardCraftingContent.Configure(this);
        _craftAnimal1.Configure(this);
        _craftAnimal2.Configure(this);
        _craftAnimal3.Configure(this);
        _craftAnimal4.Configure(this);
        _craftAnimal5.Configure(this);
        ClosingAll();
    }
    public void ButtonGoAnimalV2()
    {
        menuCode = 1;
        _cardMenu.SetContent();
    }
    public void ButtonGoAnimal()
    {
        menuCode = 1;
        _cardMenu.SetContent();
        infoCodes = 26;
        _infoContent.SetInfo();
        craftinCode = 26;
        _cardCraftingContent.SetCrafting();
        ClosingAll();
    }
    public void ButtonGoVegetal()
    {
        menuCode = 2;
        _cardMenu.SetContent();
        infoCodes = 26;
        _infoContent.SetInfo();
        craftinCode = 26;
        _cardCraftingContent.SetCrafting();
        ClosingAll();
    }
    public void ButtonGoFungi()
    {
        menuCode = 3;
        _cardMenu.SetContent();
        infoCodes = 26;
        _infoContent.SetInfo();
        craftinCode = 26;
        _cardCraftingContent.SetCrafting();
        ClosingAll();
    }
    public void ButtonGoProtista()
    {
        menuCode = 4;
        _cardMenu.SetContent();
        infoCodes = 26;
        _infoContent.SetInfo();
        craftinCode = 26;
        _cardCraftingContent.SetCrafting();
        ClosingAll();
    }
    public void ButtonGoMonera()
    {
        menuCode = 5;
        _cardMenu.SetContent();
        infoCodes = 26;
        _infoContent.SetInfo();
        craftinCode = 26;
        _cardCraftingContent.SetCrafting();
        ClosingAll();
    }
    public void CraftAnimal1()
    {
        craftinCode = 26;
        _cardCraftingContent.SetCrafting();
        _craftAnimal1.ButtonBuild();
        ButtonGoAnimalV2();
    }
    public void CraftAnimal2()
    {
        craftinCode = 26;
        _cardCraftingContent.SetCrafting();
        _craftAnimal2.ButtonBuild();
        ButtonGoAnimalV2();
    }
    public void CraftAnimal3()
    {
        craftinCode = 26;
        _cardCraftingContent.SetCrafting();
        _craftAnimal3.ButtonBuild();
        ButtonGoAnimalV2();
    }
    public void CraftAnimal4()
    {
        craftinCode = 26;
        _cardCraftingContent.SetCrafting();
        _craftAnimal4.ButtonBuild();
        ButtonGoAnimalV2();
    }
    public void CraftAnimal5()
    {
        craftinCode = 26;
        _cardCraftingContent.SetCrafting();
        _craftAnimal5.ButtonBuild();
        ButtonGoAnimalV2();
    }
    public void ButtonContentClose()
    {
        // return topCode = 0;
    }
    public void CloseInfo()
    {
        infoCodes = 26;
        _infoContent.SetInfo();
        menuCode = 1;
        _cardMenu.SetContent();
    }

    public void TabViewMenu()
    {
        _viewMenu.TabVieW();
    }
    public void ButtonCloseTab()
    {
        _viewMenu.CloseTabView();
        infoCodes = 26;
        _infoContent.SetInfo();
    }
    public void CloseTabViewv2()
    {
        infoCodes = 26;
        _infoContent.SetInfo();
    }
    public void BackCraft()
    {
        craftinCode = 26;
        _cardCraftingContent.SetCrafting();
        menuCode = 1;
        _cardMenu.SetContent();
    }
    public void ViewAnimal1()
    {
        craftinCode = 1;
        _cardCraftingContent.SetCrafting();
        menuCode = 6;
        _cardMenu.SetContent();
    }
    public void ViewAnimal2()
    {
        craftinCode = 2;
        _cardCraftingContent.SetCrafting();
        menuCode = 6;
        _cardMenu.SetContent();
    }
    public void ViewAnimal3()
    {
        craftinCode = 3;
        _cardCraftingContent.SetCrafting();
        menuCode = 6;
        _cardMenu.SetContent();
    }
    public void ViewAnimal4()
    {
        craftinCode = 4;
        _cardCraftingContent.SetCrafting();
        menuCode = 6;
        _cardMenu.SetContent();
    }
    public void ViewAnimal5()
    {
        craftinCode = 5;
        _cardCraftingContent.SetCrafting();
        menuCode = 6;
        _cardMenu.SetContent();
    }
    public void InfoAnimal1()
    {
        infoCodes = 1;
        _infoContent.SetInfo();
        menuCode = 6;
        _cardMenu.SetContent();
        craftinCode = 26;
        _cardCraftingContent.SetCrafting();

    }
    public void InfoAnimal2()
    {
        infoCodes = 2;
        _infoContent.SetInfo();
        menuCode = 6;
        _cardMenu.SetContent();
        craftinCode = 26;
        _cardCraftingContent.SetCrafting();
    }
    public void InfoAnimal3()
    {
        infoCodes = 3;
        _infoContent.SetInfo();
        menuCode = 6;
        _cardMenu.SetContent();
        craftinCode = 26;
        _cardCraftingContent.SetCrafting();
    }
    public void InfoAnimal4()
    {
        infoCodes = 4;
        _infoContent.SetInfo();
        menuCode = 6;
        _cardMenu.SetContent();
        craftinCode = 26;
        _cardCraftingContent.SetCrafting();
    }
    public void InfoAnimal5()
    {
        infoCodes = 5;
        _infoContent.SetInfo();
        menuCode = 6;
        _cardMenu.SetContent();
        craftinCode = 26;
        _cardCraftingContent.SetCrafting();
    }
    public void ViewVegetal1()
    {
        craftinCode = 6;
        _cardCraftingContent.SetCrafting();
        menuCode = 6;
        _cardMenu.SetContent();
    }
    public void ViewVegetal2()
    {
        //_cardCraftingVegetals.ThisViewVegetal2();
    }
    public void ViewVegetal3()
    {
        //_cardCraftingVegetals.ThisViewVegetal3();
    }
    public void ViewVegetal4()
    {
        //_cardCraftingVegetals.ThisViewVegetal4();
    }
    public void ViewVegetal5()
    {
        //_cardCraftingVegetals.ThisViewVegetal5();
    }
    public int InfoVegetal1()
    {
        //_infoContent.SetInfo();
        return infoCodes = 6;
    }
    public int InfoVegetal2()
    {
        //_infoContent.SetInfo();
        return infoCodes = 7;
    }
    public int InfoVegetal3()
    {
        //_infoContent.SetInfo();
        return infoCodes = 8;
    }
    public int InfoVegetal4()
    {
        //_infoContent.SetInfo();
        return infoCodes = 9;
    }
    public int InfoVegetal5()
    {
        //_infoContent.SetInfo();
        return infoCodes = 10;
    }
    public void ViewFungi1()
    {
        //_cardCraftingFungis.ThisViewFungi1();
    }
    public void ViewFungi2()
    {
        //_cardCraftingFungis.ThisViewFungi2();
    }
    public void ViewFungi3()
    {
        //_cardCraftingFungis.ThisViewFungi3();
    }
    public void ViewFungi4()
    {
        //_cardCraftingFungis.ThisViewFungi4();
    }
    public void ViewFungi5()
    {
        //_cardCraftingFungis.ThisViewFungi5();
    }
    public int InfoFungi1()
    {
        //_infoContent.SetInfo();
        return infoCodes = 11;
    }
    public int InfoFungi2()
    {
        //_infoContent.SetInfo();
        return infoCodes = 12;
    }
    public int InfoFungi3()
    {
        //_infoContent.SetInfo();
        return infoCodes = 13;
    }
    public int InfoFungi4()
    {
        //_infoContent.SetInfo();
        return infoCodes = 14;
    }
    public int InfoFungi5()
    {
        //_infoContent.SetInfo();
        return infoCodes = 15;
    }
    public void ViewProtista1()
    {
        //_cardCraftingProtistas.ThisViewProtista1();
    }
    public void ViewProtista2()
    {
        //_cardCraftingProtistas.ThisViewProtista2();
    }
    public void ViewProtista3()
    {
        //_cardCraftingProtistas.ThisViewProtista3();
    }
    public void ViewProtista4()
    {
        //_cardCraftingProtistas.ThisViewProtista4();
    }
    public void ViewProtista5()
    {
        //_cardCraftingProtistas.ThisViewProtista5();
    }
    public int InfoProtista1()
    {
        //_infoContent.SetInfo();
        return infoCodes = 16;
    }
    public int InfoProtista2()
    {
        //_infoContent.SetInfo();
        return infoCodes = 17;
    }
    public int InfoProtista3()
    {
        //_infoContent.SetInfo();
        return infoCodes = 18;
    }
    public int InfoProtista4()
    {
        //_infoContent.SetInfo();
        return infoCodes = 19;
    }
    public int InfoProtista5()
    {
        //_infoContent.SetInfo();
        return infoCodes = 20;
    }
    public void ViewMonera1()
    {
        //_cardCraftingMoneras.ThisViewMonera1();
    }
    public void ViewMonera2()
    {
        //_cardCraftingMoneras.ThisViewMonera2();
    }
    public void ViewMonera3()
    {
        //_cardCraftingMoneras.ThisViewMonera3();
    }
    public void ViewMonera4()
    {
        //_cardCraftingMoneras.ThisViewMonera4();
    }
    public void ViewMonera5()
    {
        //_cardCraftingMoneras.ThisViewMonera5();
    }
    public int InfoMonera1()
    {
        //_infoContent.SetInfo();
        return infoCodes = 21;
    }
    public int InfoMonera2()
    {
        //_infoContent.SetInfo();
        return infoCodes = 22;
    }
    public int InfoMonera3()
    {
        //_infoContent.SetInfo();
        return infoCodes = 23;
    }
    public int InfoMonera4()
    {
        //_infoContent.SetInfo();
        return infoCodes = 24;
    }
    public int InfoMonera5()
    {
        //_infoContent.SetInfo();
        return infoCodes = 25;
    }
    public void ClosingAll()
    {
        CloseCraft();
        CloseInfoV2();
    }
    private void CloseCraft()
    {
        craftinCode = 26;
        _cardCraftingContent.SetCrafting();
    }
    private void CloseInfoV2()
    {
        _infoContent.Hide();
    }
}