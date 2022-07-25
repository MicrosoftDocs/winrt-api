---
-api-id: T:Windows.UI.Xaml.UIElement
-api-type: winrt class
---

<!-- Class syntax.
public class UIElement : Windows.UI.Xaml.DependencyObject, Windows.UI.Xaml.IUIElement, Windows.UI.Xaml.IUIElement2, Windows.UI.Xaml.IUIElement3, Windows.UI.Xaml.IUIElement4, Windows.UI.Xaml.IUIElement5, Windows.UI.Xaml.IUIElementOverrides
-->

# Windows.UI.Xaml.UIElement

## -description

UIElement is a base class for most of the Windows Runtime UI objects that have visual appearance and can process basic input as part of your app's user interface.



## -remarks

UIElement is a base element: it's a class that many other Windows Runtime classes inherit from in order to support the XAML UI element model. Properties, methods and events that UIElement defines are inherited by hundreds of other Windows Runtime classes.

Although UIElement defines the events for focus reporting ([GotFocus](uielement_gotfocus.md), [LostFocus](uielement_lostfocus.md)), UIElement does not define an API for programmatically setting the focus. This capability is defined by the [Control](../windows.ui.xaml.controls/control.md) class.

UIElement does not expose a public constructor. Typically, you don't derive classes from either UIElement or [FrameworkElement](frameworkelement.md) directly. More typically used base classes for derived custom classes are these classes:

+ Specific controls that are not sealed (for example, [TextBox](../windows.ui.xaml.controls/textbox.md))
+ Control base classes ([Control](../windows.ui.xaml.controls/control.md), [ContentControl](../windows.ui.xaml.controls/contentcontrol.md), [UserControl](../windows.ui.xaml.controls/usercontrol.md))
+ Navigation elements ([Page](../windows.ui.xaml.controls/page.md), [Frame](../windows.ui.xaml.controls/frame.md))
+ Panel classes (the base class [Panel](../windows.ui.xaml.controls/panel.md), or specific non-sealed implementations such as [Grid](../windows.ui.xaml.controls/grid.md))

The UIElement class is used as the type parameter of many properties and methods in the Windows Runtime  API. For example, the [Child](../windows.ui.xaml.controls/border_child.md) property of [Border](../windows.ui.xaml.controls/border.md) takes a single UIElement, which represents the element that the [Border](../windows.ui.xaml.controls/border.md) is drawn around. You can provide any UIElement-derived element for such a property, including custom controls that you define.

The [UIElementCollection](../windows.ui.xaml.controls/uielementcollection.md) class provides a strongly typed collection of UIElement items. [UIElementCollection](../windows.ui.xaml.controls/uielementcollection.md) is used as a type for properties of objects that contain several child elements, for example for the [Children](../windows.ui.xaml.controls/panel_children.md) property of any [Panel](../windows.ui.xaml.controls/panel.md) class.

### **UIElement** API and features

UIElement extends [DependencyObject](dependencyobject.md), which is another base element, and adds support for various Windows Runtime feature areas.

### Input, and events for responding to user interaction

Much of the input behavior for visible elements in a UI is defined in the UIElement class. This includes the events for keyboard, mouse, touch, drag-drop, and focus interactions. For more info, see [Handle pointer input](/windows/uwp/design/input/handle-pointer-input), [Keyboard interactions](/windows/uwp/input-and-devices/keyboard-interactions), and [Custom user interactions](/windows/uwp/design/layout/index).

Prominent API of UIElement that support input and user interaction:

+ **Pointer events:** [PointerPressed](uielement_pointerpressed.md), [PointerReleased](uielement_pointerreleased.md), [PointerMoved](uielement_pointermoved.md), [PointerEntered](uielement_pointerentered.md), [PointerExited](uielement_pointerexited.md)
+ **Key handling events:** [KeyDown](uielement_keydown.md), [KeyUp](uielement_keyup.md)
+ **Focus:** [GotFocus](uielement_gotfocus.md), [LostFocus](uielement_lostfocus.md)
+ **Pointer capture:** [CapturePointer](uielement_capturepointer_916768934.md), [PointerCanceled](uielement_pointercanceled.md), [PointerCaptureLost](uielement_pointercapturelost.md), [ReleasePointerCapture](uielement_releasepointercapture_962192786.md), [PointerCaptures](uielement_pointercaptures.md)
+ **Drag-drop:** [DragOver](uielement_dragover.md), [Drop](uielement_drop.md), [DragEnter](uielement_dragenter.md), [DragLeave](uielement_dragleave.md), [AllowDrop](uielement_allowdrop.md)
+ **Properties that influence how basic input is processed:** [IsHitTestVisible](uielement_ishittestvisible.md), [AllowDrop](uielement_allowdrop.md)

