using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ReciipeData", menuName = "Scriptable Objects/ReciipeData")]
public class ReciipeData : ScriptableObject
{
    [SerializeField] public String recipename;
    [SerializeField] private List<CookingEvent> steps;
    [SerializeField] private Sprite sprite;

    public List<CookingEvent> getSteps()
    {
        return steps;
    }
    public Sprite PotionSprite => sprite;
    public bool compareRecipe(List<CookingEvent> playerRecipe)
    {
        int size = steps.Count;
        if (size != playerRecipe.Count)
        {
            return false;
        }
        else
        {
            for (int i = 0; i <size; i++)
            {
                if (! playerRecipe[i].IsEqual(steps[i]))
                {
                    return false;
                }
            }
            Debug.Log("yes");
            return true;
        }
    }
}
