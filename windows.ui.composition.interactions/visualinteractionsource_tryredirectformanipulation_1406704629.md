---
-api-id: M:Windows.UI.Composition.Interactions.VisualInteractionSource.TryRedirectForManipulation(Windows.UI.Input.PointerPoint)
-api-type: winrt method
---

<!-- Method syntax
public void TryRedirectForManipulation(Windows.UI.Input.PointerPoint pointerPoint)
-->

# Windows.UI.Composition.Interactions.VisualInteractionSource.TryRedirectForManipulation

## -description
Indicates that configured manipulations for the given pointer stream should be sent to the [InteractionTracker](interactiontracker.md), not the app's UI thread, starting at the given PointerPoint.

TryRedirectForManipulation enables the [VisualInteractionSource](visualinteractionsource.md) to redirect the Pointer stream to the [InteractionTracker](interactiontracker.md) if the gesture matches the configuration on the [VisualInteractionSource](visualinteractionsource.md). This method should only be called with Pointer input of the DeviceType Touch.

## -parameters
### -param pointerPoint
Indicates that configured manipulations for the given pointer stream should be sent to the [InteractionTracker](interactiontracker.md), not the app's UI thread, starting at the given PointerPoint.

## -remarks
This method enables the app to indicate that the system (Compositor) should take over any configured manipulations for a given [VisualInteractionSource](visualinteractionsource.md). When TryRedirectForManipulation is called, the frame from the passed in PointerPoint is used as the starting point for the [InteractionTracker](interactiontracker.md) ’s input handling. If the user’s gesture is hit-tested to the visual associated with the [VisualInteractionSource](visualinteractionsource.md) (or one of its children), and the user performs a configured gesture, then the system will manipulate. If the input is hit-tested to another visual or the user performs a non-configured gesture then the input will be sent to the CoreWindow and through XAML’s normal input routing.

If the [VisualInteractionSource](visualinteractionsource.md) reroutes the input stream to the [InteractionTracker](interactiontracker.md), the application will receive a PointerCaptureLost on the UIElement, or a PointerRoutedAway on the CoreWindow. These messages indicate that the input has been sent away from the application UI thread. This method will be most commonly called on PointerPressed.

PrecisionTouchpad input does not require this call and will be automatically routed to the [InteractionTracker](interactiontracker.md) for the appropriate gestures if the InputRedirectionMode has been set to include CapableTouchpad input.

### Limitations

### Async Nature
The nature of this system is asynchronous. By the time the app calls TryRedirectForManipulation and the call reaches the compositor, there will be additional input events that could have made it to the application’s UI thread. In most cases, it is not harmful for the app to have received these events, and the developer can choose to gesture detect app side to determine how to handle the input and mitigate concerns. The app will know whether the system manipulation takes over by receiving a PointerCaptureLost—the same event received when ScrollViewer takes over input handling today. One complication here is that it is possible for a gesture like a “quick flick” (just a short pan) to send the entire input stream, including the PointerReleased, to the application before the compositor can respond. If the app is impacted by these limitations, they can opt to do some amount of gesture detection on their side to ensure the right behavior.

### Integration with XAML Controls Logic

In the quick flick scenario described above where the pan happens to be on a control like a button, the button will detect the pan as a click if it is contained within the button. This is slightly different than how the system GestureRecognizer (which is doing the routing) detects gestures. In order to ensure quick flick type scenarios work correctly with XAML, developers will need to listen for OnTapped on the button rather than just Click if it is within a compositor interaction area.

### Compositor Hit-testing

The hit-test result used for determining if the manipulation is happening on the right visual will be based on the compositor’s hit-testing. Compositor hit-testing is not as robust as XAML hit-testing, so there are cases where results could have a slight discrepancy. 
<!--This outlines the key differences that could impact developers.-->
See the [VisualInteractionSource](visualinteractionsource.md)documentation for more details.

### Integration With Conflicting Custom Gesture Recognizers

Internally, the system GestureRecognizer is being used to route input. Apps can generally get the behavior they want as long as they are using system gesture recognition. If an app is attempting to use a custom recognizer that conflicts with the system recognizer then there could be conflicts where the app expects the compositor to take over and it does not.

## -examples
```csharp

///////////////////////////////////////////////////////////////////////////////////////////////
//
// The following sample describes how to configure a visual to follow input/gestures.  
//
// This is accomplished in three main steps:
//
// 1) Creating a InteractionTracker and setting (or binding) its boundaries.
//
// 2) Creating at least one Interaction source and associating it with the InteractionTracker.
//
// 3) Taking the output of the InteractionTracker and applying it to a Visual's Offset and Scale 
//    properties.
//
// 4) Telling the system to try to handle the manipulation when the PointerPressed occurs
//
///////////////////////////////////////////////////////////////////////////////////////////////

void SetupSimpleInteractionTracker(Visual containerVisual, Visual contentVisual)
{
  //
  // Create the InteractionTracker and set its min/max position and scale.  These could 
  // also be bound to expressions.  Note: The scrollable area can be changed from either 
  // end to facilitate content updates/virtualization.
  //

  _tracker = InteractionTracker.Create(_compositor);

  _tracker.MaxPosition = new Vector3(
  contentVisual.Size.X - containerVisual.Size.X,
  contentVisual.Size.Y - containerVisual.Size.Y,
  0.0f);

  _tracker.MinScale = 0.5f;
  _tracker.MaxScale = 4.0f;


  //
  // Configure the interaction source.  Enable input with inertia on all axes.
  //

  _interactionSource = VisualInteractionSource.Create(_compositor, containerVisual);

  _interactionSource.PositionXSourceMode = InteractionSourceMode.EnabledWithInertia;
  _interactionSource.PositionYSourceMode = InteractionSourceMode.EnabledWithInertia;
  _interactionSource.ScaleSourceMode = InteractionSourceMode.EnabledWithInertia;

  _tracker.InteractionSources.Add(_interactionSource);

  //
  // Register for the pointer pressed event so that we can tell the system to handle the
  // manipulations.
  //

  _rootElement.PointerPressed += OnPointerPressedBasic;

  //
  // Bind the InteractionTracker outputs to the contentVisual.
  //

  var positionExpression = _compositor.CreateExpressionAnimation("-tracker.Position");
  positionExpression.SetReferenceParameter("tracker", _tracker);

  contentVisual.StartAnimation("Offset", positionExpression);


  var scaleExpression = _compositor.CreateExpressionAnimation("Vector3(tracker.Scale, tracker.Scale, 1.0)");

  scaleExpression.SetReferenceParameter("tracker", _tracker);

  contentVisual.StartAnimation("Scale", scaleExpression);
}

private void OnPointerPressedBasic(object sender, PointerRoutedEventArgs e)
{
  //
  // Try to handle the manipulation in the system.
  //
  if (e.Pointer.PointerDeviceType == Windows.Devices.Input.PointerDeviceType.Touch)
  {       
    _interactionSource.TryRedirectForManipulation(
    e.CurrentPoint.GetCurrentPoint(_rootElement));
  }
}

Compositor _compositor = null;
InteractionTracker _tracker = null;
UIElement _rootElement = null;
VisualInteractionSource _interactionSource;
         
         
```



## -see-also
