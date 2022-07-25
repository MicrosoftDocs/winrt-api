---
-api-id: T:Windows.UI.Xaml.Controls.Control
-api-type: winrt class
---

<!-- Class syntax.
public class Control : Windows.UI.Xaml.FrameworkElement, Windows.UI.Xaml.Controls.IControl, Windows.UI.Xaml.Controls.IControl2, Windows.UI.Xaml.Controls.IControl3, Windows.UI.Xaml.Controls.IControl4, Windows.UI.Xaml.Controls.IControl5, Windows.UI.Xaml.Controls.IControlOverrides, Windows.UI.Xaml.Controls.IControlProtected
-->

# Windows.UI.Xaml.Controls.Control

## -description

Represents the base class for UI elements that use a [ControlTemplate](controltemplate.md) to define their appearance. Parent class for [ContentControl](contentcontrol.md), [UserControl](usercontrol.md), [ItemsControl](itemscontrol.md) and several practical controls.



## -remarks

The Control class is the base class for many of the controls you add to an app and its UI. The Control class defines very little behavior; you can add an actual Control element to XAML for UI but you typically add something that inherits from Control directly or indirectly, such as a [Button](button.md) or [ListBox](listbox.md). For a list of controls you can use, see [Controls by function](/windows/uwp/controls-and-patterns/controls-by-function).

The [Template](control_template.md) property, which uses the type [ControlTemplate](controltemplate.md), specifies the visual appearance of a control. If you want to change the appearance of a control but retain its functionality, you should consider creating a new [ControlTemplate](controltemplate.md) instead of defining a new Control-based class. For more info, see [Control templates](/windows/uwp/design/controls-and-patterns/control-templates).

Control is the parent of [UserControl](usercontrol.md). [UserControl](usercontrol.md) is the intended base class for lightweight controls that don't need visual states. Although the [UserControl](usercontrol.md) technically inherits the [Template](control_template.md) property, you cannot apply a template to a [UserControl](usercontrol.md).

### Implicit styles for controls

Each practical control that's defined for XAML has a default style that contains its default control template. Controls can have an implicit style, meaning that the [FrameworkElement.Style](../windows.ui.xaml/frameworkelement_style.md) property isn't set explicitly. Once that implicit style is available, almost all other properties of a control can be set with [Setter](../windows.ui.xaml/setter.md) elements in that [Style](../windows.ui.xaml/style.md). The [Style](../windows.ui.xaml/style.md) can initialize the control separately from the rest of the control logic, and can set values that aren't the code-based defaults for each property.

The implicit style exists as a keyed resource that's part of the Windows Runtime, stored internally as a binary representation of XAML. You can get a copy of either a particular control's style or of the full set of styles to look at how the styles and control templates are defined.

The association between a particular control type and the key/name of the implicit style it uses by default is established by the value of the [DefaultStyleKey](control_defaultstylekey.md) property. The [DefaultStyleKey](control_defaultstylekey.md) property is protected, so only someone that subclasses a control class can change the value. If you're just creating a control instance, for example declaring controls in a XAML UI, then the default style is the implicit style that's based on the control's type. For more info, see Remarks in [DefaultStyleKey](control_defaultstylekey.md). You don't need to change the [DefaultStyleKey](control_defaultstylekey.md) value to use a different style, you just need to define your own XAML [Style](../windows.ui.xaml/style.md) that has the same [TargetType](../windows.ui.xaml/style_targettype.md) that matches the implicit style lookup and exists as a XAML resource. For more info, see [Control templates](/windows/uwp/design/controls-and-patterns/control-templates).

### The visual state model

The visual state model is a technique where you modify just a few of the properties defined in a control's template. You change property values in order to provide visual feedback to the user that indicates what the control is doing and hints at further UI interactions that are possible. The controls are modified by applying zero-duration or short-duration storyboarded animations to some of the properties in the template. You also can define short-duration animations that apply for the transitions between states.

The visual states themselves are defined as part of the control template. Each visual state has a name, so that the control logic can invoke the [GoToState](../windows.ui.xaml/visualstatemanager_gotostate_443481648.md) method that loads up each visual state when it's needed for a particular logic state. Visual states are declared within visual state groups, so that visual states that are exclusive to each other can ensure that only one such state is active at a time. As soon as another visual state from the same group is loaded, the animations for the previous state stop being applied, but animations in another group might still be running and applying their changes and visual behavior. For example, a control might have a visual indicator for keyboard focus and a visual indicator for pointer-over. Because these are UI modes that can be adjusted independently of each other and can happen at the same time, they're each defined in a different visual state group.

