---
-api-id: T:Windows.UI.Input.Preview.Injection.InjectedInputKeyOptions
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Input.Preview.Injection.InjectedInputKeyOptions : uint
-->

# InjectedInputKeyOptions

## -description
Specifies the various options, or modifiers, used to simulate input from physical or virtual keyboards through [InjectedInputKeyboardInfo](injectedinputkeyboardinfo.md).

## -enum-fields
### -field None:0
No keystroke modifier. Default.

### -field ExtendedKey:1
The key is an extended key, such as a function key or a key on the numeric keypad.

### -field KeyUp:2
The key is released.

### -field Unicode:4
The key is a Unicode value.

### -field ScanCode:8
The OEM, device-dependent identifier for the key on the keyboard.A keyboard generates two scan codes when the user types a key—one when the user presses the key and another when the user releases the key.

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
