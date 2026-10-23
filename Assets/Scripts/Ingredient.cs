using UnityEngine;
using UnityEngine.EventSystems;
public class Ingredient : MonoBehaviour , IPointerClickHandler
{
    Spawner spawner;
    [SerializeField] Ingredientdata ingredient;    
    void Start()
    {
        spawner = GameObject.FindGameObjectsWithTag("Respawn")[0].GetComponent<Spawner>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        spawner.spawnIngredient(ingredient);
    }
    
}
