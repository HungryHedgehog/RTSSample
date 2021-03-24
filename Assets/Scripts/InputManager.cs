using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private PlayerControls controls;

    private void Awake()
    {
        controls = new PlayerControls();
    }
    private void Start()
    {
        controls.UI.Enable();
    }

    public PlayerControls GetControls()
    {
        return controls;
    }

}
