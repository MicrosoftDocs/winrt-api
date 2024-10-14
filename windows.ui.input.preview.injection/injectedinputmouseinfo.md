---
-api-id: T:Windows.UI.Input.Preview.Injection.InjectedInputMouseInfo
-api-type: winrt class
---

<!-- Class syntax.
public class InjectedInputMouseInfo : Windows.UI.Input.Preview.Injection.IInjectedInputMouseInfo
-->

# Windows.UI.Input.Preview.Injection.InjectedInputMouseInfo

## -description

Represents programmatically generated mouse input.

## -remarks

> [!Important]
> The APIs in this namespace require the inputInjectionBrokered [restricted capability](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) to be declared in the application manifest. For more information on app capability requirements, see [App capability declarations](/windows/uwp/packaging/app-capability-declarations).

To use the input injection APIs, open the Package.appxmanifest file and add the following (the `rescap` namespace hosts the restricted capabilities, whuch lets you declare the `inputInjectionBrokered` capability in the `Capabilities` section).

- To `<Package>`
  - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities" IgnorableNamespaces="rescap"`
- In `<Capabilities>`
  - `<rescap:Capability Name="inputInjectionBrokered" />`

## -examples

The following example shows how to inject basic mouse input.

1. Create an instance of an [InputInjector](inputinjector.md) object by calling its static [TryCreate](inputinjector_trycreate_508033141.md) method and use the [InputInjector.InjectMouseInput](inputinjector_injectmouseinput_469589153.md) method to set up for the mouse input.

    ```csharp
    InjectedInputMouseInfo inputInfo = new InjectedInputMouseInfo();
    InputInjector inputInjector = InputInjector.TryCreate();
    inputInjector.InjectMouseInput(new[] { inputInfo });
    ```

1. Initiate mouse input through the [InjectedInputMouseInfo](injectedinputmouseinfo.md) class using [InjectedInputMouseOptions](injectedinputmouseoptions.md) to specify the input action. Here we use the [DeltaX](injectedinputmouseinfo_deltax.md) and [DeltaY](injectedinputmouseinfo_deltay.md) properties to move the mouse pointer to the right 20 pixels and down 20 pixels.

    ```csharp
    var inputMouseInfo = new InjectedInputMouseInfo();
    InputInjector inputInjector = InputInjector.TryCreate();
    inputInjector.InjectMouseInput(new[] { inputMouseInfo });

    InjectedInputMouseInfo injectedMouseMove = new InjectedInputMouseInfo
    {
        MouseOptions = InjectedInputMouseOptions.Move,
        DeltaX = 20,
        DeltaY = 20
    };

    inputInjector.InjectMouseInput(new[] { injectedMouseMove });
    ```

1. In this step, we use the [LeftDown](injectedinputmouseoptions.md) and [LeftUp](injectedinputmouseoptions.md) fields and the [MouseOptions](injectedinputmouseinfo_mouseoptions.md) property to simulate a mouse click by pressing and releasing the left mouse button.

    ```csharp
    var down = new InjectedInputMouseInfo
    {
        MouseOptions = InjectedInputMouseOptions.LeftDown
    };
    
    var up = new InjectedInputMouseInfo
    {
        MouseOptions = InjectedInputMouseOptions.LeftUp
    };
    
    inputInjector.InjectMouseInput(new[] { down, up });
    ```

1. Finally, we show how to use the [Wheel](injectedinputmouseoptions.md) field and the [MouseData](injectedinputmouseinfo_mousedata.md) property to simulate a negative mouse wheel rotation.

    ```csharp
    var mouseWheelDetent = -360;

    var injectedMouseWheelDetent = new InjectedInputMouseInfo
    {
        MouseOptions = InjectedInputMouseOptions.Wheel,
        MouseData = (uint)mouseWheelDetent
    };

    inputInjector.InjectMouseInput(new[] { injectedMouseWheelDetent });
    ```

Here are some other downloadable samples that demonstrate basic input and input injection:

- [Input injection sample (mouse to touch)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-input-injection-mouse-to-touch.zip)
- [Touch injection sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/411c271e537727d737a53fa2cbe99eaecac00cc0/Official%20Windows%20Platform%20Sample/Input%20Touch%20injection%20sample)
- [Input: XAML user input events sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/411c271e537727d737a53fa2cbe99eaecac00cc0/Official%20Windows%20Platform%20Sample/Input%20XAML%20user%20input%20events%20sample)

## -see-also

[Simulate user input through input injection](/windows/uwp/design/input/input-injection)
