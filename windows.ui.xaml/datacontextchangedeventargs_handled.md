---
-api-id: P:Windows.UI.Xaml.DataContextChangedEventArgs.Handled
-api-type: winrt property
---

<!-- Property syntax
public bool Handled { get;  set; }
-->

# Windows.UI.Xaml.DataContextChangedEventArgs.Handled

## -description
Gets or sets a value that influences whether another [DataContextChanged](datacontextchangedeventargs.md) event should be fired from child elements that inherit the [DataContext](frameworkelement_datacontext.md) value and detect that the value has changed.



## -property-value
**true** to prevent further [DataContextChanged](datacontextchangedeventargs.md) events from being fired for each child [FrameworkElement](frameworkelement.md) that inherits the [DataContext](frameworkelement_datacontext.md) value. You would do this to indicate to other handlers that the necessary logic for responding to the data context change has already been performed. **false** to permit the event to be fired by each immediate child [FrameworkElement](frameworkelement.md) in the element tree that detects a change to the inherited [DataContext](frameworkelement_datacontext.md) value. The default is **false**.

## -remarks

## -examples

## -see-also
[FrameworkElement.DataContext](frameworkelement_datacontext.md)
