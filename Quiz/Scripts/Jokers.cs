using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jokers : MonoBehaviour
{
    [SerializeField] private QuizManager qmanager;
    [SerializeField] private QuizGameUI GameUI;
    Question quest=new Question();
    
    public Button[] jokersb;
    public bool shieldjok=false;//kullanıldı mı?
    int twoptions=0;
    void Start()
    {
        Button shieldbutton=jokersb[0].GetComponent<Button>();
        shieldbutton.onClick.AddListener(shieldfunc);
        Button flashbutton=jokersb[1].GetComponent<Button>();
        flashbutton.onClick.AddListener(flashfunc);
        Button magnetbutton=jokersb[2].GetComponent<Button>();
        magnetbutton.onClick.AddListener(magnetfunc);

    }
    //koruma jokeri
        void shieldfunc()
    {   
        jokersb[0].enabled=false;
        shieldjok=true;

        
    }
    //zaman ekleme jokeri
    void flashfunc()
    {
        qmanager.currentTime+=15;
        jokersb[1].enabled=false;
    }
    //yanlış şık eleme jokeri
    void magnetfunc()
    {
       for(int i=0; i<4; i++){
           if( GameUI.options[i].name!=quest.correctAns)
   {
                GameUI.options[i].image.color=Color.red;
                //GameUI.options[i].enabled=false;
                twoptions++;
                if(twoptions==2)
                break;
   }
        
        }
     jokersb[2].enabled=false;

    }
    
   
}
