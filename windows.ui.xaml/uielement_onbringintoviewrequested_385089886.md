---
-api-id: M:Windows.UI.Xaml.UIElement.OnBringIntoViewRequested(Windows.UI.Xaml.BringIntoViewRequestedEventArgs)
-api-type: winrt method
---

<!-- Method syntax.
virtual protected void UIElement.OnBringIntoViewRequested(BringIntoViewRequestedEventArgs e)
-->

# Windows.UI.Xaml.UIElement.OnBringIntoViewRequested

## -description
Called before the [BringIntoViewRequested](uielement_bringintoviewrequested.md) event occurs.


## -parameters
### -param e
The data for the event.

## -remarks
As it's implemented directly on [UIElement](uielement.md), OnBringIntoViewRequested has an empty implementation. But, an ancestor in an element's hierarchy may have provided an implementation such as a base scrolling control. You won't be able to see this implementation because it's internal native code. Control code or your code probably shouldn't be suppressing the event, because it's a common pattern to let the event bubble to the root visual so that any scrolling control in the element tree will have an opportunity to react to the request.

## -see-also

[BringIntoViewRequested](uielement_bringintoviewrequested.md) 

## -examples

