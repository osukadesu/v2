using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSave : MonoBehaviour
{
    [SerializeField] CraftBuilderBase craftBuilderBase;
    [SerializeField] PlayerMove playerMove;
    public void MyButtonSave()
    {
        SaveAndLoadManager.SaveDataGame(craftBuilderBase, playerMove);
    }
}