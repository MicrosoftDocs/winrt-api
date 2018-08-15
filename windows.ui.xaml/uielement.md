---
-api-id: T:Windows.UI.Xaml.UIElement
-api-type: winrt class
---

<!-- Class syntax.
public class UIElement : Windows.UI.Xaml.DependencyObject, Windows.UI.Xaml.IUIElement, Windows.UI.Xaml.IUIElement2, Windows.UI.Xaml.IUIElement3, Windows.UI.Xaml.IUIElement4, Windows.UI.Xaml.IUIElement5, Windows.UI.Xaml.IUIElementOverrides
-->

# Windows.UI.Xaml.UIElement

## -description

[UIElement](uielement.md) is a base class for most of the Windows Runtime UI objects that have visual appearance and can process basic input as part of your app's user interface.

## -remarks

[UIElement](uielement.md) is a base element: it's a class that many other Windows Runtime classes inherit from in order to support the XAML UI element model. Properties, methods and events that [UIElement](uielement.md) defines are inherited by hundreds of other Windows Runtime classes.

Although [UIElement](uielement.md) defines the events for focus reporting ([GotFocus](uielement_gotfocus.md), [LostFocus](uielement_lostfocus.md)), [UIElement](uielement.md) does not define an API for programmatically setting the focus. This capability is defined by the [Control](../windows.ui.xaml.controls/control.md) class.

[UIElement](uielement.md) does not expose a public constructor. Typically, you don't derive classes from either [UIElement](uielement.md) or [FrameworkElement](frameworkelement.md) directly. More typically used base classes for derived custom classes are these classes:

+ Specific controls that are not sealed (for example, [TextBox](../windows.ui.xaml.controls/textbox.md))
+ Control base classes ([Control](../windows.ui.xaml.controls/control.md), [ContentControl](../windows.ui.xaml.controls/contentcontrol.md), [UserControl](../windows.ui.xaml.controls/usercontrol.md))
+ Navigation elements ([Page](../windows.ui.xaml.controls/page.md), [Frame](../windows.ui.xaml.controls/frame.md))
+ Panel classes (the base class [Panel](../windows.ui.xaml.controls/panel.md), or specific non-sealed implementations such as [Grid](../windows.ui.xaml.controls/grid.md))

The [UIElement](uielement.md) class is used as the type parameter of many properties and methods in the Windows Runtime  API. For example, the [Child](../windows.ui.xaml.controls/border_child.md) property of [Border](../windows.ui.xaml.controls/border.md) takes a single [UIElement](uielement.md), which represents the element that the [Border](../windows.ui.xaml.controls/border.md) is drawn around. You can provide any [UIElement](uielement.md)-derived element for such a property, including custom controls that you define.

The [UIElementCollection](../windows.ui.xaml.controls/uielementcollection.md) class provides a strongly typed collection of [UIElement](uielement.md) items. [UIElementCollection](../windows.ui.xaml.controls/uielementcollection.md) is used as a type for properties of objects that contain several child elements, for example for the [Children](../windows.ui.xaml.controls/panel_children.md) property of any [Panel](../windows.ui.xaml.controls/panel.md) class.

### **UIElement** API and features

[UIElement](uielement.md) extends [DependencyObject](dependencyobject.md), which is another base element, and adds support for various Windows Runtime feature areas.

### Input, and events for responding to user interaction

