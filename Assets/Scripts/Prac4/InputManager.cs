using UnityEngine;

public class InputManager : MonoBehaviour
{
    //Attributes
    public Transform cubeTransform;
    public float speed = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //Debug.DrawRay(cubeTransform.position, Vector3.right * Input.GetAxis("Horizontal"), Color.red);
        Debug.DrawRay(cubeTransform.position, Vector3.right * Input.GetAxis("Mouse X"), Color.red);
        //Debug.DrawRay(cubeTransform.position, Vector3.forward * Input.GetAxis("Vertical"), Color.blue);
        Debug.DrawRay(cubeTransform.position, Vector3.forward * Input.GetAxis("Mouse Y"), Color.blue);
        print("Horizontal: " + Input.GetAxis("Horizontal"));
        if (Input.GetButtonUp("Fire1"))
            print("Fire!");

        print("MouseWheel: " + Input.GetAxis("Mouse ScrollWheel"));
        print("Mouse x: " + Input.GetAxis("Mouse X"));
        print("Mouse y: " + Input.GetAxis("Mouse Y"));

        //Movement mouse
        cubeTransform.Translate(Vector3.right * Input.GetAxis("Mouse X") * Time.deltaTime * speed);
        cubeTransform.Translate(Vector3.forward * Input.GetAxis("Mouse Y") * Time.deltaTime * speed);
        //Movement keys
        cubeTransform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * speed);
        cubeTransform.Translate(Vector3.forward * Input.GetAxis("Vertical") * Time.deltaTime * speed);
    }
}
