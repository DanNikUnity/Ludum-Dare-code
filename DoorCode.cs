using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorCode : MonoBehaviour
{
    public Collider Col;
    public GameObject CodeSpace;
    public string Code;
    public QuestChanger QChanger;

    public GameObject BlackPanelWin;

    public void Start()
    {

        Code = "02057";
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            CodeSpace.SetActive(true);
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CodeSpace.SetActive(false);
        }
    }

    public InputField inputField;

    public void OnSubmitff()
    {
        TryCode(inputField.text);
    }
    public void TryCode(string s)
    {
        if(s == Code)
        {
            //mechanics player wins;
            BlackPanelWin.SetActive(true);
            
        }
        if(s != Code)
        {
            QChanger.LoseShieldDoor();
        }
    }
}