Much of the input behavior for visible elements in a UI is defined in the [UIElement](uielement.md) class. This includes the events for keyboard, mouse, touch, drag-drop, and focus interactions. For more info, see [Handle pointer input](http://msdn.microsoft.com/library/bdbc9e33-4037-4671-9596-471dcf855c82), [Keyboard interactions](http://msdn.microsoft.com/library/ff819bac-67c0-4ec9-8921-f087be188138), and [Custom user interactions](http://msdn.microsoft.com/library/9403c46c-60da-4c13-a381-6fbd069dd9ce).

Prominent API of [UIElement](uielement.md) that support input and user interaction:

+ **Pointer events:** [PointerPressed](uielement_pointerpressed.md), [PointerReleased](uielement_pointerreleased.md), [PointerMoved](uielement_pointermoved.md), [PointerEntered](uielement_pointerentered.md), [PointerExited](uielement_pointerexited.md)
+ **Key handling events:** [KeyDown](uielement_keydown.md), [KeyUp](uielement_keyup.md)
+ **Focus:** [GotFocus](uielement_gotfocus.md), [LostFocus](uielement_lostfocus.md)
+ **Pointer capture:** [CapturePointer](uielement_capturepointer_916768934.md), [PointerCanceled](uielement_pointercanceled.md), [PointerCaptureLost](uielement_pointercapturelost.md), [ReleasePointerCapture](uielement_releasepointercapture_962192786.md), [PointerCaptures](uielement_pointercaptures.md)
+ **Drag-drop:** [DragOver](uielement_dragover.md), [Drop](uielement_drop.md), [DragEnter](uielement_dragenter.md), [DragLeave](uielement_dragleave.md), [AllowDrop](uielement_allowdrop.md)
+ **Properties that influence how basic input is processed:** [IsHitTestVisible](uielement_ishittestvisible.md), [AllowDrop](uielement_allowdrop.md)

### Gestures and manipulations

Gestures and manipulations are also a way to handle input and user interaction. The API are listed out separately here because these events represent how the system interacts with device-level input actions and interprets them as a user interaction. Manipulations are a way to handle dynamic multi-touch interactions such as pinching and stretching. Together, the gestures and manipulations provide the touch patterns for touch interaction with UWP app. For more info, see [Custom user interactions](http://msdn.microsoft.com/library/9403c46c-60da-4c13-a381-6fbd069dd9ce) and [Touch interaction design](http://msdn.microsoft.com/library/9ba7f613-e5d1-40d4-920b-143094209e3a).

Prominent API of [UIElement](uielement.md) that support gestures and manipulations:

+ **Gesture events:** [DoubleTapped](uielement_doubletapped.md), [Holding](uielement_holding.md), [RightTapped](uielement_righttapped.md), [Tapped](uielement_tapped.md)
+ **Manipulation events:** [ManipulationCompleted](uielement_manipulationcompleted.md), [ManipulationDelta](uielement_manipulationdelta.md), [ManipulationInertiaStarting](uielement_manipulationinertiastarting.md), [ManipulationStarted](uielement_manipulationstarted.md), [ManipulationStarting](uielement_manipulationstarting.md)
+ **Properties that influence how gestures and manipulations are processed:** [IsHoldingEnabled](uielement_isholdingenabled.md) and other **Is*Enabled**, [ManipulationMode](uielement_manipulationmode.md)

### Basic appearance

The [Visibility](uielement_visibility.md) and [Opacity](uielement_opacity.md) properties are frequently used to adjust the appearance of an element in your UI, especially within styles, templates, and visual states. The [Clip](uielement_clip.md), [RenderTransform](uielement_rendertransform.md), and [Transitions](uielement_transitions.md) properties are each useful for producing interactions and different looks for your UI elements. 
<!--No good seealso-->

### Basic layout

The [UIElement](uielement.md) class provides a starting point for layout characteristics with properties such as [DesiredSize](uielement_desiredsize.md) and the [Arrange](uielement_arrange_958316931.md) and [Measure](uielement_measure_1722732750.md) methods. [FrameworkElement](frameworkelement.md) adds more layout capabilities. For more info, see [Define layouts with XAML](http://msdn.microsoft.com/library/8d4e4162-1c9c-48f4-8a94-34976fb17079) and [FrameworkElement](frameworkelement.md).

### Routed events

Most of the input events of [UIElement](uielement.md) are *routed events*. A routed event enables a built-in event handling notification system, so that a parent object can handle input events from child objects in the object tree if the event remains unhandled. This input event behavior is useful for input area grouping, and for control compositing. For more info, see [Events and routed events overview](http://msdn.microsoft.com/library/34c219e8-3efb-45bc-8bbd-6fd937698832).

Prominent API of [UIElement](uielement.md) that support routed events: [AddHandler](uielement_addhandler_2121467075.md), [RemoveHandler](uielement_removehandler_661998757.md), ***Event** properties.

### Other platform support

+ [OnCreateAutomationPeer](uielement_oncreateautomationpeer_1478162674.md) enables a class to use a custom [AutomationPeer](../windows.ui.xaml.automation.peers/automationpeer.md) for its Microsoft UI Automation support.
+ [RenderTransform](uielement_rendertransform.md), [TransformToVisual](uielement_transformtovisual_799251735.md), [Projection](uielement_projection.md), [CompositeMode](uielement_compositemode.md), [CacheMode](uielement_cachemode.md) and [FindSubElementsForTouchTargeting](uielement_findsubelementsfortouchtargeting_2073429826.md) are useful for advanced UI layout scenarios.

### UIElement dependency properties

Many of the read-write properties of the [UIElement](uielement.md) base element class are dependency properties. Dependency properties support some of the basic programming model features for a UWP app using C++, C#, or Visual Basic, such as styles and templates, data binding, XAML resource references, and property-changed logic. For more info on dependency properties and the features they support, see [Dependency properties overview](http://msdn.microsoft.com/library/ad649e66-f71c-4daa-9994-617c886fda7e).

### UIElement derived classes

The only Windows Runtime class that derives directly from [UIElement](uielement.md) is [FrameworkElement](frameworkelement.md). For a list of the classes that derive from [FrameworkElement](frameworkelement.md), see the "**FrameworkElement** derived classes" section of the [FrameworkElement](frameworkelement.md) reference topic.

## -examples

## -see-also

[DependencyObject](dependencyobject.md), [FrameworkElement](frameworkelement.md), [Events and routed events overview](http://msdn.microsoft.com/library/34c219e8-3efb-45bc-8bbd-6fd937698832), [Dependency properties overview](http://msdn.microsoft.com/library/ad649e66-f71c-4daa-9994-617c886fda7e), [Drag and drop sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlDragAndDrop), [Basic input sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/BasicInput), [Transform3D animations sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlTransform3DAnimations)