using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionsHandler : MonoBehaviour
{

    private static InteractionsHandler instance;
    public static InteractionsHandler Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<InteractionsHandler>();
            }
            return instance;
        }
    }

    public GameObject CurrentBalanceSub;
    public GameObject PiggyBankSubHolder;

    public GameObject Current_Balance;
    public GameObject Piggy_Bank;
    public GameObject Tutorials;
    public GameObject CharityHolder;
    public GameObject Recommendation;
    public GameObject Competition;
    public GameObject TutorialsHolder;

    public Text currentBalanceText;
    public Text currentBalanceText2;
        public Text currentBalanceText3;

    public GameObject ChessHolder;
    public GameObject Ps4_holder;
    public Scrollbar ChessHolderSlider;
    public Scrollbar Ps4_holderSlider;
    public Text ChessHolderText;
    public Text Ps4_holderText;

        public GameObject CharitySubHolder;
        public GameObject CharitySubHolder2;


        public Scrollbar CharitySlider;
    public Text CharityText;

    int psValue=120;

    int chessValue=20;

    int balance = 1000;
    int charityValue = 10;

    public GameObject TutotrialsBanner;


    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void changeBalance(bool isPs4){
        currentBalanceText.text = "Current Balance: \n " + (balance-10);
        balance -=10;
        if(isPs4){
                                                psValue+=10;

                        Ps4_holderText.text = (psValue)  + "/400$";

            Ps4_holderSlider.size = (psValue) / 400f;
        }else{
                                                chessValue+=10;

                        ChessHolderText.text = (chessValue)  + "/50$";

                        ChessHolderSlider.size = (chessValue) / 50f ;


        }
    }
    public void ChangeCharity(){
                currentBalanceText2.text = "Current Balance: \n " + (balance-10);
        balance -=10;
        charityValue +=10;
        CharityText.text = (charityValue)  + "/100$";

            CharitySlider.size = (charityValue) / 100f ;
    }
    // Update is called once per frame
    void Update()
    {
        currentBalanceText3.text = "Current Balance: \n " + (balance) +"$";
        currentBalanceText2.text = "Current Balance: \n " + (balance)+"$";
                currentBalanceText.text = "Current Balance: \n " + (balance)+"$";

        
    }
}
