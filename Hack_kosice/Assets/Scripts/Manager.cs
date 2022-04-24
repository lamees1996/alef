using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
        private static Manager instance;
    public static Manager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<Manager>();
            }
            return instance;
        }
    }


    public GameObject tut;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ResetObjects(){
           InteractionsHandler.Instance.CurrentBalanceSub.SetActive(false);
                       InteractionsHandler.Instance.PiggyBankSubHolder.SetActive(false);
                       InteractionsHandler.Instance.CharitySubHolder.SetActive(false);
                       InteractionsHandler.Instance.CharitySubHolder2.SetActive(false);
                       InteractionsHandler.Instance.TutorialsHolder.SetActive(false);

                          InteractionsHandler.Instance.Current_Balance.SetActive(true);
                          InteractionsHandler.Instance.Piggy_Bank.SetActive(true);
                          InteractionsHandler.Instance.Tutorials.SetActive(true);
                        InteractionsHandler.Instance.CharityHolder.SetActive(true);
                        InteractionsHandler.Instance.Recommendation.SetActive(true);
                        InteractionsHandler.Instance.Competition.SetActive(true);
                        InteractionsHandler.Instance.TutotrialsBanner.SetActive(true);
                        

    }
    public void TurnOffTut(){
        tut.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
