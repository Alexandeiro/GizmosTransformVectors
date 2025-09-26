using UnityEngine;

public class DirectionVector : MonoBehaviour
{
    //public
    public Transform finalTransform;
    public Transform initialTransform;
    public float speed;

    //private
    private Vector3 _directionVector;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        _directionVector = finalTransform.position - initialTransform.position;
        _directionVector.Normalize();

        Debug.DrawRay(initialTransform.position, _directionVector*speed);
        initialTransform.Translate(_directionVector*Time.deltaTime*speed);

        //print("Magnitude: " + _directionVector.magnitude*speed);
        float distance = Vector3.Distance(initialTransform.position, finalTransform.position);
        print("Distance: " + distance);

        if(distance < 10 || distance > 20)
        {
            speed *= -1;
        }

        
    }
}
