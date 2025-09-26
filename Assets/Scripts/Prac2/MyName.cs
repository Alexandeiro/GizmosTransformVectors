using UnityEngine;

public class MyName : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(new Vector2(0, 0), new Vector2(1,2));
        Debug.DrawLine(new Vector2(1, 2), new Vector2(2,0));
        Debug.DrawLine(new Vector2(0.5f, 1), new Vector2(1.5f, 1));
    }
}
