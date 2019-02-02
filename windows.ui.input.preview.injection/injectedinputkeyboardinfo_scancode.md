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

> [!NOTE]
> A keyboard generates two scan codes when the user types a key—one when the user presses the key and another when the user releases the key.

## -property-value
The device-dependent identifier for the key on the keyboard.

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
- [Touch injection sample](https://go.microsoft.com/fwlink/p/?LinkID=267906)
- [Input: XAML user input events sample](https://go.microsoft.com/fwlink/p/?linkid=226855)
