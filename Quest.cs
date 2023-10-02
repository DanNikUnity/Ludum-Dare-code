using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Quest : MonoBehaviour
{

    public int PaperIndex;
    public GameObject Paper;
    public GameObject PaperUI;
    public Collider Col;
    public GameObject Eimage;
    public GameObject CloseBut;
    

    public QuestChanger QChanger;
    public void Start()
    {
    }

    public void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Eimage.SetActive(true);
        }
        if(other.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
            if (QChanger.i >= PaperIndex)
            {
                Paper.SetActive(true);
                CloseBut.SetActive(true);
                PaperUI.SetActive(true);
                if (QChanger.i == PaperIndex)
                    QChanger.NextQuest();
            }
            else if (QChanger.i != PaperIndex && checker)
            {
                
                    QChanger.LoseShield();
                    StartCoroutine(enumerator(1f));
                
            }
        }
    }
    public GameObject outline;
    public Outline ooutline;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (outline != null) outline.SetActive(true);
            if (ooutline != null) ooutline.enabled = true;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Paper.SetActive(false);
            Eimage.SetActive(false);
            CloseBut.SetActive(false);
        }
        if (other.CompareTag("Player"))
        {
           if(outline != null) outline.SetActive(false);
            if(ooutline != null) ooutline.enabled = false;

        }
    }

    public bool checker = true;
    IEnumerator enumerator(float time)
    {
        checker = false;
        yield return new WaitForSeconds(time);
        checker = true;
    }

}
