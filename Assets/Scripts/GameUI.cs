using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class GameUI : MonoBehaviour
{
    [SerializeField] private GameObject resultPanel;
    [SerializeField] private TMP_Text uiText;
    [SerializeField] private Image potionImage;
    [SerializeField] private Sprite badPotionSprite;
    [SerializeField] private GameObject fireObject;
    [SerializeField] private GameObject scndPage;
    [SerializeField] private GameObject frstPage;



    public Spawner spawner;
     public Cauldron cauldron;
     public RecipeChecker recipeChecker;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ConfirmButton()
    {
        List<CookingEvent> cookingEvents = cauldron.GetCookingEvents();
        ReciipeData  potion =  recipeChecker.ValidateRecipe(cookingEvents);
        if (potion == null)
        {
            uiText.text = "The Potion you have brewed is incorrect !";
            potionImage.sprite = badPotionSprite;        
        }
        else
        {
            uiText.text = "Cogratulations ! you have brewed a " + potion.recipename + " click to reset";
            potionImage.sprite = potion.PotionSprite;
        }
        resultPanel.SetActive(true);

    }   
    public void ResetButton()
    {
        spawner.Clear();
        cauldron.ClearCookingHistory();
    }
    public void CloseButton()
    {
        resultPanel.SetActive(false);
        ResetButton();
    }
    public void FireOnButton()
    {
        fireObject.SetActive(true);
        cauldron.setTheFlameOn(true);

    }

    public void FireOffButton()
    {
        fireObject.SetActive(false);
        cauldron.setTheFlameOn(false);

    }
    public void CloseTutorial()
    {
        frstPage.SetActive(false);
        scndPage.SetActive(false);
    }
    public void goToScnd()
    {
        scndPage.SetActive(true);
        frstPage.SetActive(false);
    }

    public void goToFrst()
    {
        frstPage.SetActive(true);
        scndPage.SetActive(false);
    }

}
