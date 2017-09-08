---
-api-id: N:Windows.UI.Input.Preview.Injection
-api-type: winrt namespace
---

# Windows.UI.Input.Preview.Injection

## -description
Provides support for programmatically generating and automating input from a variety of devices such as keyboard, mouse, touch, pen, and gamepad.

> [!NOTE]
> The APIs in this namespace require the inputInjectionBrokered [restricted capability](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations#special-and-restricted-capabilities).

## -remarks
Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`



## -examples
Here, we show how to inject a single touch contact and corresponding pointer up input events.

```csharp
private void InjectTouch_Button_Click(object sender, RoutedEventArgs e)
{
    InputInjector inputInjector = InputInjector.TryCreate();

    if (inputInjector != null)
    {
        try
        {
            inputInjector.InitializeTouchInjection(
                InjectedInputVisualizationMode.Indirect);

            // Each element in the list represents a single contact.
            // Multiple elements represent multiple contacts. 
            inputInjector.InjectTouchInput(
                new List<InjectedInputTouchInfo>
            {
                new InjectedInputTouchInfo
                {
                    Contact = new InjectedInputRectangle {
                        Top = 50, Bottom = 50, Left = 40, Right = 40 },
                    PointerInfo = new InjectedInputPointerInfo
                    {
                        // PerformanceCount default is 0.
                        // This uses the current tick (or TimeOffsetInMS) in milliseconds. 
                        // The first value passed in becomes a baseline or reference value 
                        // and is treated as a zero time offset. Each subsequent value must 
                        // be larger than the preceeding value. The difference is used
                        // to calculate timed events such as double click events.
                        //
                        // Alternatively, the caller can pass in the value of
                        // QueryPerformanceCounter into the PerformanceCount field.
                        PixelLocation = new InjectedInputPoint
                        {
                            PositionX = 40, PositionY = 50
                        },
                        // PointerID is assigned to a pointer during it’s lifetime in contact with
                        // a touch device. 
                        // The scope of this ID is the InputInjector instance (between a
                        // call to Initialize and the corresponding call to Uninitialize).
                        PointerOptions = InjectedInputPointerOptions.InContact,
                        PointerId = 1
                    },
                    Pressure = 1.0,
                    TouchParameters = 
                    InjectedInputTouchParameters.Pressure | 
                    InjectedInputTouchParameters.Contact
                }
            });
            // Copied from some test tool code...
            System.Threading.Tasks.Task.Delay(100).Wait();

            inputInjector.InjectTouchInput(
                new List<InjectedInputTouchInfo> {
                new InjectedInputTouchInfo {
                    Contact = new InjectedInputRectangle
                    {
                        Top = 50,
                        Bottom = 50,
                        Left = 40,
                        Right = 40
                    },
                    PointerInfo = new InjectedInputPointerInfo {
                        PixelLocation = new InjectedInputPoint {
                            PositionX = 40, PositionY = 50
                        },
                        PointerOptions = InjectedInputPointerOptions.PointerUp,
                        PointerId = 1,
                    },
                    Pressure = 0.0,
                    TouchParameters = 
                    InjectedInputTouchParameters.Pressure | 
                    InjectedInputTouchParameters.Contact
                }
            });
        }
        catch (ArgumentException args)
        {
            // Handle exception.
        }
    }
}
```

## -see-also
[Windows.Devices.Input](../windows.devices.input/windows_devices_input.md), [Windows.UI.Core](../windows.ui.core/windows_ui_core.md), [Windows.UI.Input.Inking](../windows.ui.input.inking/windows_ui_input_inking.md), [Windows.UI.Xaml.Input](../windows.ui.xaml.input/windows_ui_xaml_input.md), [Input &amp; devices](https://developer.microsoft.com/windows/design/inputs-devices), [Interaction primer](https://msdn.microsoft.com/windows/uwp/input-and-devices/input-primer), [User interaction mode sample](http://go.microsoft.com/fwlink/p/?LinkID=619894), [Focus visuals sample](http://go.microsoft.com/fwlink/p/?LinkID=619895), [Input: Device capabilities sample](http://go.microsoft.com/fwlink/p/?linkid=231530), [Input: Ink sample](http://go.microsoft.com/fwlink/p/?linkid=231622), [Input: Manipulations and gestures (JavaScript) sample](http://go.microsoft.com/fwlink/p/?linkid=231638), [Input: Simplified ink  sample](http://go.microsoft.com/fwlink/p/?linkid=246570), [Input: Windows 8 gestures sample](http://go.microsoft.com/fwlink/p/?LinkId=264995), [Input: XAML user input events sample](http://go.microsoft.com/fwlink/p/?linkid=226855), [XAML scrolling, panning, and zooming sample](http://go.microsoft.com/fwlink/p/?linkid=251717), [DirectX touch input sample](http://go.microsoft.com/fwlink/p/?LinkID=231627), [Input: Manipulations and gestures (C++) sample](http://go.microsoft.com/fwlink/p/?linkid=231605), [Input: Touch hit testing sample](http://go.microsoft.com/fwlink/p/?linkid=231590), [Input source identification sample](http://go.microsoft.com/fwlink/p/?LinkID=267908), [Touch injection sample](http://go.microsoft.com/fwlink/p/?LinkID=267906), [Win32 touch hit-testing sample](http://go.microsoft.com/fwlink/p/?LinkID=267915)