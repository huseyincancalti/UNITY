using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSFlashlight : MonoBehaviour
{
    public Light flashlight; // Fener �����
    public KeyCode toggleKey = KeyCode.F; // Feneri a�ma/kapatma tu�u

    void Update()
    {
        // Feneri a�ma/kapatma i�lemi
        if (Input.GetKeyDown(toggleKey))
        {
            flashlight.enabled = !flashlight.enabled;
        }

        // Feneri karakterin ba��na ta��ma
        flashlight.transform.position = transform.position + transform.forward * 1.0f; // Ayarlamalar� ihtiyac�n�za g�re de�i�tirin
        flashlight.transform.rotation = Quaternion.LookRotation(transform.forward, transform.up);
    }
}
