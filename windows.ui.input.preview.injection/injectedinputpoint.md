---
-api-id: T:Windows.UI.Input.Preview.Injection.InjectedInputPoint
-api-type: winrt struct
---

<!-- Structure syntax.
public struct InjectedInputPoint 
-->

# InjectedInputPoint

## -description
Contains the screen coordinates of the pointer in device-independent pixel (DIP).

## -struct-fields

### -field PositionX
The x-coordinate of the pointer in device-independent pixel (DIP).
    

### -field PositionY
The y-coordinate of the pointer in device-independent pixel (DIP).
    

## -remarks

> [!Important]
> The APIs in this namespace require the inputInjectionBrokered [restricted capability](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations#special-and-restricted-capabilities).

Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`

## -examples

Here are some downloadable samples demonstrating basic input and input injection:

- [Input injection sample (mouse to touch)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-input-injection-mouse-to-touch.zip)
- [Touch injection sample](https://go.microsoft.com/fwlink/p/?LinkID=267906)
- [Input: XAML user input events sample](https://go.microsoft.com/fwlink/p/?linkid=226855)

## -see-also

[InjectedInputPenInfo.PointerInfo](injectedinputpeninfo_pointerinfo.md), [InjectedInputTouchInfo.PointerInfo](injectedinputtouchinfo_pointerinfo.md), [Simulate user input through input injection](https://docs.microsoft.com/windows/uwp/design/input/input-injection)
