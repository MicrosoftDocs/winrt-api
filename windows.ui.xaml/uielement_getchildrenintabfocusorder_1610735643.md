---
-api-id: M:Windows.UI.Xaml.UIElement.GetChildrenInTabFocusOrder
-api-type: winrt method
---

<!-- Method syntax.
virtual protected IIterable<DependencyObject> UIElement.GetChildrenInTabFocusOrder()
-->

# Windows.UI.Xaml.UIElement.GetChildrenInTabFocusOrder

## -description

Enables a [UIElement](uielement.md) subclass to expose child elements that take part in Tab focus.



## -returns

A collection of the UIElement's child elements that take part in Tab focus.

## -remarks

The default behavior for this method is to return the UIElement's collection of child elements.

When Tab is processed to move focus, the framework’s focus management calls the **GetChildrenInTabFocusOrder** override. The resulting list of DependencyObjects is used to process Tab focus instead of the element's default collection of children.

## -see-also

## -examples
