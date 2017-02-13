---
-api-id: E:Windows.UI.Xaml.UIElement.ContextCanceled
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ContextCanceled<Windows.UI.Xaml.UIElement,  Windows.UI.Xaml.RoutedEventArgs>
-->

# Windows.UI.Xaml.UIElement.ContextCanceled

## -description
Occurs when a context input gesture continues into a manipulation gesture, to notify the element that the context flyout should not be opened.

## -remarks
You typically handle this event for elements that can be manipulated by drag-and-drop. This event is raised when a [ContextRequested](uielement_contextrequested.md) event has been raised, but the element has not received a [PointerReleased](uielement_pointerreleased.md) event before a manipulation begins. This indicates that the user intended to invoke a manipulation rather than a context flyout, so the context flyout should not be opened.

## -examples

## -see-also
