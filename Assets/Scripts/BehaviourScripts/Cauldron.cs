using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Cauldron : MonoBehaviour,IPointerClickHandler
{
    public Spawner spawner;
    private List<CookingEvent> cookingEvents;

    private bool isFireOn = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cookingEvents = new List<CookingEvent>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerClick (PointerEventData eventData)
    {
        Ingredientdata ingrediant = spawner.passTheIngrediant();
        if (ingrediant !=null)
        {
        addIngrediant(spawner.passTheIngrediant());
        spawner.Clear();            
        }
    }
    private void addIngrediant(Ingredientdata newIngrediant)
    {
        cookingEvents.Add(new CookingEvent(newIngrediant));
    }
    public void OnCycleComplete()
    {
        if (isFireOn)
        {
            cookingEvents.Add(new CookingEvent(CookingEventType.BoilingCycleComplete));

        }
        else
        {
            cookingEvents.Add(new CookingEvent(CookingEventType.CoolingCycleComplete));
        }
    }
    public List<CookingEvent> GetCookingEvents()
    {
        return cookingEvents;
    }
    [ContextMenu("show")]
    public void showselectedIngredient()
    {
        foreach (var item in cookingEvents)
        {
            print(item.formatEvent());
        }
    }
    public void setTheFlameOn(bool flame)
    {
        isFireOn = flame;
    }
    public void ClearCookingHistory()
    {
        cookingEvents.Clear();
    }

}
