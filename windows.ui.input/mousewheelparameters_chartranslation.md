---
-api-id: P:Windows.UI.Input.MouseWheelParameters.CharTranslation
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Point CharTranslation { get;  set; }
-->

# Windows.UI.Input.MouseWheelParameters.CharTranslation

## -description
Gets or sets the device-independent pixel (DIP) conversion factors for both character width and line height units (as set in the **Wheel** settings of the **Mouse** control panel).

## -property-value
The conversion factors for the character width (x) and line height (y).

## -remarks
The following image shows the default control panel settings for the button wheel. These settings map a single detent to a specific unit of distance in the UI (character width and line height). [CharTranslation](mousewheelparameters_chartranslation.md) provides the means to redefine these distances and specify them in terms of device-independent pixel (DIP).

<img src="images/MouseProperties_ButtonWheel.png" alt="Mouse properties dialog with wheel settings displayed" />

If the wheel button is set to scroll three lines at a time for each detent and the value of [CharTranslation](mousewheelparameters_chartranslation.md) is set to (8,16), vertical scrolling is applied at 3 x 16 = 48 device-independent pixel (DIP) per detent. Horizontal scrolling through the mouse tilt wheel is applied at 3 x 8 = 24 device-independent pixel (DIP) per detent.

> [!NOTE]
> If **ManipulationTranslateY**/**ManipulationTranslateRailsY** is disabled and **ManipulationTranslateX**/**ManipulationTranslateRailsX** is enabled through [GestureSettings](gesturerecognizer_gesturesettings.md) then scrolling is applied only along the horizontal axis when the button wheel is rotated or tilted. Similarly, if **ManipulationTranslateY**/**ManipulationTranslateRailsY** is enabled and **ManipulationTranslateX**/**ManipulationTranslateRailsX** is disabled through [GestureSettings](gesturerecognizer_gesturesettings.md) then scrolling is applied only along the vertical axis when the button wheel is rotated or tilted.

## -examples

## -see-also
