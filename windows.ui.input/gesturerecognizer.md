---
-api-id: T:Windows.UI.Input.GestureRecognizer
-api-type: winrt class
---

<!-- Class syntax.
public class GestureRecognizer : Windows.UI.Input.IGestureRecognizer
-->

# Windows.UI.Input.GestureRecognizer

## -description

Provides gesture and manipulation recognition, event listeners, and settings.

## -remarks

You can create a gesture object for each appropriate element when your app starts. However, this approach might not scale well depending on the number of gesture objects you need to create (for example, a jigsaw puzzle with hundreds of pieces).

In this case, you can create gesture objects dynamically on a [pointerdown](https://msdn.microsoft.com/en-us/library/jj191898(v=vs.85).aspx) event and destroy them on an [MSGestureEnd](https://msdn.microsoft.com/en-us/library/jj191886(v=vs.85).aspx) event. This approach scales well, but does incur some overhead due to creating and releasing these objects.

Alternatively, you can statically allocate and dynamically manage a pool of reusable gesture objects.

> [!NOTE]
> : This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](http://go.microsoft.com/fwlink/p/?linkid=258275) and [Using Windows Runtime objects in a multithreaded environment (.NET)](http://go.microsoft.com/fwlink/p/?linkid=258277).

For more detail on how to use cross-slide functionality, see [Guidelines for cross-slide](http://msdn.microsoft.com/library/897555e2-c567-4bbe-b600-553daeb223d5). The threshold distances used by the cross-slide interaction are shown in the following diagram.

<img src="images/crossslide_threshold.png" border="1" width="536" height="276" alt="Screen shot showing the select and drag and drop processes." />

The [PivotRadius](gesturerecognizer_pivotradius.md) and [PivotCenter](gesturerecognizer_pivotcenter.md) properties are used only when single pointer input is detected. They have no effect on multiple pointer input. The value for these properties should be updated regularly during the interaction.

Rotation is supported by a [GestureRecognizer](gesturerecognizer.md) only when [manipulationRotate](gesturesettings.md) is set through the [GestureSettings](gesturerecognizer_gesturesettings.md) property.

Rotation is not supported for single pointer input if the value of [PivotRadius](gesturerecognizer_pivotradius.md) is set to 0.

## -examples

Here we set up a [GestureRecognizer](gesturerecognizer.md) object with a collection of input event handlers for processing both pointer and gesture input. For more information on how to listen to and handle Windows Runtime events, see [https://docs.microsoft.com/en-us/windows/uwp/xaml-platform/events-and-routed-events-overview](https://docs.microsoft.com/windows/uwp/xaml-platform/events-and-routed-events-overview). See the [Basic input sample](http://go.microsoft.com/fwlink/p/?LinkId=620514) for the full implementation.

```csharp
class ManipulationInputProcessor
{
    GestureRecognizer recognizer;
    UIElement element;
    UIElement reference;
    TransformGroup cumulativeTransform;
    MatrixTransform previousTransform;
    CompositeTransform deltaTransform;
    
    public ManipulationInputProcessor(GestureRecognizer gestureRecognizer, UIElement target, UIElement referenceFrame)
    {
        recognizer = gestureRecognizer;
        element = target;
        reference = referenceFrame;
        // Initialize the transforms that will be used to manipulate the shape
        InitializeTransforms();
        // The GestureSettings property dictates what manipulation events the
        // Gesture Recognizer will listen to.  This will set it to a limited
        // subset of these events.
        recognizer.GestureSettings = GenerateDefaultSettings();
        // Set up pointer event handlers. These receive input events that are used by the gesture recognizer.
        element.PointerPressed += OnPointerPressed;
        element.PointerMoved += OnPointerMoved;
        element.PointerReleased += OnPointerReleased;
        element.PointerCanceled += OnPointerCanceled;
        // Set up event handlers to respond to gesture recognizer output
        recognizer.ManipulationStarted += OnManipulationStarted;
        recognizer.ManipulationUpdated += OnManipulationUpdated;
        recognizer.ManipulationCompleted += OnManipulationCompleted;
        recognizer.ManipulationInertiaStarting += OnManipulationInertiaStarting;
    }
    
    public void InitializeTransforms()
    {
        cumulativeTransform = new TransformGroup();
        deltaTransform = new CompositeTransform();
        previousTransform = new MatrixTransform() { Matrix = Matrix.Identity };
        cumulativeTransform.Children.Add(previousTransform);
        cumulativeTransform.Children.Add(deltaTransform);
        element.RenderTransform = cumulativeTransform;
    }
    
    // Return the default GestureSettings for this sample
    GestureSettings GenerateDefaultSettings()
    {
        return GestureSettings.ManipulationTranslateX |
            GestureSettings.ManipulationTranslateY |
            GestureSettings.ManipulationRotate |
            GestureSettings.ManipulationTranslateInertia |
            GestureSettings.ManipulationRotateInertia;
    }
    
    // Route the pointer pressed event to the gesture recognizer.
    // The points are in the reference frame of the canvas that contains the rectangle element.
    void OnPointerPressed(object sender, PointerRoutedEventArgs args)
    {
        // Set the pointer capture to the element being interacted with so that only it
        // will fire pointer-related events
        element.CapturePointer(args.Pointer);
        // Feed the current point into the gesture recognizer as a down event
        recognizer.ProcessDownEvent(args.GetCurrentPoint(reference));
    }
    
    // Route the pointer moved event to the gesture recognizer.
    // The points are in the reference frame of the canvas that contains the rectangle element.
    void OnPointerMoved(object sender, PointerRoutedEventArgs args)
    {
        // Feed the set of points into the gesture recognizer as a move event
        recognizer.ProcessMoveEvents(args.GetIntermediatePoints(reference));
    }
    
    // Route the pointer released event to the gesture recognizer.
    // The points are in the reference frame of the canvas that contains the rectangle element.
    void OnPointerReleased(object sender, PointerRoutedEventArgs args)
    {
        // Feed the current point into the gesture recognizer as an up event
        recognizer.ProcessUpEvent(args.GetCurrentPoint(reference));
        // Release the pointer
        element.ReleasePointerCapture(args.Pointer);
    }
    
    // Route the pointer canceled event to the gesture recognizer.
    // The points are in the reference frame of the canvas that contains the rectangle element.
    void OnPointerCanceled(object sender, PointerRoutedEventArgs args)
    {
        recognizer.CompleteGesture();
        element.ReleasePointerCapture(args.Pointer);
    }
    
    // When a manipulation begins, change the color of the object to reflect
    // that a manipulation is in progress
    void OnManipulationStarted(object sender, ManipulationStartedEventArgs e)
    {
        Border b = element as Border;
        b.Background = new SolidColorBrush(Windows.UI.Colors.DeepSkyBlue);
    }
    
    // Process the change resulting from a manipulation
    void OnManipulationUpdated(object sender, ManipulationUpdatedEventArgs e)
    {
        previousTransform.Matrix = cumulativeTransform.Value;
        // Get the center point of the manipulation for rotation
        Point center = new Point(e.Position.X, e.Position.Y);
        deltaTransform.CenterX = center.X;
        deltaTransform.CenterY = center.Y;
        // Look at the Delta property of the ManipulationDeltaRoutedEventArgs to retrieve
        // the rotation, X, and Y changes
        deltaTransform.Rotation = e.Delta.Rotation;
        deltaTransform.TranslateX = e.Delta.Translation.X;
        deltaTransform.TranslateY = e.Delta.Translation.Y;
    }
    
    // When a manipulation that's a result of inertia begins, change the color of the
    // the object to reflect that inertia has taken over
    void OnManipulationInertiaStarting(object sender, ManipulationInertiaStartingEventArgs e)
    {
        Border b = element as Border;
        b.Background = new SolidColorBrush(Windows.UI.Colors.RoyalBlue);
    }
    
    // When a manipulation has finished, reset the color of the object
    void OnManipulationCompleted(object sender, ManipulationCompletedEventArgs e)
    {
        Border b = element as Border;
        b.Background = new SolidColorBrush(Windows.UI.Colors.LightGray);
    }
    
    // Modify the GestureSettings property to only allow movement on the X axis
    public void LockToXAxis()
    {
        recognizer.CompleteGesture();
        recognizer.GestureSettings |= GestureSettings.ManipulationTranslateY | GestureSettings.ManipulationTranslateX;
        recognizer.GestureSettings ^= GestureSettings.ManipulationTranslateY;
    }
    
    // Modify the GestureSettings property to only allow movement on the Y axis
    public void LockToYAxis()
    {
        recognizer.CompleteGesture();
        recognizer.GestureSettings |= GestureSettings.ManipulationTranslateY | GestureSettings.ManipulationTranslateX;
        recognizer.GestureSettings ^= GestureSettings.ManipulationTranslateX;
    }
    
    // Modify the GestureSettings property to allow movement on both the the X and Y axes
    public void MoveOnXAndYAxes()
    {
        recognizer.CompleteGesture();
        recognizer.GestureSettings |= GestureSettings.ManipulationTranslateX | GestureSettings.ManipulationTranslateY;
    }
    
    // Modify the GestureSettings property to enable or disable inertia based on the passed-in value
    public void UseInertia(bool inertia)
    {
        if (!inertia)
        {
            recognizer.CompleteGesture();
            recognizer.GestureSettings ^= GestureSettings.ManipulationTranslateInertia | GestureSettings.ManipulationRotateInertia;
        }
        else
        {
            recognizer.GestureSettings |= GestureSettings.ManipulationTranslateInertia | GestureSettings.ManipulationRotateInertia;
        }
    }
    
    public void Reset()
    {
        element.RenderTransform = null;
        recognizer.CompleteGesture();
        InitializeTransforms();
        recognizer.GestureSettings = GenerateDefaultSettings();
    }
}
```

## -see-also

### Reference

- [Windows.UI.Input Classes](windows_ui_input_classes.md)
- [Windows.Devices.Input](../windows.devices.input/windows_devices_input.md)
- [Windows.UI.Core](../windows.ui.core/windows_ui_core.md)
- [Windows.UI.Input](windows_ui_input.md)
- [Windows.UI.Input.Inking](../windows.ui.input.inking/windows_ui_input_inking.md)
- [Windows.UI.Xaml.Input](../windows.ui.xaml.input/windows_ui_xaml_input.md)

### Conceptual

- [Custom user interactions](http://msdn.microsoft.com/library/9403c46c-60da-4c13-a381-6fbd069dd9ce)
- [UX guidelines for custom user interactions](http://msdn.microsoft.com/library/52f9607d-e2d0-44e4-9e1c-f856f7072a1e)
- [Touch design guidelines](http://msdn.microsoft.com/library/3250f729-4fdd-4ad4-b856-b8ba575c3375)

### Samples

- [User interaction mode sample](http://go.microsoft.com/fwlink/p/?LinkID=619894)
- [Focus visuals sample](http://go.microsoft.com/fwlink/p/?LinkID=619895)
- [Basic input sample](http://go.microsoft.com/fwlink/p/?LinkId=620514)
- [Direct3D game sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Simple3DGameDX)
- [DirectX and XAML game sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Simple3DGameXaml)

### Archived samples

- [Input: Manipulations and gestures sample](http://go.microsoft.com/fwlink/p/?linkid=231638)
- [Input: XAML user input events sample](http://go.microsoft.com/fwlink/p/?linkid=226855)
- [XAML scrolling, panning, and zooming sample](http://go.microsoft.com/fwlink/p/?linkid=251717)
- [DirectX touch input sample](http://go.microsoft.com/fwlink/p/?LinkID=231627)
- [Input: Manipulations and gestures sample](http://go.microsoft.com/fwlink/p/?linkid=231605)
