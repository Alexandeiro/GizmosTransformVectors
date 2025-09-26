using UnityEngine;

public class Monster : MonoBehaviour
{
    //public
    public string MonsterName;
    public float ferocity;
    
    //private
    private Tamer tamer;
    
    //Methods
    public void Roar()
    {
        print("Monter: " + MonsterName + " has a ferocity of " + ferocity);
    }

    public void SetTamer(Tamer newTamer)
    {
        tamer = newTamer;
    }

}
