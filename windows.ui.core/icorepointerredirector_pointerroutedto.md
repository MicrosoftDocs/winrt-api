---
-api-id: E:Windows.UI.Core.ICorePointerRedirector.PointerRoutedTo
-api-type: winrt event
---

<!-- Event syntax
abstract public event Windows.Foundation.TypedEventHandler PointerRoutedTo<Windows.UI.Core.ICorePointerRedirector,  Windows.UI.Core.PointerEventArgs>
-->

# Windows.UI.Core.ICorePointerRedirector.PointerRoutedTo

## -description
Occurs on the process not currently receiving pointer input when ongoing pointer input, for an existing pointer ID, transitions from one process to another.

An implementation of the [ICorePointerRedirector](icorepointerredirector.md) interface is provided by the [CoreWindow](corewindow.md) class ([PointerRoutedTo](corewindow_pointerroutedto.md)).

## -remarks
This event is not fired on a [PointerPressed](corewindow_pointerpressed.md) event for a new pointer ID on a different process.

A [PointerPressed](corewindow_pointerpressed.md) event is not fired on the current process if a [PointerRoutedTo](corewindow_pointerroutedto.md) event is fired first.



## -examples

## -see-also
