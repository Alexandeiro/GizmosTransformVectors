using UnityEngine;

public class MouseInputs : MonoBehaviour
{
    //attributes
    public Transform target;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Mouse / Touch
        if (Input.GetMouseButtonUp(0))
            print("Boton izq");

        if (Input.GetMouseButtonUp(1))
            print("Boton der");

        if (Input.GetMouseButtonUp(2))
            print("Boton cen");

        //Mouse position
        print("Mouse x: " + Input.mousePosition.x + " / Mouse y: " + Input.mousePosition.y);
        target.position = Input.mousePosition;
    }
}
