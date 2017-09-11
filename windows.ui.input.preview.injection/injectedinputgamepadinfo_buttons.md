---
-api-id: P:Windows.UI.Input.Preview.Injection.InjectedInputGamepadInfo.Buttons
-api-type: winrt property
---

<!-- Property syntax.
public GamepadButtons Buttons { get;  set; }
-->

# Windows.UI.Input.Preview.Injection.InjectedInputGamepadInfo.Buttons

## -description
Gets or sets the the gamepad buttons used for input injection.

> [!NOTE]
> The APIs in this namespace require the inputInjectionBrokered [restricted capability](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations#special-and-restricted-capabilities).

## -property-value
One or more gamepad buttons used for input injection.

## -remarks
Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`


## -see-also

## -examples

