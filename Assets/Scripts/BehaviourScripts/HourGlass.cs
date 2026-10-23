using UnityEngine;
using UnityEngine.EventSystems;
public class HourGlass : MonoBehaviour , IPointerClickHandler
{
    [SerializeField] Cauldron cauldron;
    private float sandtime = 20.0f;
    private float timeUntilSandEmpty = 0.0f;
    private bool isFlipped = false ;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isFlipped && timeUntilSandEmpty > 0)
        {
            timeUntilSandEmpty -= Time.deltaTime*sandtime;
        }
        else if (isFlipped)
        {
            cauldron.OnCycleComplete();
            isFlipped = false ;
            transform.Rotate(new Vector3(0,0,180f));
        }
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (!isFlipped)
        {
        isFlipped = true;
        timeUntilSandEmpty = sandtime;
        transform.Rotate(new Vector3(0,0,180f));
        }
    }
}
