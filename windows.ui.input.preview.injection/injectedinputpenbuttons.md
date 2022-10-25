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
> The APIs in this namespace require the inputInjectionBrokered [restricted capability](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities).

Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`

## -examples

Here are some downloadable samples demonstrating basic input and input injection:

- [Input injection sample (mouse to touch)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-input-injection-mouse-to-touch.zip)
- [Touch injection sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/411c271e537727d737a53fa2cbe99eaecac00cc0/Official%20Windows%20Platform%20Sample/Input%20Touch%20injection%20sample)
- [Input: XAML user input events sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/411c271e537727d737a53fa2cbe99eaecac00cc0/Official%20Windows%20Platform%20Sample/Input%20XAML%20user%20input%20events%20sample)

## -see-also

[Simulate user input through input injection](/windows/uwp/design/input/input-injection)
