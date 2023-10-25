using UnityEngine;
[CreateAssetMenu(fileName = "InfoKindom", menuName = "Create Info Kindom", order = 0)]
public class InfoKindomData : ScriptableObject
{
    [SerializeField] string textName = "";
    [SerializeField] string text2 = "";
    [SerializeField] string textInfo = "";
    [SerializeField]
    GameObject
    animal1, animal2, animal3, animal4, animal5,
    vegetal1, vegetal2, vegetal3, vegetal4, vegetal5,
    fungi1, fungi2, fungi3, fungi4, fungi5,
    protista1, protista2, protista3, protista4, protista5,
    monera1, monera2, monera3, monera4, monera5;
    public string TextName { get { return textName; } set { textName = value; } }
    public string Text2 { get { return text2; } set { text2 = value; } }
    public string TextInfo { get { return textInfo; } set { textInfo = value; } }
    public GameObject Animal1 { get { return animal1; } }
    public GameObject Animal2 { get { return animal2; } }
    public GameObject Animal3 { get { return animal3; } }
    public GameObject Animal4 { get { return animal4; } }
    public GameObject Animal5 { get { return animal5; } }
    public GameObject Vegetal1 { get { return vegetal1; } }
    public GameObject Vegetal2 { get { return vegetal2; } }
    public GameObject Vegetal3 { get { return vegetal3; } }
    public GameObject Vegetal4 { get { return vegetal4; } }
    public GameObject Vegetal5 { get { return vegetal5; } }
    public GameObject Fungi1 { get { return fungi1; } }
    public GameObject Fungi2 { get { return fungi2; } }
    public GameObject Fungi3 { get { return fungi3; } }
    public GameObject Fungi4 { get { return fungi4; } }
    public GameObject Fungi5 { get { return fungi5; } }
    public GameObject Protista1 { get { return protista1; } }
    public GameObject Protista2 { get { return protista2; } }
    public GameObject Protista3 { get { return protista3; } }
    public GameObject Protista4 { get { return protista4; } }
    public GameObject Protista5 { get { return protista5; } }
    public GameObject Monera1 { get { return monera1; } }
    public GameObject Monera2 { get { return monera2; } }
    public GameObject Monera3 { get { return monera3; } }
    public GameObject Monera4 { get { return monera4; } }
    public GameObject Monera5 { get { return monera5; } }
}