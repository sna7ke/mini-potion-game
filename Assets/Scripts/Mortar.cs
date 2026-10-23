using UnityEngine;
using UnityEngine.EventSystems;
public class Mortar : MonoBehaviour,IPointerClickHandler
{
    public Spawner spawner;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnPointerClick (PointerEventData eventData)
    {
        Ingredientdata ingredient = spawner.passTheIngrediant();
        if (ingredient !=null && ingredient.GetType() == typeof(HerbIngredientData))
        {
        HerbIngredientData herb = (HerbIngredientData)ingredient;

        Ingredientdata powdered = herb.GrindedHerb;
        spawner.spawnIngredient(powdered);
        
        }
        
    }
}
