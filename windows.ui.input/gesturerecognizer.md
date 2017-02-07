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

In this case, you can create gesture objects dynamically on a [pointerdown](XREF:TODO:wwa.HTMLElement_onmspointerdown) event and destroy them on an [MSGestureEnd](XREF:TODO:wwa.HTMLElement_onmsgestureend) event. This approach scales well, but does incur some overhead due to creating and releasing these objects.

Alternatively, you can statically allocate and dynamically manage a pool of reusable gesture objects.

> [!NOTE]
> : This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](http://go.microsoft.com/fwlink/p/?linkid=258275) and [Using Windows Runtime objects in a multithreaded environment (.NET)](http://go.microsoft.com/fwlink/p/?linkid=258277).

For more detail on how to use cross-slide functionality, see [Guidelines for cross-slide](http://msdn.microsoft.com/library/897555e2-c567-4bbe-b600-553daeb223d5). The threshold distances used by the cross-slide interaction are shown in the following diagram.

<img src="images/crossslide_threshold.png" border="1" width="536" height="276" alt="Screen shot showing the select and drag and drop processes." />

The [PivotRadius](gesturerecognizer_pivotradius.md) and [PivotCenter](gesturerecognizer_pivotcenter.md) properties are used only when single pointer input is detected. They have no effect on multiple pointer input. The value for these properties should be updated regularly during the interaction.

Rotation is supported by a [GestureRecognizer](gesturerecognizer.md) only when [manipulationRotate](gesturesettings.md) is set through the [GestureSettings](gesturerecognizer_gesturesettings.md) property.

Rotation is not supported for single pointer input if the value of [PivotRadius](gesturerecognizer_pivotradius.md) is set to 0.



## -examples
Here we set up a [GestureRecognizer](gesturerecognizer.md) object with a collection of input event handlers for processing various pointer and gestures. For more information on how to listen to and handle Windows Runtime events, see .

> [!NOTE]
> Use the [target](XREF:TODO:ie.IDOMEvent_target) or [currentTarget](XREF:TODO:ie.IDOMEvent_currentTarget) property of the event object instead of the [GestureRecognizer](gesturerecognizer.md) object in the event handler.

```javascript

// inputManager handles gesture recognition for this sample.
function inputManager(target) {
    // Initialize the gesture recognizer.
    var gr = new Windows.UI.Input.GestureRecognizer();

    // Turn off visual feedback for gestures.
    // Visual feedback for pointer input is still displayed. 
    gr.showGestureFeedback = false;

    // Configure gesture recognizer to process the following:
    // double tap               - start questions and timer.
    // tap                      - move to next question.
    // right tap                - show answer.
    // hold and hold with mouse - start clues.
    gr.gestureSettings =
        Windows.UI.Input.GestureSettings.tap |
        Windows.UI.Input.GestureSettings.doubleTap |
        Windows.UI.Input.GestureSettings.rightTap |
        Windows.UI.Input.GestureSettings.hold |
        Windows.UI.Input.GestureSettings.holdWithMouse;

    // Register event listeners for these gestures.
    gr.addEventListener('tapped', tappedHandler);
    gr.addEventListener("holding", holdingHandler);
    gr.addEventListener("righttapped", rightTappedHandler);

    // Register event listeners for DOM pointer events.
    // The event pointer(s) are passed to the gesture recognizer
    // for further processing.
    target.addEventListener('MSPointerDown', pointerDown, false);
    target.addEventListener('MSPointerMove', pointerMove, false);
    target.addEventListener('MSPointerUp', pointerUp, false);
    target.addEventListener("MSPointerOver", pointerOver, true);
    target.addEventListener("MSPointerOut", pointerOut, true);
}

// Handle the pointer move event.
// The holding gesture is routed through this event.
// If pointer move is not handled, holding will not fire.
function pointerMove(evt) {
   _eventLog.innerText += "pointer move || ";

   // Get intermediate PointerPoints
   var pps = evt.intermediatePoints;

   // Pass the array of PointerPoints to the gesture recognizer.
   gr.processMoveEvents(pps);
};

// The pointer move event must also be handled because the 
// holding gesture is routed through this event.
// If pointer move is not handled, holding will not fire.
// A holding event is fired approximately one second after 
// a pointer down if no subsequent movement is detected.
function holdingHandler(evt) {
    if (evt.holdingState == Windows.UI.Input.HoldingState.started) {
        _eventLog.innerText += "holding || ";
    } else if (evt.holdingState == Windows.UI.Input.HoldingState.completed) {
        _eventLog.innerText += "holding completed || ";
    } else {
        _eventLog.innerText += "holding canceled || ";
    }
}
```

```csharp

namespace GesturesApp.Manipulations
{
    /// <summary>
    /// Thin wrapper around the <see cref="Windows.UI.Input.GestureRecognizer"/>, routes pointer events received by
    /// the manipulation target to the gesture recognizer.
    /// </summary>
    /// <remarks>
    /// Transformations during manipulations cannot be expressed in the coordinate space of the manipulation target.
    /// Instead they need be expressed with respect to a reference coordinate space, usually an ancestor (in the UI tree)
    /// of the element being manipulated.
    /// </remarks>
    public abstract class InputProcessor
    {
        protected Windows.UI.Input.GestureRecognizer _gestureRecognizer;
        
        // Element being manipulated
        protected Windows.UI.Xaml.FrameworkElement _target;
        public Windows.UI.Xaml.FrameworkElement Target
        {
            get { return _target; }
        }

        // Reference element that contains the coordinate space used for expressing transformations 
        // during manipulation, usually the parent element of Target in the UI tree
        protected Windows.UI.Xaml.Controls.Canvas _reference;
        public Windows.UI.Xaml.FrameworkElement Reference
        {
            get { return _reference; }
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="element">
        /// Manipulation target.
        /// </param>
        /// <param name="reference">
        /// Element that contains the coordinate space used for expressing transformations
        /// during manipulations, usually the parent element of Target in the UI tree.
        /// </param>
        /// <remarks>
        /// Transformations during manipulations cannot be expressed in the coordinate space of the manipulation target.
        /// Thus <paramref name="element"/> and <paramref name="reference"/> must be different. Usually <paramref name="reference"/>
        /// will be an ancestor of <paramref name="element"/> in the UI tree.
        /// </remarks>
        internal InputProcessor(Windows.UI.Xaml.FrameworkElement element, Windows.UI.Xaml.Controls.Canvas reference)
        {
            this._target = element;
            this._reference = reference;

            // Setup pointer event handlers for the element.
            // They are used to feed the gesture recognizer.    
            this._target.PointerCanceled += OnPointerCanceled;
            this._target.PointerMoved += OnPointerMoved;
            this._target.PointerPressed += OnPointerPressed;
            this._target.PointerReleased += OnPointerReleased;
            this._target.PointerWheelChanged += OnPointerWheelChanged;

            // Create the gesture recognizer
            this._gestureRecognizer = new Windows.UI.Input.GestureRecognizer();
            this._gestureRecognizer.GestureSettings = Windows.UI.Input.GestureSettings.None;
        }
        
        private void OnPointerMoved(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs args)
        {
            // Route the events to the gesture recognizer.
            // All intermediate points are passed to the gesture recognizer in
            // the coordinate system of the reference element.
            this._gestureRecognizer.ProcessMoveEvents(args.GetIntermediatePoints(this._reference));

            // Mark event handled, to prevent execution of default event handlers
            args.Handled = true;
        }
    }
}
```

Remove the event handler and set the gesture recognizer to null if it is no longer needed:

```javascript

gr.removeEventListener('MSPointerDown', pointerDown);
gr = null;

```

```csharp
this._gestureRecognizer = null;
```



## -see-also
[Windows.UI.Input Classes](windows_ui_input_classes.md), [Windows.Devices.Input](../windows.devices.input/windows_devices_input.md), [Windows.UI.Core](../windows.ui.core/windows_ui_core.md), [Windows.UI.Input](windows_ui_input.md), [Windows.UI.Input.Inking](../windows.ui.input.inking/windows_ui_input_inking.md), [Windows.UI.Xaml.Input](../windows.ui.xaml.input/windows_ui_xaml_input.md), [Custom user interactions](http://msdn.microsoft.com/library/9403c46c-60da-4c13-a381-6fbd069dd9ce), [UX guidelines for custom user interactions](http://msdn.microsoft.com/library/52f9607d-e2d0-44e4-9e1c-f856f7072a1e), [Touch design guidelines](http://msdn.microsoft.com/library/3250f729-4fdd-4ad4-b856-b8ba575c3375), [User interaction mode sample](http://go.microsoft.com/fwlink/p/?LinkID=619894), [Focus visuals sample](http://go.microsoft.com/fwlink/p/?LinkID=619895), [Input: Device capabilities sample](http://go.microsoft.com/fwlink/p/?linkid=231530), [Input: Ink sample](http://go.microsoft.com/fwlink/p/?linkid=231622), [Input: Manipulations and gestures (JavaScript) sample](http://go.microsoft.com/fwlink/p/?linkid=231638), [Input: Simplified ink  sample](http://go.microsoft.com/fwlink/p/?linkid=246570), [Input: Windows 8 gestures sample](http://go.microsoft.com/fwlink/p/?LinkId=264995), [Input: XAML user input events sample](http://go.microsoft.com/fwlink/p/?linkid=226855), [XAML scrolling, panning, and zooming sample](http://go.microsoft.com/fwlink/p/?linkid=251717), [DirectX touch input sample](http://go.microsoft.com/fwlink/p/?LinkID=231627), [Input: Manipulations and gestures (C++) sample](http://go.microsoft.com/fwlink/p/?linkid=231605), [Input: Touch hit testing sample](http://go.microsoft.com/fwlink/p/?linkid=231590), [Input source identification sample](http://go.microsoft.com/fwlink/p/?LinkID=267908), [Touch injection sample](http://go.microsoft.com/fwlink/p/?LinkID=267906), [Win32 touch hit-testing sample](http://go.microsoft.com/fwlink/p/?LinkID=267915), [Basic input sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620514)