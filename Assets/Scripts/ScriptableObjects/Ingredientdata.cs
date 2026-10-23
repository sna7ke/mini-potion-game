using UnityEngine;

[CreateAssetMenu(fileName = "Ingredientdata", menuName = "Scriptable/Ingredientdata")]
public class Ingredientdata : ScriptableObject
{
    [SerializeField] public string ingrediantName;
    [SerializeField] public GameObject ingrediantprefab;
}
