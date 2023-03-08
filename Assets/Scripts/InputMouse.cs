using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMouse : MonoBehaviour
{

    public Vector3 MousePosition { get; set; }

    private void Awake()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        MousePosition = new Vector3(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"),0);
        MousePosition = MousePosition.normalized;
    }

}
