---
-api-id: T:Windows.UI.Input.Preview.Injection.InjectedInputPenButtons
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Input.Preview.Injection.InjectedInputPenButtons : uint
-->

# InjectedInputPenButtons

## -description
Specifies the pen options used to simulate pen input through [InjectedInputPenInfo](injectedinputpeninfo.md).

## -enum-fields
### -field None:0
No pen buttons are pressed. Default.

### -field Barrel:1
The barrel button is pressed.

### -field Inverted:2
The pen is inverted.

### -field Eraser:4
The eraser button is pressed.

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

## -see-also

### Conceptual

[Gaze interactions and eye tracking in UWP apps](https://docs.microsoft.com/windows/uwp/design/input/gaze-interactions)

### Samples

- [Simulate user input through input injection](https://review.docs.microsoft.com/windows/uwp/design/input/input-injection?branch=kbridge-inputinjection)
- [Input injection sample (mouse to touch)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-input-injection-mouse-to-touch.zip)
- [Touch injection sample](http://go.microsoft.com/fwlink/p/?LinkID=267906)
- [Input: XAML user input events sample](http://go.microsoft.com/fwlink/p/?linkid=226855)
