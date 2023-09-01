using UnityEngine;
public class CanvasManager : MonoBehaviour
{
    [SerializeField] MenuAnimationsAnimal _menuAnimationsAnimal;
    [SerializeField] MenuAnimationsVegetal _menuAnimationsVegetal;
    [SerializeField] MenuAnimationsFungi _menuAnimationsFungi;
    [SerializeField] MenuAnimationsProtista _menuAnimationsProtista;
    [SerializeField] MenuAnimationsMonera _menuAnimationsMonera;
    [SerializeField] FilmAnimationAnimal _filmAnimationsAnimal;
    [SerializeField] FilmAnimationVegetal _filmAnimationsVegetal;
    [SerializeField] FilmAnimationFungi _filmAnimationsFungi;
    [SerializeField] FilmAnimationProtista _filmAnimationsProtista;
    [SerializeField] FilmAnimationMonera _filmAnimationsMonera;
    [SerializeField] CardCraftingAnimals _cardCraftingAnimals;
    [SerializeField] CraftingAnimal1 _craftingAnimal1;
    [SerializeField] CraftingAnimal2 _craftingAnimal2;
    [SerializeField] CardCraftingVegetals _cardCraftingVegetals;
    [SerializeField] CardCraftingFungi _cardCraftingFungis;
    [SerializeField] CardCraftingProtista _cardCraftingProtistas;
    [SerializeField] CardCraftingMonera _cardCraftingMoneras;
    [SerializeField] CardInfoAnimals _cardInfoAnimals;
    [SerializeField] CardInfoVegetals _cardInfoVegetals;
    [SerializeField] CardInfoFungis _cardInfoFungis;
    [SerializeField] CardInfoProtistas _cardInfoProtistas;
    [SerializeField] CardInfoMoneras _cardInfoMoneras;
    [SerializeField] ViewMenu _viewMenu;
    void Awake()
    {
        _menuAnimationsAnimal.Configure(this);
        _menuAnimationsVegetal.Configure(this);
        _menuAnimationsFungi.Configure(this);
        _menuAnimationsProtista.Configure(this);
        _menuAnimationsMonera.Configure(this);
        _filmAnimationsAnimal.Configure(this);
        _filmAnimationsVegetal.Configure(this);
        _filmAnimationsFungi.Configure(this);
        _filmAnimationsProtista.Configure(this);
        _filmAnimationsMonera.Configure(this);
        _cardCraftingAnimals.Configure(this);
        _craftingAnimal1.Configure(this);
        _craftingAnimal2.Configure(this);
        _cardCraftingVegetals.Configure(this);
        _cardCraftingFungis.Configure(this);
        _cardCraftingProtistas.Configure(this);
        _cardCraftingMoneras.Configure(this);
        _cardInfoAnimals.Configure(this);
        _cardInfoVegetals.Configure(this);
        _cardInfoFungis.Configure(this);
        _cardInfoProtistas.Configure(this);
        _cardInfoMoneras.Configure(this);
        _viewMenu.Configure(this);
        ClosingAll();
    }
    public void CloseCraft()
    {
        _cardCraftingAnimals.Hide();
        _cardCraftingVegetals.Hide();
        _cardCraftingFungis.Hide();
        _cardCraftingProtistas.Hide();
        _cardCraftingMoneras.Hide();
    }
    public void CloseInfo()
    {
        _cardInfoAnimals.Hide();
        _cardInfoVegetals.Hide();
        _cardInfoFungis.Hide();
        _cardInfoProtistas.Hide();
        _cardInfoMoneras.Hide();
    }
    public void ButtonBuildAnimal1()
    {
        GoToAnimal();
        ClosingAll();
        _craftingAnimal1.MyButtonBuildAnimal1();
    }
    public void ButtonBuildAnimal2()
    {
        GoToAnimal();
        ClosingAll();
        _craftingAnimal2.MyButtonBuildAnimal2();
    }

