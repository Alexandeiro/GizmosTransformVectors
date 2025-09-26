using UnityEngine;

public class Tamer : MonoBehaviour
{
    //public
    public string tamerName;

    //private
    private Whip whip;

    //Methods
    public void Presentation()
    {
        print("Here comes " + tamerName + "!!");
    }

    public void SetWhip(Whip newWhip)
    {
        whip = newWhip;
    }
}
