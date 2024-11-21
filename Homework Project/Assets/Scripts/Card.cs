using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Card : MonoBehaviour
{
    public bool borderActive = true;
    public int baseHealth = 100;
    public TextMeshProUGUI attack;
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI damage;
    public Image cardImage;
    public Image border;
    public Button button;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RandomizeCardImage()
    {
        float randomRed = Random.Range(0.0f, 1.0f);
        float randomGreen = Random.Range(0.0f, 1.0f);
        float randomBlue = Random.Range(0.0f, 1.0f);

        Color randomColor = new Color(randomRed, randomGreen, randomBlue);
        GetComponent<Image>().color = randomColor;
    }
    public void ChangeHealth(int Health)
    {
        baseHealth -= Health;
        healthText.SetText(baseHealth.ToString());
    }

    public void RemoveBorder()
    {
        if (borderActive)
        {
            border.enabled = false;
        }
        
    }

    public void ChangeAttack()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = "Nuzzle - Flip a coin. If heads, your opponent's Active Pokemon is now paralyzed.";
    }

    public void ChangeDamage()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = "40";
    }
}