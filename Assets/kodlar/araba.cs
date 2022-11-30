using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class araba : MonoBehaviour
{
    public WheelCollider önsoltekerlek, önsagtekerlek, arkasoltekerlek, arkasaðtekerlek;

    public float motorhýzý, dönmehýzý;
    public Joystick tus;

    void Update()
    {
        arkasaðtekerlek.motorTorque = motorhýzý * tus.Vertical;
        arkasoltekerlek.motorTorque = motorhýzý * tus.Vertical;
        önsagtekerlek.steerAngle = dönmehýzý * tus.Horizontal;
        önsoltekerlek.steerAngle = dönmehýzý * tus.Horizontal;
    }
}