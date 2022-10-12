---
-api-id: P:Windows.UI.Input.RadialControllerConfiguration.ActiveControllerWhenMenuIsSuppressed
-api-type: winrt property
---

<!-- Property syntax.
public RadialController ActiveControllerWhenMenuIsSuppressed { get;  set; }
-->

# Windows.UI.Input.RadialControllerConfiguration.ActiveControllerWhenMenuIsSuppressed

## -description
Gets or sets the [RadialController](radialcontroller.md) to activate when the [RadialController](radialcontroller.md) menu is suppressed.

## -property-value

## -remarks
When the menu is suppressed, the press-and-hold gesture does not cause it to be displayed.

Listen for the [ButtonHolding](radialcontroller_buttonholding.md) event to implement custom handling of the press-and-hold gesture.

## -see-also

[IsMenuSuppressed](radialcontrollerconfiguration_ismenusuppressed.md), [Surface Dial interactions](/windows/uwp/input-and-devices/windows-wheel-interactions), [Universal Windows Platform samples (C# and C++)](https://go.microsoft.com/fwlink/?linkid=832713), [Windows desktop sample](https://aka.ms/radialcontrollerclassicsample)

## -examples

