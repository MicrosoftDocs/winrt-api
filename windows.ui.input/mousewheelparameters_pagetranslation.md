---
-api-id: P:Windows.UI.Input.MouseWheelParameters.PageTranslation
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Point PageTranslation { get;  set; }
-->

# Windows.UI.Input.MouseWheelParameters.PageTranslation

## -description

Gets or sets the conversion factors for both page width and height units, in device-independent pixel (DIP).

## -property-value

The conversion factors for the page width (x) and height (y).

## -remarks

The following image shows the default control panel settings for the button wheel. These settings map a single detent to a specific unit of distance in the UI (page width and height). PageTranslation provides the means to redefine these distances and specify the size of a page in terms of device-independent pixel (DIP).

:::image type="content" source="images/mouseproperties-buttonwheel.png" alt-text="Screenshot of the Mouse Settings page showing mouse wheel scrolling settings.":::
*Screenshot of the Mouse Settings page showing mouse wheel scrolling settings.*

If the wheel button is set to scroll one screen (page) at a time for each detent and the value of PageTranslation is set to (1200,800), vertical scrolling is applied at 1 x 800 device-independent pixel (DIP) per detent. Horizontal scrolling distance through the mouse tilt wheel is dependent on the value of [CharTranslation](mousewheelparameters_chartranslation.md).

> [!NOTE]
> If **ManipulationTranslateY**/**ManipulationTranslateRailsY** is disabled and **ManipulationTranslateX**/**ManipulationTranslateRailsX** is enabled through [GestureSettings](gesturerecognizer_gesturesettings.md) then scrolling is applied only along the horizontal axis when the button wheel is rotated or tilted. In the previous example, the result is horizontal scrolling of 1 x 1200 device-independent pixel (DIP) per detent. Similarly, if **ManipulationTranslateY**/**ManipulationTranslateRailsY** is enabled and **ManipulationTranslateX**/**ManipulationTranslateRailsX** is disabled through [GestureSettings](gesturerecognizer_gesturesettings.md) then scrolling is applied only along the vertical axis when the button wheel is rotated or tilted.

## -examples

## -see-also

[GestureRecognizer.MouseWheelParameters](gesturerecognizer_mousewheelparameters.md), [CharTranslation](mousewheelparameters_chartranslation.md)
