using UnityEngine;
using UnityEngine.InputSystem;

public class Spawner : MonoBehaviour
{
    private GameObject currentInstance ;
    private Ingredientdata currentIngrediant;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentInstance!=null)
        {
           // Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
           Vector2 mousePos = Mouse.current.position.ReadValue();
           Vector2 pos = Camera.main.ScreenToWorldPoint(mousePos);

            currentInstance.transform.position = new Vector3 (pos.x,pos.y,transform.position.z);

        }
    }
    public void spawnIngredient(Ingredientdata newIngredient)
    {
        Clear();
        currentIngrediant = newIngredient;

        Vector2 mousePos = Mouse.current.position.ReadValue();
        Vector2 pos = Camera.main.ScreenToWorldPoint(mousePos);
        currentInstance = Instantiate(currentIngrediant.ingrediantprefab,new Vector3(pos.x,pos.y,transform.position.z),Quaternion.identity);

        SpriteRenderer sr = currentInstance.GetComponent<SpriteRenderer>();
        sr.sortingOrder = 10;
        
    }
    public void Clear ()
    {
        if (currentInstance != null)
        {
            Destroy(currentInstance);
            currentInstance = null;
            currentIngrediant = null;            
        }
    }

    public Ingredientdata passTheIngrediant()
    {
        
        return currentIngrediant;
    }

    [ContextMenu("show")]
    public void showselectedIngredient()
    {
        print(currentInstance.gameObject.name);
    }
}
