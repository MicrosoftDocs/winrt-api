---
-api-id: T:Windows.UI.Input.Preview.Injection.InjectedInputPointerInfo
-api-type: winrt struct
---

<!-- Structure syntax.
public struct InjectedInputPointerInfo 
-->

# InjectedInputPointerInfo

## -description
Contains basic pointer information common to all pointer types.

## -struct-fields

### -field PointerId
A unique identifier for the lifetime of the pointer. A pointer is created when it enters detection range and destroyed when it leaves detection range. If a pointer goes out of detection range and then returns, it is treated as a new pointer and might be assigned a new identifier.
    

### -field PointerOptions
The various options, or modifiers, used to simulate pointer input through [InjectedInputMouseInfo](injectedinputmouseinfo.md), [InjectedInputPenInfo](injectedinputpeninfo.md), and [InjectedInputTouchInfo](injectedinputtouchinfo.md).
    

### -field PixelLocation
The screen coordinates of the pointer in device-independent pixel (DIP).
    

### -field TimeOffsetInMilliseconds
The baseline, or reference value, in milliseconds, for timed input events such as a double click/tap.
    

### -field PerformanceCount
A high resolution (less than one microsecond) time stamp used for time-interval measurements.
    

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

[InjectedInputPenInfo.PointerInfo](injectedinputpeninfo_pointerinfo.md), [InjectedInputTouchInfo.PointerInfo](injectedinputtouchinfo_pointerinfo.md), [Simulate user input through input injection](/windows/uwp/design/input/input-injection)
