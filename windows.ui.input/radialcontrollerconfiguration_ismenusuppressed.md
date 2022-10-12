---
-api-id: P:Windows.UI.Input.RadialControllerConfiguration.IsMenuSuppressed
-api-type: winrt property
---

<!-- Property syntax.
public bool IsMenuSuppressed { get;  set; }
-->

# Windows.UI.Input.RadialControllerConfiguration.IsMenuSuppressed

## -description
Gets or sets whether the [RadialController](radialcontroller.md) menu can be displayed.

## -property-value
**true** if the menu is suppressed. Otherwise, **false**.

## -remarks
When the menu is suppressed, the press-and-hold gesture does not cause it to be displayed.

Listen for the [ButtonHolding](radialcontroller_buttonholding.md) event to implement custom handling of the press-and-hold gesture.

## -see-also

[ActiveControllerWhenMenuIsSuppressed](radialcontrollerconfiguration_activecontrollerwhenmenuissuppressed.md), [Surface Dial interactions](/windows/uwp/input-and-devices/windows-wheel-interactions), [Universal Windows Platform samples (C# and C++)](https://go.microsoft.com/fwlink/?linkid=832713), [Windows desktop sample](https://aka.ms/radialcontrollerclassicsample)

## -examples

