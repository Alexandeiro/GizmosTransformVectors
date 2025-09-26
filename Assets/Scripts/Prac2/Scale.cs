using UnityEngine;

public class Scale : MonoBehaviour
{
    //public
    public float scaleX;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //transform.position = new Vector3(5, transform.position.y, transform.position.z);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(scaleX, transform.localScale.y, transform.localScale.z);

    }
}
