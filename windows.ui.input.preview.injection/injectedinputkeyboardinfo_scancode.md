---
-api-id: P:Windows.UI.Input.Preview.Injection.InjectedInputKeyboardInfo.ScanCode
-api-type: winrt property
---

<!-- Property syntax
public ushort ScanCode { get;  set; }
-->

# Windows.UI.Input.Preview.Injection.InjectedInputKeyboardInfo.ScanCode

## -description
Gets or sets an OEM, device-dependent identifier for a key on a physical keyboard.

A keyboard generates two scan codes when the user types a key—one when the user presses the key and another when the user releases the key.

> [!NOTE]
> The APIs in this namespace require the inputInjectionBrokered [restricted capability](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations#special-and-restricted-capabilities).

## -property-value
The device-dependent identifier for the key on the keyboard.

## -remarks
Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`


## -examples

## -see-also
