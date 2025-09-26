using UnityEngine;

public class Whip : MonoBehaviour
{
    //public
    public string element;
    public float power;

    //methods
    public void Crack()
    {
        print("The whip of " + element + " crack with a power of " + power);

    }
}
