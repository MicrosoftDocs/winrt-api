---
-api-id: M:Windows.UI.Input.Preview.Injection.InputInjector.InitializePenInjection(Windows.UI.Input.Preview.Injection.InjectedInputVisualizationMode)
-api-type: winrt method
---

<!-- Method syntax
public void InitializePenInjection(Windows.UI.Input.Preview.Injection.InjectedInputVisualizationMode visualMode)
-->

# Windows.UI.Input.Preview.Injection.InputInjector.InitializePenInjection

## -description
Initializes a virtual pen device that can synthesize input events and provide corresponding input data to the system. 

## -parameters
### -param visualMode
The visual feedback mode for pen input injection.

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

[UninitializePenInjection](inputinjector_uninitializepeninjection_664142813.md), [Simulate user input through input injection](/windows/uwp/design/input/input-injection)
