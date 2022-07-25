---
-api-id: P:Windows.UI.Xaml.Controls.Control.IsEnabled
-api-type: winrt property
---

<!-- Property syntax
public bool IsEnabled { get;  set; }
-->

# Windows.UI.Xaml.Controls.Control.IsEnabled

## -description
Gets or sets a value indicating whether the user can interact with the control.



## -xaml-syntax
```xaml
<control IsEnabled="bool"/>
```


## -property-value
**true** if the user can interact with the control; otherwise, **false**.

## -remarks
Many controls have predefined visual states that are invoked for IsEnabled =**false**, such as "graying out" text in labels.

Whenever IsEnabled changes, that fires the [IsEnabledChanged](control_isenabledchanged.md) event. Controls might handle this event in order to change the visual states. The event has [DependencyPropertyChangedEventArgs](../windows.ui.xaml/dependencypropertychangedeventargs.md) data, so you can determine the old and new values without having to use your own flags.

A control inherits the IsEnabled property from its parent control. For example, if a control that contains a button has IsEnabled set to **false**, the button's IsEnabled property is also **false**. When the parent's property changes, that fires [IsEnabledChanged](control_isenabledchanged.md) for each control where the value changes because of the value inheriting.

How the control logic behaves when disabled is potentially different for each control. However, these behaviors will result in all controls when IsEnabled =**false**:
+ The control can't receive keyboard focus or be focused programmatically.
+ The control does not appear in a tab sequence (any value for [TabIndex](control_tabindex.md) is ignored).
+ A disabled control is still visible to hit testing. It can't handle any input events on itself. However, a disabled control can still source the input events, and input routed events can bubble to a parent where they can be handled.


## -examples

## -see-also
[IsEnabledChanged](control_isenabledchanged.md), [IsTabStop](control_istabstop.md), [Visibility](../windows.ui.xaml/uielement_visibility.md)