Because it's defined in XAML as part of the control template, you can change the visual state behavior for any XAML control that you use in your UI. However, the logic is still based on the control expecting to find certain visual state groups and named visual states within. So you have to be very careful that you're providing the correctly named and structured visual states that are showing all aspects of a control's behavior to the user. For more info, see [Storyboarded animations for visual states](/previous-versions/windows/apps/jj819808(v=win.10)). Visual states are also briefly introduced in [Control templates](/windows/uwp/design/controls-and-patterns/control-templates).

Default visual states for controls sometimes use the library animations. You should try to preserve the library animations when you replace control templates or visual states because these animations are an important part of the control's look and feel in the UI. For more info, see [Animations overview](/windows/uwp/graphics/animations-overview).

### Controls and focus

The Control class defines several API that influence the keyboard focus behavior for a UI: the [Focus](control_focus_195503898.md) method, the [FocusState](control_focusstate.md) property, and the [IsEnabled](control_isenabled.md) and [IsTabStop](control_istabstop.md) properties. Enabling keyboard focus is an important part of assuring that a UI is accessible, because each focusable element becomes part of the tab order for the UI. Only UI elements that are interactive are typically enabled to receive keyboard focus. For example, a [TextBox](textbox.md) is interactive because the user can type text, whereas a [TextBlock](textblock.md) is not interactive because the text is read-only. Most of the classes that derive from Control are legitimately interactive and so it makes sense that they can be focused and should be in the tab order.

In order to be focusable, each of these must be true:

