using UnityEngine;

public class KeyInputs : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //Key down and up: enter
        if (Input.GetKeyDown(KeyCode.Return))
            print("Se ha pulsado Enter.");
        

        if (Input.GetKey(KeyCode.Return))
            print("Se esta pulsando Enter.");
        

        if (Input.GetKeyUp(KeyCode.Return))
            print("Se ha soltado Enter.");

        //Other key
        if (Input.GetKeyUp(KeyCode.A))
            print("Se ha soltado A.");

        if (Input.GetKeyUp(KeyCode.F1))
            print("Se ha soltado F1.");

        if (Input.GetKeyUp(KeyCode.Space))
            print("Se ha soltado Space.");

        if (Input.GetKeyUp(KeyCode.Escape))
            print("Se ha soltado Escape.");

        if (Input.GetKeyUp(KeyCode.LeftControl))
            print("Se ha soltado LeftControl.");
    }
}
