using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;

public class RecipeChecker : MonoBehaviour
{   
    [SerializeField] private List<ReciipeData> totalRecipes;
    public ReciipeData ValidateRecipe(List<CookingEvent> playerRecipe)
    {
        foreach (var recipe in totalRecipes)
        {
            bool result = recipe.compareRecipe(playerRecipe);
            if (result)
            {
                return recipe; 
            }
        }
        return null;
        
    }
}
