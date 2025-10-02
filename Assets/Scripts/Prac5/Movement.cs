using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed = 5;
    public float rotationSpeed = 300;
    public float zoomSpeed = 500;
    public Transform cameraTransform;

    // Update is called once per frame
    void Update()
    {
        //player movement
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed);
        transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed);

        //camera rotation
        //cameraTransform.RotateAround(transform.position, Vector3.up, Input.GetAxis("Mouse X") * Time.deltaTime * rotationSpeed);

        //player rotation
        transform.Rotate(Vector3.up, Input.GetAxis("Mouse X") * Time.deltaTime * rotationSpeed);

        //zoom camara
        cameraTransform.LookAt(transform.position);
        cameraTransform.Translate(cameraTransform.forward * Input.GetAxis("Mouse ScrollWheel") * zoomSpeed);
    }
}
