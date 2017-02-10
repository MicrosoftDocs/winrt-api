---
-api-id: P:Windows.Gaming.Input.ForceFeedback.ForceFeedbackMotor.MasterGain
-api-type: winrt property
---

<!-- Property syntax
public double MasterGain { get;  set; }
-->

# Windows.Gaming.Input.ForceFeedback.ForceFeedbackMotor.MasterGain

## -description
Specifies the percentage by which to reduce the force of all effects on the controller.

## -property-value
Specifies the percentage by which to reduce the force of all effects on the controller.

## -remarks

## -examples
```

// The Contoso and Fabrikam motors have a very high maximum
// torque output, so tone down all force feedback effects
// played on those devices so they don't overwhelm the user
if (motor->HardwareModelId == ContosoWheelMotorId)
{
    // Attentuate effects by 20% for the Contoso motor
    motor->MasterGain = 0.2;
}
else if (motor->HardwareModelId == FabrikamWheelMotorId)
{
    // Attenuate effects by 35% for the Fabrikam motor
    motor->MasterGain = 0.35;
}

// Make sure the motor is enabled
motor->IsMotorEnabled = true;
          
          
```



## -see-also
