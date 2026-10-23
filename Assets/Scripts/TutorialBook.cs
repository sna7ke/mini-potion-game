using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class TutorialBook : MonoBehaviour,IPointerClickHandler
{
    [SerializeField] GameObject firstPage;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        firstPage.SetActive(true);
    }
}
