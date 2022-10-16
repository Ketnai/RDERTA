using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Spell : MonoBehaviour
{

    Unit a;
    void start()
    {
        a = GameObject.findGameObjectWithTag("a").GetComponent<unit>();
    }
    public void OnButtonClick()
    {
        a.TakeDamage(10);
    }
}
