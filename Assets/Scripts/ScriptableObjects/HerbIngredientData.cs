using UnityEngine;

[CreateAssetMenu(fileName = "HerbIngredientData", menuName = "Scriptable Objects/HerbIngredientData")]
public class HerbIngredientData : Ingredientdata

{
    [SerializeField] private Ingredientdata grindedHerb;
    public Ingredientdata GrindedHerb => grindedHerb;    
}
