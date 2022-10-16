using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Spell : MonoBehaviour
{
    public GameObject enemy;
    private Unit Unit;
    void Awake()
    {
        Unit = GetComponent<Unit>();
    }
        public void OnButtonClick()
    {
       Unit.TakeDamage(10);
    }
}
