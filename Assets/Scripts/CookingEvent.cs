using System;
using UnityEngine;

public enum CookingEventType
{
    IngredientAdded,
    BoilingCycleComplete,
    CoolingCycleComplete
}

[System.Serializable]
public class CookingEvent
{
[SerializeField]    private CookingEventType type;
[SerializeField]    private Ingredientdata ingredient;

    public CookingEvent(Ingredientdata addedIngrediant)
    {
        ingredient = addedIngrediant;
        type = CookingEventType.IngredientAdded;
    }
    public CookingEvent(CookingEventType type)
    {
        ingredient = null;
        this.type = type;
    }
    public String formatEvent()
    {
        if (type == CookingEventType.IngredientAdded)
        {
            return(ingredient.name + " addded");
        }
        else if (type == CookingEventType.BoilingCycleComplete)
        {
            return("one boiling cycle complete");
        }
        else
        {
            return("one boiling cycle complete");
        }
    }
    public bool IsEqual(CookingEvent other)
    {
        if (other == null)
        {
            return false;
        }
        else if (type!=other.type)
        {
            return false;
        }
        else if (type == CookingEventType.IngredientAdded )
        {
            return ingredient == other.ingredient;
        }
        else
        {
            return true;
        }
    }
}