### Gestures and manipulations

Gestures and manipulations are also a way to handle input and user interaction. The API are listed out separately here because these events represent how the system interacts with device-level input actions and interprets them as a user interaction. Manipulations are a way to handle dynamic multi-touch interactions such as pinching and stretching. Together, the gestures and manipulations provide the touch patterns for touch interaction with UWP app. For more info, see [Custom user interactions](/windows/uwp/design/layout/index) and [Touch interaction design](https://msdn.microsoft.com/library/9ba7f613-e5d1-40d4-920b-143094209e3a).

Prominent API of UIElement that support gestures and manipulations:

+ **Gesture events:** [DoubleTapped](uielement_doubletapped.md), [Holding](uielement_holding.md), [RightTapped](uielement_righttapped.md), [Tapped](uielement_tapped.md)
+ **Manipulation events:** [ManipulationCompleted](uielement_manipulationcompleted.md), [ManipulationDelta](uielement_manipulationdelta.md), [ManipulationInertiaStarting](uielement_manipulationinertiastarting.md), [ManipulationStarted](uielement_manipulationstarted.md), [ManipulationStarting](uielement_manipulationstarting.md)
+ **Properties that influence how gestures and manipulations are processed:** [IsHoldingEnabled](uielement_isholdingenabled.md) and other **Is*Enabled**, [ManipulationMode](uielement_manipulationmode.md)

### Basic appearance

The [Visibility](uielement_visibility.md) and [Opacity](uielement_opacity.md) properties are frequently used to adjust the appearance of an element in your UI, especially within styles, templates, and visual states. The [Clip](uielement_clip.md), [RenderTransform](uielement_rendertransform.md), and [Transitions](uielement_transitions.md) properties are each useful for producing interactions and different looks for your UI elements. 
<!--No good seealso-->

### Basic layout

The UIElement class provides a starting point for layout characteristics with properties such as [DesiredSize](uielement_desiredsize.md) and the [Arrange](uielement_arrange_958316931.md) and [Measure](uielement_measure_1722732750.md) methods. [FrameworkElement](frameworkelement.md) adds more layout capabilities. For more info, see [Define layouts with XAML](/windows/uwp/layout/layouts-with-xaml) and [FrameworkElement](frameworkelement.md).

### Routed events

Most of the input events of UIElement are *routed events*. A routed event enables a built-in event handling notification system, so that a parent object can handle input events from child objects in the object tree if the event remains unhandled. This input event behavior is useful for input area grouping, and for control compositing. For more info, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

Prominent API of UIElement that support routed events: [AddHandler](uielement_addhandler_2121467075.md), [RemoveHandler](uielement_removehandler_661998757.md), ***Event** properties.

### Other platform support

+ [OnCreateAutomationPeer](uielement_oncreateautomationpeer_1478162674.md) enables a class to use a custom [AutomationPeer](../windows.ui.xaml.automation.peers/automationpeer.md) for its Microsoft UI Automation support.
+ [RenderTransform](uielement_rendertransform.md), [TransformToVisual](uielement_transformtovisual_799251735.md), [Projection](uielement_projection.md), [CompositeMode](uielement_compositemode.md), [CacheMode](uielement_cachemode.md) and [FindSubElementsForTouchTargeting](uielement_findsubelementsfortouchtargeting_2073429826.md) are useful for advanced UI layout scenarios.

### UIElement dependency properties

Many of the read-write properties of the UIElement base element class are dependency properties. Dependency properties support some of the basic programming model features for a UWP app using C++, C#, or Visual Basic, such as styles and templates, data binding, XAML resource references, and property-changed logic. For more info on dependency properties and the features they support, see [Dependency properties overview](/windows/uwp/xaml-platform/dependency-properties-overview).

### UIElement derived classes

The only Windows Runtime class that derives directly from UIElement is [FrameworkElement](frameworkelement.md). For a list of the classes that derive from [FrameworkElement](frameworkelement.md), see the "**FrameworkElement** derived classes" section of the [FrameworkElement](frameworkelement.md) reference topic.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | AccessKey |
| 1607 | 14393 | AccessKeyDisplayDismissed |
| 1607 | 14393 | AccessKeyDisplayRequested |
| 1607 | 14393 | AccessKeyInvoked |
| 1607 | 14393 | AccessKeyScopeOwner |
| 1607 | 14393 | ContextCanceled |
| 1607 | 14393 | ContextFlyout |
| 1607 | 14393 | ContextRequested |
| 1607 | 14393 | ExitDisplayModeOnAccessKeyInvoked |
| 1607 | 14393 | IsAccessKeyScope |
| 1703 | 15063 | GettingFocus |
| 1703 | 15063 | GettingFocusEvent |
| 1703 | 15063 | HighContrastAdjustment |
| 1703 | 15063 | KeyTipHorizontalOffset |
| 1703 | 15063 | KeyTipPlacementMode |
| 1703 | 15063 | KeyTipVerticalOffset |
| 1703 | 15063 | Lights |
| 1703 | 15063 | LosingFocus |
| 1703 | 15063 | LosingFocusEvent |
| 1703 | 15063 | NoFocusCandidateFound |
| 1703 | 15063 | NoFocusCandidateFoundEvent |
| 1703 | 15063 | StartBringIntoView |
| 1703 | 15063 | StartBringIntoView(BringIntoViewOptions) |
| 1703 | 15063 | TabFocusNavigation |
| 1703 | 15063 | XYFocusDownNavigationStrategy |
| 1703 | 15063 | XYFocusKeyboardNavigation |
| 1703 | 15063 | XYFocusLeftNavigationStrategy |
| 1703 | 15063 | XYFocusRightNavigationStrategy |
| 1703 | 15063 | XYFocusUpNavigationStrategy |
| 1709 | 16299 | CharacterReceived |
| 1709 | 16299 | CharacterReceivedEvent |
| 1709 | 16299 | GetChildrenInTabFocusOrder |
| 1709 | 16299 | KeyboardAccelerators |
| 1709 | 16299 | OnProcessKeyboardAccelerators |
| 1709 | 16299 | PreviewKeyDown |
| 1709 | 16299 | PreviewKeyDownEvent |
| 1709 | 16299 | PreviewKeyUp |
| 1709 | 16299 | PreviewKeyUpEvent |
| 1709 | 16299 | ProcessKeyboardAccelerators |
| 1709 | 16299 | TryInvokeKeyboardAccelerator |
| 1803 | 17134 | BringIntoViewRequested |
| 1803 | 17134 | BringIntoViewRequestedEvent |
| 1803 | 17134 | ContextRequestedEvent |
| 1803 | 17134 | KeyboardAcceleratorPlacementMode |
| 1803 | 17134 | KeyboardAcceleratorPlacementTarget |
| 1803 | 17134 | KeyTipTarget |
| 1803 | 17134 | OnBringIntoViewRequested |
| 1803 | 17134 | OnKeyboardAcceleratorInvoked |
| 1803 | 17134 | RegisterAsScrollPort |
| 1809 | 17763 | CanBeScrollAnchor |
| 1809 | 17763 | CenterPoint |
| 1809 | 17763 | OpacityTransition |
| 1809 | 17763 | PopulatePropertyInfo |
| 1809 | 17763 | PopulatePropertyInfoOverride |
| 1809 | 17763 | Rotation |
| 1809 | 17763 | RotationAxis |
| 1809 | 17763 | RotationTransition |
| 1809 | 17763 | Scale |
| 1809 | 17763 | ScaleTransition |
| 1809 | 17763 | StartAnimation |
| 1809 | 17763 | StopAnimation |
| 1809 | 17763 | TransformMatrix |
| 1809 | 17763 | Translation |
| 1809 | 17763 | TranslationTransition |
| 1903 | 18362 | ActualOffset |
| 1903 | 18362 | ActualSize |
| 1903 | 18362 | Shadow |
| 1903 | 18362 | UIContext |
| 1903 | 18362 | XamlRoot |

## -examples

## -see-also

[DependencyObject](dependencyobject.md), [FrameworkElement](frameworkelement.md), [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview), [Dependency properties overview](/windows/uwp/xaml-platform/dependency-properties-overview), [Drag and drop sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlDragAndDrop), [Basic input sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/BasicInput), [Transform3D animations sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlTransform3DAnimations)
