using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestChanger : MonoBehaviour
{
    public int i;

    public GameObject[] Quest;

    public GameObject CurentQuest;
    public GameObject Shield1;
    public GameObject Shield2;
    public GameObject Panel;
    public GameObject PanelItems;
    public bool CanLose = true;



    public void Start()
    {
        CurentQuest = Quest[i];
    }

    public void NextQuest()
    {
        i++;
        CurentQuest = Quest[i];
    }


    // <summary>
    // shield sistem
    // </summary>

    public int Shields = 2;
    public GameObject Undeadable;

    public void LoseShield()
    {
        Debug.Log("it Happend");
        //if (CanLose)
       // {
            if (Shields == 0)
            {

                Panel.GetComponent<Animator>().Play("Lose");
                PanelItems.SetActive(true);
            }
            else if (Shields == 1)
            {

                Shield1.GetComponent<Animator>().Play("Wrong");
                Panel.GetComponent<Animator>().Play("Wrong!");
                Shields--;
                StartCoroutine(Fake(3));
            }
            else if (Shields == 2)
            {

                Shield2.GetComponent<Animator>().Play("Wrong");
                Panel.GetComponent<Animator>().Play("Wrong!");
                Shields--;
                StartCoroutine(Fake(3));
            }
        //}

    }
    public void LoseShieldDoor()
    {


            if (Shields == 0)
            {

                Panel.GetComponent<Animator>().Play("Lose");
                PanelItems.SetActive(true);
            }
            else if (Shields == 1)
            {

                Shield1.GetComponent<Animator>().Play("Wrong");
                Panel.GetComponent<Animator>().Play("Wrong!");
                Shields--;
            }
            else if (Shields == 2)
            {

                Shield2.GetComponent<Animator>().Play("Wrong");
                Panel.GetComponent<Animator>().Play("Wrong!");
                Shields--;
            }
    }

    IEnumerator Fake(float delay)
    {

        Undeadable.SetActive(true);
        yield return new WaitForSeconds(delay);
        Undeadable.SetActive(false);
    }

}
