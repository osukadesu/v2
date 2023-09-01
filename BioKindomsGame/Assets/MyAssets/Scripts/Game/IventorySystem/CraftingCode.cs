using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CraftingCode : MonoBehaviour
{/*
    public InventoryItemData animalKey1, animalKey2, animalKey3, animalKey4, animalKey5, vegetalKey1, vegetalKey2, vegetalKey3, vegetalKey4, vegetalKey5, fungiKey1, fungiKey2, fungiKey3, fungiKey4, fungiKey5, protistaKey1, protistaKey2, protistaKey3, protistaKey4, protistaKey5, moneraKey1, moneraKey2, moneraKey3, moneraKey4, moneraKey5;
    public CanvasController canvasController;
    public bool canUnlockAnimalKindom, canUnlockBioKindom, canUnlockVegetalKindom, canUnlockFungiKindom, canUnlockProtistaKindom, canUnlockMoneraKindom;
    PlayerData playerData;
    private void Start()
    {

        canvasController = FindObjectOfType<CanvasController>();
        canUnlockAnimalKindom = false;
        canvasController.buttonUnlockAnimalKindom.interactable = false;
        //canvasController.buttonUnlockBioKindom.interactable = false;
        canvasController.buttonUnlockVegetalKindom.interactable = false;
        canvasController.buttonUnlockFungiKindom.interactable = false;
        canvasController.buttonUnlockProtistaKindom.interactable = false;
        canvasController.buttonUnlockMoneraKindom.interactable = false;
    }
    private void Update()
    {
        UnlockAnimalKindom();
        UnlockVegetalKindom();
        UnlockFungiKindom();
        UnlockProtistaKindom();
        UnlockMoneraKindom();
        UnlockBioKindom();
    }
    public void UnlockAnimalKindom()
    {
        if (animalKey1.itemIsCheck && animalKey2.itemIsCheck && animalKey3.itemIsCheck && animalKey4.itemIsCheck && animalKey5.itemIsCheck)
        {
            canvasController.buttonUnlockAnimalKindom.interactable = true;
            canUnlockAnimalKindom = true;
        }
        else
        {
            canvasController.buttonUnlockAnimalKindom.interactable = false;
            canUnlockAnimalKindom = false;
        }
    }
    public void UnlockVegetalKindom()
    {
        if (vegetalKey1.itemIsCheck && vegetalKey2.itemIsCheck && vegetalKey3.itemIsCheck && vegetalKey4.itemIsCheck && vegetalKey5.itemIsCheck)
        {
            canvasController.buttonUnlockVegetalKindom.interactable = true;
            canUnlockVegetalKindom = true;
        }
        else
        {
            canvasController.buttonUnlockVegetalKindom.interactable = false;
            canUnlockVegetalKindom = false;
        }
    }
    public void UnlockFungiKindom()
    {
        if (fungiKey1.itemIsCheck && fungiKey2.itemIsCheck && fungiKey3.itemIsCheck && fungiKey4.itemIsCheck && fungiKey5.itemIsCheck)
        {
            canvasController.buttonUnlockFungiKindom.interactable = true;
            canUnlockFungiKindom = true;
        }
        else
        {
            canvasController.buttonUnlockFungiKindom.interactable = false;
            canUnlockFungiKindom = false;
        }
    }
    public void UnlockProtistaKindom()
    {
        if (protistaKey1.itemIsCheck && protistaKey2.itemIsCheck && protistaKey3.itemIsCheck && protistaKey4.itemIsCheck && protistaKey5.itemIsCheck)
        {
            canvasController.buttonUnlockProtistaKindom.interactable = true;
            canUnlockProtistaKindom = true;
        }
        else
        {
            canvasController.buttonUnlockProtistaKindom.interactable = false;
            canUnlockProtistaKindom = false;
        }
    }
    public void UnlockMoneraKindom()
    {
        if (moneraKey1.itemIsCheck && moneraKey2.itemIsCheck && moneraKey3.itemIsCheck && moneraKey4.itemIsCheck && moneraKey5.itemIsCheck)
        {
            canvasController.buttonUnlockMoneraKindom.interactable = true;
            canUnlockMoneraKindom = true;
        }
        else
        {
            canvasController.buttonUnlockMoneraKindom.interactable = false;
            canUnlockMoneraKindom = false;
        }
    }

    public void UnlockBioKindom()
    {
        if (canvasController.isAnimalUnlock && canvasController.isVegetalUnlock && canvasController.isFungiUnlock && canvasController.isProtistaUnlock && canvasController.isMoneraUnlock)
        {
            //canvasController.buttonUnlockBioKindom.interactable = true;
            canUnlockBioKindom = true;
        }
        else
        {
            //canvasController.buttonUnlockBioKindom.interactable = false;
            canUnlockBioKindom = false;
        }
    }
    */
}