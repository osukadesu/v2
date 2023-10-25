using UnityEngine;
using UnityEngine.UI;

public class CardMenu : MonoBehaviour
{
    [SerializeField] CanvasManager _canvasManager;
    [SerializeField] MenuAnimations menuAnimations;
    [SerializeField] Button buttonGoAnimal, buttonGoVegetal, buttonGoFungi, buttonGoProtista, buttonGoMonera;
    void Awake()
    {
        buttonGoAnimal.onClick.AddListener(() => _canvasManager.ButtonGoAnimal());
        buttonGoVegetal.onClick.AddListener(() => _canvasManager.ButtonGoVegetal());
        buttonGoFungi.onClick.AddListener(() => _canvasManager.ButtonGoFungi());
        buttonGoProtista.onClick.AddListener(() => _canvasManager.ButtonGoProtista());
        buttonGoMonera.onClick.AddListener(() => _canvasManager.ButtonGoMonera());
    }
    public void Configure(CanvasManager canvasManager)
    {
        _canvasManager = canvasManager;
    }
    public void SetContent()
    {
        switch (_canvasManager.MenuCode)
        {
            case 1:
                menuAnimations.AnimFadeAnimal();
                menuAnimations.AnimBtnAnimal();
                menuAnimations.AnimContentAnimal();
                break;
            case 2:
                menuAnimations.AnimFadeVegetal();
                menuAnimations.AnimBtnVegetal();
                menuAnimations.AnimContentVegetal();
                break;
            case 3:
                menuAnimations.AnimFadeFungi();
                menuAnimations.AnimBtnFungi();
                menuAnimations.AnimContentFungi();
                break;
            case 4:
                menuAnimations.AnimFadeProtista();
                menuAnimations.AnimBtnProtista();
                menuAnimations.AnimContentProtista();
                break;
            case 5:
                menuAnimations.AnimFadeMonera();
                menuAnimations.AnimBtnMonera();
                menuAnimations.AnimContentMonera();
                break;
            case 6:
                menuAnimations.CloseAll();
                break;
            default:
                menuAnimations.CloseAll();
                break;
        }
    }
}