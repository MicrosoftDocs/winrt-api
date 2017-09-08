---
-api-id: P:Windows.UI.Input.Preview.Injection.InjectedInputKeyboardInfo.VirtualKey
-api-type: winrt property
---

<!-- Property syntax
public ushort VirtualKey { get;  set; }
-->

# Windows.UI.Input.Preview.Injection.InjectedInputKeyboardInfo.VirtualKey

## -description
Gets or sets a device-independent identifier mapped to a key on a physical or software keyboard.

> [!NOTE]
> The APIs in this namespace require the inputInjectionBrokered [restricted capability](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations#special-and-restricted-capabilities).

## -property-value
The device-independent identifier for the key on the keyboard.

## -remarks
Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`


## -examples

## -see-also
