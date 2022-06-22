---
-api-id: P:Windows.UI.Xaml.DataContextChangedEventArgs.NewValue
-api-type: winrt property
---

<!-- Property syntax
public object NewValue { get; }
-->

# Windows.UI.Xaml.DataContextChangedEventArgs.NewValue

## -description
Gets the new [DataContext](frameworkelement_datacontext.md) value for the element where the [DataContextChanged](frameworkelement_datacontextchanged.md) event fired.



## -property-value
An object representing the new [DataContext](frameworkelement_datacontext.md) value for the element where the [DataContextChanged](frameworkelement_datacontextchanged.md) event fired.

## -remarks
The NewValue value is only guaranteed to have a correct value during the invocation of your handler. You can't save the [DataContextChangedEventArgs](datacontextchangedeventargs.md) object and expect to be able to use the NewValue property on it in a meaningful way outside of the scope of a handler.

## -examples

## -see-also
