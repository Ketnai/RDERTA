using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public string unitname;
    public int currenthp;
    public int maxhp;
        
    
    void update ()
    {
        if (currenthp < 0)
        {
            Destroy(gameObject);
        }
    }
    public void TakeDamage(int dmg){
        currenthp -= dmg;
    }

}
