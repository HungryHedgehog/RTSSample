using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public SelectUnits SelectedUnitsScript;
    public Text text;

    // Update is called once per frame
    void Update()
    {
        text.text = "Units selected: " + SelectedUnitsScript.GetSelectedUnits().Count;
    }
}
