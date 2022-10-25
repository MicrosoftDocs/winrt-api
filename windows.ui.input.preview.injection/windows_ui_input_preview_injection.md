---
-api-id: N:Windows.UI.Input.Preview.Injection
-api-type: winrt namespace
---

# Windows.UI.Input.Preview.Injection

## -description
Provides support for programmatically generating and automating input from a variety of devices such as keyboard, mouse, touch, pen, and gamepad.

> [!Important]
> The APIs in this namespace require the inputInjectionBrokered [restricted capability](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities).

## -remarks
Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`


## -examples

Here's an example of a touch input injection function.

First, we call [TryCreate](/uwp/api/windows.ui.input.preview.injection.inputinjector.trycreate) to instantiate the [InputInjector](/uwp/api/windows.ui.input.preview.injection.inputinjector) object.

Then, we call [InitializeTouchInjection](/uwp/api/windows.ui.input.preview.injection.inputinjector.initializetouchinjection) with an [InjectedInputVisualizationMode](/uwp/api/windows.ui.input.preview.injection.injectedinputvisualizationmode) of `Default`.

After calculating the point of injection, we call [InjectedInputTouchInfo](/uwp/api/windows.ui.input.preview.injection.injectedinputtouchinfo) to initialize the list of touch points to inject (for this example, we create one touch point corresponding to the mouse input pointer).

Finally, we call [InjectTouchInput](/uwp/api/windows.ui.input.preview.injection.inputinjector.injecttouchinput) twice, the first for a pointer down and the second for a pointer up.

```csharp
/// <summary>
/// Inject touch input on injection target corresponding 
/// to mouse click on input target.
/// </summary>
/// <param name="pointerPoint">The mouse click pointer.</param>
private void InjectTouchForMouse(PointerPoint pointerPoint)
{
    // Create the touch injection object.
    _inputInjector = InputInjector.TryCreate();

    if (_inputInjector != null)
    {
        _inputInjector.InitializeTouchInjection(
            InjectedInputVisualizationMode.Default);

        // Create a unique pointer ID for the injected touch pointer.
        // Multiple input pointers would require more robust handling.
        uint pointerId = pointerPoint.PointerId + 1;

        // Get the bounding rectangle of the app window.
        Rect appBounds =
            Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().VisibleBounds;

        // Get the top left screen coordinates of the app window rect.
        Point appBoundsTopLeft = new Point(appBounds.Left, appBounds.Top);

        // Get a reference to the input injection area.
        GeneralTransform injectArea =
            ContainerInject.TransformToVisual(Window.Current.Content);

        // Get the top left screen coordinates of the input injection area.
        Point injectAreaTopLeft = injectArea.TransformPoint(new Point(0, 0));

        // Get the screen coordinates (relative to the input area) 
        // of the input pointer.
        int pointerPointX = (int)pointerPoint.Position.X;
        int pointerPointY = (int)pointerPoint.Position.Y;

        // Create the point for input injection and calculate its screen location.
        Point injectionPoint =
            new Point(
                appBoundsTopLeft.X + injectAreaTopLeft.X + pointerPointX,
                appBoundsTopLeft.Y + injectAreaTopLeft.Y + pointerPointY);

        // Create a touch data point for pointer down.
        // Each element in the touch data list represents a single touch contact. 
        // For this example, we're mirroring a single mouse pointer.
        List<InjectedInputTouchInfo> touchData =
            new List<InjectedInputTouchInfo>
            {
                new InjectedInputTouchInfo
                {
                    Contact = new InjectedInputRectangle
                    {
                        Left = 30, Top = 30, Bottom = 30, Right = 30
                    },
                    PointerInfo = new InjectedInputPointerInfo
                    {
                        PointerId = pointerId,
                        PointerOptions =
                        InjectedInputPointerOptions.PointerDown |
                        InjectedInputPointerOptions.InContact |
                        InjectedInputPointerOptions.New,
                        TimeOffsetInMilliseconds = 0,
                        PixelLocation = new InjectedInputPoint
                        {
                            PositionX = (int)injectionPoint.X ,
                            PositionY = (int)injectionPoint.Y
                        }
                },
                Pressure = 1.0,
                TouchParameters =
                    InjectedInputTouchParameters.Pressure |
                    InjectedInputTouchParameters.Contact
            }
        };

        // Inject the touch input. 
        _inputInjector.InjectTouchInput(touchData);

        // Create a touch data point for pointer up.
        touchData = new List<InjectedInputTouchInfo>
        {
            new InjectedInputTouchInfo
            {
                PointerInfo = new InjectedInputPointerInfo
                {
                    PointerId = pointerId,
                    PointerOptions = InjectedInputPointerOptions.PointerUp
                }
            }
        };

        // Inject the touch input. 
        _inputInjector.InjectTouchInput(touchData);
    }
}
```

Here are some downloadable samples demonstrating basic input and input injection:

- [Input injection sample (mouse to touch)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-input-injection-mouse-to-touch.zip)
- [Touch injection sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/411c271e537727d737a53fa2cbe99eaecac00cc0/Official%20Windows%20Platform%20Sample/Input%20Touch%20injection%20sample)
- [Input: XAML user input events sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/411c271e537727d737a53fa2cbe99eaecac00cc0/Official%20Windows%20Platform%20Sample/Input%20XAML%20user%20input%20events%20sample)

## -see-also

[InitializeTouchInjection](inputinjector_initializetouchinjection_1509714255.md), [Simulate user input through input injection](/windows/uwp/design/input/input-injection)