    public void TabViewMenu()
    {
        _viewMenu.TabVieW();
    }
    public void ButtonCloseTab()
    {
        _viewMenu.CloseTabView();
    }
    public void ViewAnimal1()
    {
        _cardCraftingAnimals.ThisViewAnimal1();
    }
    public void ViewAnimal2()
    {
        _cardCraftingAnimals.ThisViewAnimal2();
    }
    public void ViewAnimal3()
    {
        _cardCraftingAnimals.ThisViewAnimal3();
    }
    public void ViewAnimal4()
    {
        _cardCraftingAnimals.ThisViewAnimal4();
    }
    public void ViewAnimal5()
    {
        _cardCraftingAnimals.ThisViewAnimal5();
    }
    public void InfoAnimal1()
    {
        _cardInfoAnimals.ThisInfoAnimal1();
    }
    public void InfoAnimal2()
    {
        _cardInfoAnimals.ThisInfoAnimal2();
    }
    public void InfoAnimal3()
    {
        _cardInfoAnimals.ThisInfoAnimal3();
    }
    public void InfoAnimal4()
    {
        _cardInfoAnimals.ThisInfoAnimal4();
    }
    public void InfoAnimal5()
    {
        _cardInfoAnimals.ThisInfoAnimal5();
    }
    public void ViewVegetal1()
    {
        _cardCraftingVegetals.ThisViewVegetal1();
    }
    public void ViewVegetal2()
    {
        _cardCraftingVegetals.ThisViewVegetal2();
    }
    public void ViewVegetal3()
    {
        _cardCraftingVegetals.ThisViewVegetal3();
    }
    public void ViewVegetal4()
    {
        _cardCraftingVegetals.ThisViewVegetal4();
    }
    public void ViewVegetal5()
    {
        _cardCraftingVegetals.ThisViewVegetal5();
    }
    public void InfoVegetal1()
    {
        _cardInfoVegetals.ThisInfoVegetal1();
    }
    public void InfoVegetal2()
    {
        _cardInfoVegetals.ThisInfoVegetal2();
    }
    public void InfoVegetal3()
    {
        _cardInfoVegetals.ThisInfoVegetal3();
    }
    public void InfoVegetal4()
    {
        _cardInfoVegetals.ThisInfoVegetal4();
    }
    public void InfoVegetal5()
    {
        _cardInfoVegetals.ThisInfoVegetal5();
    }
    public void ViewFungi1()
    {
        _cardCraftingFungis.ThisViewFungi1();
    }
    public void ViewFungi2()
    {
        _cardCraftingFungis.ThisViewFungi2();
    }
    public void ViewFungi3()
    {
        _cardCraftingFungis.ThisViewFungi3();
    }
    public void ViewFungi4()
    {
        _cardCraftingFungis.ThisViewFungi4();
    }
    public void ViewFungi5()
    {
        _cardCraftingFungis.ThisViewFungi5();
    }
    public void InfoFungi1()
    {
        _cardInfoFungis.ThisInfoFungi1();
    }
    public void InfoFungi2()
    {
        _cardInfoFungis.ThisInfoFungi2();
    }
    public void InfoFungi3()
    {
        _cardInfoFungis.ThisInfoFungi3();
    }
    public void InfoFungi4()
    {
        _cardInfoFungis.ThisInfoFungi4();
    }
    public void InfoFungi5()
    {
        _cardInfoFungis.ThisInfoFungi5();
    }
    public void ViewProtista1()
    {
        _cardCraftingProtistas.ThisViewProtista1();
    }
    public void ViewProtista2()
    {
        _cardCraftingProtistas.ThisViewProtista2();
    }
    public void ViewProtista3()
    {
        _cardCraftingProtistas.ThisViewProtista3();
    }
    public void ViewProtista4()
    {
        _cardCraftingProtistas.ThisViewProtista4();
    }
    public void ViewProtista5()
    {
        _cardCraftingProtistas.ThisViewProtista5();
    }
    public void InfoProtista1()
    {
        _cardInfoProtistas.ThisInfoProtista1();
    }
    public void InfoProtista2()
    {
        _cardInfoProtistas.ThisInfoProtista2();
    }
    public void InfoProtista3()
    {
        _cardInfoProtistas.ThisInfoProtista3();
    }
    public void InfoProtista4()
    {
        _cardInfoProtistas.ThisInfoProtista4();
    }
    public void InfoProtista5()
    {
        _cardInfoProtistas.ThisInfoProtista5();
    }
    public void ViewMonera1()
    {
        _cardCraftingMoneras.ThisViewMonera1();
    }
    public void ViewMonera2()
    {
        _cardCraftingMoneras.ThisViewMonera2();
    }
    public void ViewMonera3()
    {
        _cardCraftingMoneras.ThisViewMonera3();
    }
    public void ViewMonera4()
    {
        _cardCraftingMoneras.ThisViewMonera4();
    }
    public void ViewMonera5()
    {
        _cardCraftingMoneras.ThisViewMonera5();
    }
    public void InfoMonera1()
    {
        _cardInfoMoneras.ThisInfoMonera1();
    }
    public void InfoMonera2()
    {
        _cardInfoMoneras.ThisInfoMonera2();
    }
    public void InfoMonera3()
    {
        _cardInfoMoneras.ThisInfoMonera3();
    }
    public void InfoMonera4()
    {
        _cardInfoMoneras.ThisInfoMonera4();
    }
    public void InfoMonera5()
    {
        _cardInfoMoneras.ThisInfoMonera5();
    }
    public void AnimSlide()
    {
        _filmAnimationsAnimal.AnimSlide();
        _filmAnimationsVegetal.AnimSlide();
        _filmAnimationsFungi.AnimSlide();
        _filmAnimationsProtista.AnimSlide();
        _filmAnimationsMonera.AnimSlide();
    }
    public void GoToAnimal()
    {
        _menuAnimationsAnimal.AnimBtnAnimal();
        _menuAnimationsAnimal.AnimFadeAnimal();
        _menuAnimationsAnimal.AnimWaveAnimal();
        _menuAnimationsAnimal.AnimContentAnimal();
        ClosingAll();
    }
    public void GoToVegetal()
    {
        _menuAnimationsVegetal.AnimBtnVegetal();
        _menuAnimationsVegetal.AnimFadeVegetal();
        _menuAnimationsVegetal.AnimWaveVegetal();
        _menuAnimationsVegetal.AnimContentVegetal();
        ClosingAll();
    }
    public void GoToFungi()
    {
        _menuAnimationsFungi.AnimBtnFungi();
        _menuAnimationsFungi.AnimFadeFungi();
        _menuAnimationsFungi.AnimWaveFungi();
        _menuAnimationsFungi.AnimContentFungi();
        ClosingAll();
    }
    public void GoToProtista()
    {
        _menuAnimationsProtista.AnimBtnProtista();
        _menuAnimationsProtista.AnimFadeProtista();
        _menuAnimationsProtista.AnimWaveProtista();
        _menuAnimationsProtista.AnimContentProtista();
        ClosingAll();
    }
    public void GoToMonera()
    {
        _menuAnimationsMonera.AnimBtnMonera();
        _menuAnimationsMonera.AnimFadeMonera();
        _menuAnimationsMonera.AnimWaveMonera();
        _menuAnimationsMonera.AnimContentMonera();
        ClosingAll();
    }
    public void ClosingAll()
    {
        CloseCraft();
        CloseInfo();
    }
}