+ [Visibility](../windows.ui.xaml/uielement_visibility.md) is **Visible**
+ [IsEnabled](control_isenabled.md) is **true**
+ [IsTabStop](control_istabstop.md) is **true**
+ The control must be instantiated with its template loaded ([Loaded](../windows.ui.xaml/frameworkelement_loaded.md) fired, control connected to app's root visual)
 If you want a control to not be focusable, you can set [IsTabStop](control_istabstop.md) to **false**. However, if the reason you don't want the control to have focus is because it's not interactive in your UI, you might want to set [IsEnabled](control_isenabled.md) to **false** to make the lack of interaction obvious to everyone. Many controls have predefined visual states that are invoked for [IsEnabled](control_isenabled.md) =**false**, such as "graying out" text in labels.

Focus changes can fire [GotFocus](../windows.ui.xaml/uielement_gotfocus.md) or [LostFocus](../windows.ui.xaml/uielement_lostfocus.md) events. Although the "FocusedElement" value (exposed via [GetFocusedElement](/windows/desktop/api/uiautomationclient/nf-uiautomationclient-iuiautomation-getfocusedelement) method) is updated immediately, the change notifications of [GotFocus](../windows.ui.xaml/uielement_gotfocus.md) or [LostFocus](../windows.ui.xaml/uielement_lostfocus.md) occur asynchronously. This asynchronous focusing design is intended to avoid flickering on visual state transitions when control logic reacts to focus change too quickly.

The [Focus](control_focus_195503898.md) method enables bringing keyboard focus to a control programmatically. Be judicious when calling this method, it can be intrusive to move the keyboard focus when the user doesn't expect it. The main scenarios for [Focus](control_focus_195503898.md) are either setting the very first keyboard focus point when an entire page of UI is loaded, or setting focus to a specific part of a control once the parent control container has received top-level focus (like focusing the textbox in a combobox). For more info, see [Focus](control_focus_195503898.md). [FocusState](control_focusstate.md) tracks whether focus is programmatic or user-driven, which makes a difference for visual states, notably the visual focus indicator for keyboard focus that all controls should have.

### **On**_Event_ event handler overrides

Each **On**_Event_ method represents a prewired event handler for the corresponding [UIElement](../windows.ui.xaml/uielement.md) event. Practical controls that derive from Control can override the **On**_Event_ method and use this to provide control-specific handling and behavior for that input event. The most common scenario is to use the event handler to mark the event as **Handled** in the event data. The control code has first chance to handle this event, before any event handlers that are wired on a control instance are invoked. When the event data is marked **Handled**, then other handlers like those on the control instance won't be called. Also, the event won't bubble.

As it's implemented directly on Control, the **On**_Event_ method has an empty implementation. But each ancestor in a control's hierarchy may have provided an implementation. You won't be able to see this implementation because it's internal native code. In some cases a control will already have existing **On**_Event_ overrides that mark the event **Handled**. Once you've provided an initial **On**_Event_ override for a control, then any controls that you further derive from your own control class would also inherit the **On**_Event_ overrides you define. Any instances you use have that behavior too.

> [!NOTE]
> App code can still handle events that may have been marked **Handled** by a control's **On**_Event_ method logic, but they need to use the *handledEventsToo* parameter for the [UIElement.AddHandler](../windows.ui.xaml/uielement_addhandler_2121467075.md) method. For more info, see [UIElement.AddHandler](../windows.ui.xaml/uielement_addhandler_2121467075.md) or [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

The Control class defines several protected virtual methods that are each associated with a framework-level input event. These methods are intended to provide a pre-wired event handler for input events such that a control can enforce that certain input behaviors are used by that control and all instances of it. For example, there's a [PointerPressed](../windows.ui.xaml/uielement_pointerpressed.md) event defined by [UIElement](../windows.ui.xaml/uielement.md). Control defines the [OnPointerPressed](control_onpointerpressed_1718956371.md) method, with an empty definition. Within the base [Control](control_control_1221375020.md) constructor, event wiring for all the relevant input events includes the **On**_Event_ method as a listener/handler, which initially does nothing. But all it takes now for you as the control author to change the behavior for an input event is to give a new override definition for an **On**_Event_ method (also, make sure your constructor calls base). That behavior gets inherited to all instances or subclasses, unless another subclasser overrides it again. Because the **On**_Event_ events are first in sequence, before any UI definition XAML, they can adjust the event data and potentially change the conditions that other listeners see about the event.

The existing **On**_Event_ definitions in a particular control class can affect you as the consumer of the control even if you haven't overridden any **On**_Event_ methods yourself. This is because the existing **On**_Event_ definitions may have provided handling for an event that sets a **Handled** property value to **true** in some event's event data. That will prevent your instance-based event handling from even seeing the event, and will prevent your handler from being invoked. What's happening here is that there's an intentional control design that is enforcing that certain events shouldn't matter to the control, either because they're low-level events that clash with control logic or because the control has replacement logic. A prominent example of this is the [ButtonBase](../windows.ui.xaml.controls.primitives/buttonbase.md) class. The [ButtonBase](../windows.ui.xaml.controls.primitives/buttonbase.md) class has two behaviors that it enforces through a native override of [OnPointerPressed](control_onpointerpressed_1718956371.md) and [OnKeyDown](control_onkeydown_1048103922.md). It's doing this because it's combining various input modes at a low level and reporting them instead as the control-specific [Click](../windows.ui.xaml.controls.primitives/buttonbase_click.md) event. In the case of a [PointerPressed](../windows.ui.xaml/uielement_pointerpressed.md) event handler, if you tried to handle this on a [Button](button.md) instance, your handler doesn't get invoked. That's because the native [OnPointerPressed](control_onpointerpressed_1718956371.md) set [Handled](../windows.ui.xaml.input/pointerroutedeventargs_handled.md) to **true** and that prevented [PointerPressed](../windows.ui.xaml/uielement_pointerpressed.md) from propagating to your instance and app code. For [OnKeyDown](control_onkeydown_1048103922.md), the logic was just looking for certain keys (Ctrl and Enter) so an instance handler can still invoke as long as it isn't also looking for those keys.

> [!NOTE]
> There's actually a way to get around native handling of **On**_Event_ methods for input, for some of the input events. To do this you need to wire your handlers using the [AddHandler](../windows.ui.xaml/uielement_addhandler_2121467075.md) method with *handledEventsToo*. For more info see [AddHandler](../windows.ui.xaml/uielement_addhandler_2121467075.md) or [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

### Text properties that inherit to text element parts

Control defines several properties that are relevant to presentation of text. These are:

+ [Foreground](control_foreground.md)
+ [FontFamily](control_fontfamily.md)
+ [FontSize](control_fontsize.md)
+ [FontStretch](control_fontstretch.md)
+ [FontStyle](control_fontstyle.md)
+ [FontWeight](control_fontweight.md)

Obviously, not every control is intended to display text within it. For example, setting [FontFamily](control_fontfamily.md) on an [AppBarSeparator](appbarseparator.md) is legal but has absolutely no effect. The reason that Control defines these properties at the base class level is to make it easy for control templates to use [{TemplateBinding} markup extension](/windows/uwp/xaml-platform/templatebinding-markup-extension) to apply top-level text properties to one or more text element parts that exist within the template. For example, if you look at the control template for a [DatePicker](datepicker.md), you'll see that the root is a container and more deeply within that container are several [ComboBox](combobox.md) parts that actually take the text input. Each of these uses statements like `FontWeight="{TemplateBinding FontWeight}"` to have the top-level [FontWeight](control_fontweight.md) as set on a [DatePicker](datepicker.md) be used by various parts within.

Text properties on Control also inherit implicitly for a control that has a [ContentPresenter](contentpresenter.md) within it that displays text. For example, if you set [FontSize](control_fontsize.md) on a [Button](button.md), there's no explicit [{TemplateBinding} markup extension](/windows/uwp/xaml-platform/templatebinding-markup-extension) in its template or [ContentPresenter](contentpresenter.md) part that controls what the template does with a top-level [FontSize](control_fontsize.md) value. But the [Control.FontSize](control_fontsize.md) value is implicitly inherited by [ContentPresenter.FontSize](contentpresenter_fontsize.md) based on the context within the template's definition, so the text within the [Button](button.md) will be presented using the [Control.FontSize](control_fontsize.md) you set.

<!--IsEnabled, hit testing-->

<!--accessibility-->

<!--Margin and Padding interactions-->

<!--Content alignment and content presenters-->

### XAML attached properties

Control is the host service class for several [XAML attached properties](/windows/uwp/xaml-platform/attached-properties-overview).

In order to support XAML processor access to the attached properties, and also to expose equivalent _get_ and _set_ operations to code, each XAML attached property has a pair of Get and Set accessor methods. Another way to get or set the value in code is to use the dependency property system, calling either [GetValue](../windows.ui.xaml/dependencyobject_getvalue_1188551207.md) or [SetValue](../windows.ui.xaml/dependencyobject_setvalue_52578133.md) and passing the identifier field as the dependency property identifier.

| Attached property | Description |
| - | - |
| [IsTemplateFocusTarget](control_istemplatefocustarget.md) | Gets or sets a value that indicates whether this element is the part of a control template that has the focus visual. |
| [IsTemplateKeyTipTarget](control_istemplatekeytiptarget.md) | Gets or sets a value that indicates whether this element is the part of a control template where the `KeyTip` is placed. |

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | ElementSoundMode |
| 1607 | 14393 | FocusDisengaged |
| 1607 | 14393 | FocusEngaged |
| 1607 | 14393 | IsFocusEngaged |
| 1607 | 14393 | IsFocusEngagementEnabled |
| 1607 | 14393 | RemoveFocusEngagement |
| 1607 | 14393 | RequiresPointer |
| 1607 | 14393 | XYFocusDown |
| 1607 | 14393 | XYFocusLeft |
| 1607 | 14393 | XYFocusRight |
| 1607 | 14393 | XYFocusUp |
| 1703 | 15063 | DefaultStyleResourceUri |
| 1703 | 15063 | GetIsTemplateKeyTipTarget |
| 1703 | 15063 | SetIsTemplateKeyTipTarget |
| 1709 | 16299 | OnCharacterReceived |
| 1709 | 16299 | OnPreviewKeyDown |
| 1709 | 16299 | OnPreviewKeyUp |
| 1809 | 17763 | BackgroundSizing |
| 1809 | 17763 | CornerRadius |

## -examples

## -see-also

[FrameworkElement](../windows.ui.xaml/frameworkelement.md), [Controls by function](/windows/uwp/controls-and-patterns/controls-by-function), [Control templates](/windows/uwp/design/controls-and-patterns/control-templates), [Styling controls](/windows/uwp/controls-and-patterns/styling-controls), [Storyboarded animations for visual states](/previous-versions/windows/apps/jj819808(v=win.10)), [Focus visuals sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlFocusVisuals), [Gamepad-style navigation (XAML) sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlGamepadNavigation)
