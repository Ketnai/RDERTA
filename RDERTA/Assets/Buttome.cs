using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class Buttome : MonoBehaviour
{
    public Text numberText;
    public int number = 0;

    public void ButtonClicked() {
        number++;
        numberText.text = number.ToString();
}
}
