using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class InfoContent : MonoBehaviour
{
    [SerializeField] CanvasGroup canvasGroup;
    [SerializeField] InfoKindomData infoKindomData;
    [SerializeField] GameObject objec3D;
    [SerializeField] Transform transform3D;
    [SerializeField] Text textName;
    [SerializeField] Text text2;
    [SerializeField] Text textInfo;
    [SerializeField] CanvasManager _canvasManager;
    [SerializeField] Button btnBackInfo, btnInfoAnimal1, btnInfoAnimal2, btnInfoAnimal3, btnInfoAnimal4, btnInfoAnimal5;
    /*
    Button btnBackInfo, btnInfoAnimal1, btnInfoAnimal2, btnInfoAnimal3, btnInfoAnimal4, btnInfoAnimal5,
    btnInfoVegetal1, btnInfoVegetal2, btnInfoVegetal3, btnInfoVegetal4, btnInfoVegetal5,
    btnInfoFungi1, btnInfoFungi2, btnInfoFungi3, btnInfoFungi4, btnInfoFungi5,
    btnInfoProtista1, btnInfoProtista2, btnInfoProtista3, btnInfoProtista4, btnInfoProtista5,
    btnInfoMonera1, btnInfoMonera2, btnInfoMonera3, btnInfoMonera4, btnInfoMonera5;
    */
    void Start()
    {
        Hide();
    }
    void Awake()
    {
        btnBackInfo.onClick.AddListener(() => _canvasManager.CloseInfo());
        btnInfoAnimal1.onClick.AddListener(() => _canvasManager.InfoAnimal1());
        btnInfoAnimal2.onClick.AddListener(() => _canvasManager.InfoAnimal2());
        btnInfoAnimal3.onClick.AddListener(() => _canvasManager.InfoAnimal3());
        btnInfoAnimal4.onClick.AddListener(() => _canvasManager.InfoAnimal4());
        btnInfoAnimal5.onClick.AddListener(() => _canvasManager.InfoAnimal5());
        objec3D = GameObject.FindGameObjectWithTag("object3D").GetComponent<GameObject>();
        transform3D = GameObject.FindGameObjectWithTag("object3D").GetComponent<Transform>();
    }
    public void Configure(CanvasManager canvasManager)
    {
        _canvasManager = canvasManager;
    }
    public void Show()
    {
        canvasGroup.alpha = 1; canvasGroup.interactable = true; canvasGroup.blocksRaycasts = true;
    }
    public void Hide()
    {
        canvasGroup.alpha = 0; canvasGroup.interactable = false; canvasGroup.blocksRaycasts = false;
    }
    public void SetInfo()
    {
        switch (_canvasManager.InfoCode)
        {
            case 1:
                Show();
                textName.text = infoKindomData.TextName = "Carpa Asiática Dorada";
                text2.text = infoKindomData.Text2 = "Vista 3D";
                textInfo.text = infoKindomData.TextInfo = "La carpa asiática dorada es como una celebridad entre los peces, con colores súper brillantes. Les encanta nadar en estanques y lucirse. Aunque son originarias de Asia, a veces las llevamos a otros lugares para que más personas las conozcan.";
                objec3D = Instantiate(infoKindomData.Animal1, transform3D);
                break;
            case 2:
                Show();
                textName.text = infoKindomData.TextName = "Chipichipi";
                text2.text = infoKindomData.Text2 = "Vista 3D";
                textInfo.text = infoKindomData.TextInfo = "El chipichipi es un molusco pequeñito que vive en el mar, es como el tesoro escondido de la arena. Estos diminutos amigos tienen conchas lindas y pueden enterrarse en la playa. Si alguna vez estás construyendo castillos de arena puede que encuentres uno.";
                objec3D = Instantiate(infoKindomData.Animal2, transform3D);
                break;
            case 3:
                Show();
                textName.text = infoKindomData.TextName = "Mariposa Monarca";
                text2.text = infoKindomData.Text2 = "Vista 3D";
                textInfo.text = infoKindomData.TextInfo = "La mariposa monarca es como la reina de las mariposas cada año viajan muy lejos cruzando paises, Son como pequeñas exploradoras con alas mágicas. Además, es famosa por sus colores naranjas y negros. ¡Una verdadera belleza voladora";
                objec3D = Instantiate(infoKindomData.Animal3, transform3D);
                break;
            case 4:
                Show();
                textName.text = infoKindomData.TextName = "Iguana Verde";
                text2.text = infoKindomData.Text2 = "Vista 3D";
                textInfo.text = infoKindomData.TextInfo = "La iguana verde es como el dinosaurio pequeño de los días modernos. Vive en lugares cálidos, es buena escaladora de árboles, se broncea todo el día y tiene una cola larga. Con su piel verde, es como una supermodelo de la selva.";
                objec3D = Instantiate(infoKindomData.Animal4, transform3D);
                break;
            case 5:
                Show();
                textName.text = infoKindomData.TextName = "Colibrí de Mulsant";
                text2.text = infoKindomData.Text2 = "Vista 3D";
                textInfo.text = infoKindomData.TextInfo = "El colibrí de Mulsant es un ave diminuto y brillante. Como un pequeño arco iris con alas, le encanta chupar néctar de las flores. A menudo se encuentran en zonas montañosas de América del Sur y América Central. ¡Es como una bailarina mágica del aire!";
                objec3D = Instantiate(infoKindomData.Animal5, transform3D);
                break;
            case 6:
                Show();
                textName.text = infoKindomData.TextName = "Vegetal1";
                text2.text = infoKindomData.Text2 = "Vista 3D";
                textInfo.text = infoKindomData.TextInfo = "Info";
                //objec3D = infoKindomData.Vegetal1;
                break;
            case 7:
                Show();
                textName.text = infoKindomData.TextName = "Vegetal2";
                text2.text = infoKindomData.Text2 = "Vista 3D";
                textInfo.text = infoKindomData.TextInfo = "Info";
                //objec3D = infoKindomData.Vegetal2;
                break;
            case 8:
                Show();
                textName.text = infoKindomData.TextName = "Vegetal3";
                text2.text = infoKindomData.Text2 = "Vista 3D";
                textInfo.text = infoKindomData.TextInfo = "Info";
                //objec3D = infoKindomData.Vegetal3;
                break;
            case 9:
                Show();
                textName.text = infoKindomData.TextName = "Vegetal4";
                text2.text = infoKindomData.Text2 = "Vista 3D";
                textInfo.text = infoKindomData.TextInfo = "Info";
                //objec3D = infoKindomData.Vegetal4;
                break;
            case 10:
                Show();
                textName.text = infoKindomData.TextName = "Vegetal5";
                text2.text = infoKindomData.Text2 = "Vista 3D";
                textInfo.text = infoKindomData.TextInfo = "Info";
                //objec3D = infoKindomData.Vegetal5;
                break;
            case 11:
                Show();
                textName.text = infoKindomData.TextName = "Fungi1";
                text2.text = infoKindomData.Text2 = "Vista 3D";
                textInfo.text = infoKindomData.TextInfo = "Info";
                //objec3D = infoKindomData.Fungi1;
                break;
            case 12:
                Show();
                textName.text = infoKindomData.TextName = "Fungi2";
                text2.text = infoKindomData.Text2 = "Vista 3D";
                textInfo.text = infoKindomData.TextInfo = "Info";
                //objec3D = infoKindomData.Fungi2;
                break;
            case 13:
                Show();
                textName.text = infoKindomData.TextName = "Fungi3";
                text2.text = infoKindomData.Text2 = "Vista 3D";
                textInfo.text = infoKindomData.TextInfo = "Info";
                //objec3D = infoKindomData.Fungi3;
                break;
            case 14:
                Show();
                textName.text = infoKindomData.TextName = "Fungi4";
                text2.text = infoKindomData.Text2 = "Vista 3D";
                textInfo.text = infoKindomData.TextInfo = "Info";
                //objec3D = infoKindomData.Fungi4;
                break;
            case 15:
                Show();
                textName.text = infoKindomData.TextName = "Fungi5";
                text2.text = infoKindomData.Text2 = "Vista 3D";
                textInfo.text = infoKindomData.TextInfo = "Info";
                //objec3D = infoKindomData.Fungi5;
                break;
            case 16:
                Show();
                textName.text = infoKindomData.TextName = "Protista1";
                text2.text = infoKindomData.Text2 = "Vista 3D";
                textInfo.text = infoKindomData.TextInfo = "Info";
                //objec3D = infoKindomData.Protista1;
                break;
            case 17:
                Show();
                textName.text = infoKindomData.TextName = "Protista2";
                text2.text = infoKindomData.Text2 = "Vista 3D";
                textInfo.text = infoKindomData.TextInfo = "Info";
                // objec3D = infoKindomData.Protista2;
                break;
            case 18:
                Show();
                textName.text = infoKindomData.TextName = "Protista3";
                text2.text = infoKindomData.Text2 = "Vista 3D";
                textInfo.text = infoKindomData.TextInfo = "Info";
                //objec3D= infoKindomData.Protista3;
                break;
            case 19:
                Show();
                textName.text = infoKindomData.TextName = "Protista4";
                text2.text = infoKindomData.Text2 = "Vista 3D";
                textInfo.text = infoKindomData.TextInfo = "Info";
                //objec3D= infoKindomData.Protista4;
                break;
            case 20:
                Show();
                textName.text = infoKindomData.TextName = "Protista5";
                text2.text = infoKindomData.Text2 = "Vista 3D";
                textInfo.text = infoKindomData.TextInfo = "Info";
                //objec3D = infoKindomData.Protista5;
                break;
            case 21:
                Show();
                textName.text = infoKindomData.TextName = "Monera1";
                text2.text = infoKindomData.Text2 = "Vista 3D";
                textInfo.text = infoKindomData.TextInfo = "Info";
                //objec3D = infoKindomData.Monera1;
                break;
            case 22:
                Show();
                textName.text = infoKindomData.TextName = "Monera2";
                text2.text = infoKindomData.Text2 = "Vista 3D";
                textInfo.text = infoKindomData.TextInfo = "Info";
                //objec3D = infoKindomData.Monera2;
                break;
            case 23:
                Show();
                textName.text = infoKindomData.TextName = "Monera3";
                text2.text = infoKindomData.Text2 = "Vista 3D";
                textInfo.text = infoKindomData.TextInfo = "Info";
                //objec3D = infoKindomData.Monera3;
                break;
            case 24:
                Show();
                textName.text = infoKindomData.TextName = "Monera4";
                text2.text = infoKindomData.Text2 = "Vista 3D";
                textInfo.text = infoKindomData.TextInfo = "Info";
                //objec3D= infoKindomData.Monera4;
                break;
            case 25:
                Show();
                textName.text = infoKindomData.TextName = "Monera5";
                text2.text = infoKindomData.Text2 = "Vista 3D";
                textInfo.text = infoKindomData.TextInfo = "Info";
                //objec3D = infoKindomData.Monera5;
                break;
            case 26:
                Hide();
                textName.text = infoKindomData.TextName = "";
                text2.text = infoKindomData.Text2 = "";
                textInfo.text = infoKindomData.TextInfo = "";
                Destroy(objec3D);
                break;
            default:
                Hide();
                textName.text = infoKindomData.TextName = "";
                text2.text = infoKindomData.Text2 = "";
                textInfo.text = infoKindomData.TextInfo = "";
                Destroy(objec3D);
                break;
        }
    }
}