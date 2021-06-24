---
-api-id: E:Windows.UI.Core.ICorePointerRedirector.PointerRoutedTo
-api-type: winrt event
---

<!-- Event syntax
abstract public event Windows.Foundation.TypedEventHandler PointerRoutedTo<Windows.UI.Core.ICorePointerRedirector,  Windows.UI.Core.PointerEventArgs>
-->

# Windows.UI.Core.ICorePointerRedirector.PointerRoutedTo

## -description

Occurs when captured pointer input previously being delivered to another object, transitions to being delivered to this object.

## -remarks

A PointerPressed event is not fired on the current process if a [PointerRoutedTo](corewindow_pointerroutedto.md) event is fired first.

## -examples

## -see-also

[CoreWindow.PointerRoutedTo](corewindow_pointerroutedto.md), [CoreIndependentInputSource.PointerRoutedTo](coreindependentinputsource_pointerroutedto.md), [CoreWindow.PointerPressed](corewindow_pointerpressed.md), [CoreIndependentInputSource.PointerPressed](coreindependentinputsource_pointerpressed.md)