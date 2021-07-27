using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CategoryBtnScript : MonoBehaviour
{
    [SerializeField] private Text categoryTitleText;
    [SerializeField] private Text scoreText;
    [SerializeField] private Button btn;
    [SerializeField] private Sprite image1;
    [SerializeField] private Font _font1;
    



    public Button Btn { get => btn; }

    public void SetButton(string title, int totalQuestion)
    {
        btn.GetComponent<Image>().sprite=image1;
        categoryTitleText.text = title;
        categoryTitleText.font=_font1;
        
        scoreText.text = PlayerPrefs.GetInt(title, 0) + "/" + totalQuestion; //we get the score save for this category
    }

}
