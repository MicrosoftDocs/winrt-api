---
-api-id: E:Windows.UI.Xaml.Controls.Control.IsEnabledChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.DependencyPropertyChangedEventHandler IsEnabledChanged
-->

# Windows.UI.Xaml.Controls.Control.IsEnabledChanged

## -description
Occurs when the [IsEnabled](control_isenabled.md) property changes.



## -xaml-syntax
```xaml
<control IsEnabledChanged="eventhandler"/>
```


## -remarks
Whenever [IsEnabled](control_isenabled.md) changes, that fires the IsEnabledChanged event. Controls might handle this event in order to change the visual states. The event has [DependencyPropertyChangedEventArgs](../windows.ui.xaml/dependencypropertychangedeventargs.md) data, so you can determine the old and new values without having to use your own flags.

A control inherits the [IsEnabled](control_isenabled.md) property from its parent control. For example, if a control that contains a button has [IsEnabled](control_isenabled.md) set to **false**, the button's [IsEnabled](control_isenabled.md) property is also **false**. When the parent's property changes, that fires IsEnabledChanged for each control where the value changes because of the value inheriting.

## -examples

## -see-also
[IsEnabled](control_isenabled.md), [DependencyPropertyChangedEventArgs](../windows.ui.xaml/dependencypropertychangedeventargs.md)
