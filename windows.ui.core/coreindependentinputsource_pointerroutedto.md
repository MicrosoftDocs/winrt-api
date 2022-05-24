---
-api-id: E:Windows.UI.Core.CoreIndependentInputSource.PointerRoutedTo
-api-type: winrt event
---

# Windows.UI.Core.CoreIndependentInputSource.PointerRoutedTo

<!--
public event Windows.Foundation.TypedEventHandler<Windows.UI.Core.ICorePointerRedirector,Windows.UI.Core.PointerEventArgs> PointerRoutedTo;
-->

## -description

Occurs when captured pointer input previously being delivered to another object, transitions to being delivered to this object.

## -remarks

A [CoreIndependentInputSource.PointerPressed](coreindependentinputsource_pointerpressed.md) event is not fired for the associated pointer if a [PointerRoutedTo](coreindependentinputsource_pointerroutedto.md) event is fired on the input object first.

## -examples

## -see-also

[SetPointerCapture](icorewindow_setpointercapture_651539121.md)
