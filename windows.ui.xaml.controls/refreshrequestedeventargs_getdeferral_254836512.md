---
-api-id: M:Windows.UI.Xaml.Controls.RefreshRequestedEventArgs.GetDeferral
-api-type: winrt method
---

<!-- Method syntax.
public Deferral RefreshRequestedEventArgs.GetDeferral()
-->

# Windows.UI.Xaml.Controls.RefreshRequestedEventArgs.GetDeferral

## -description

Gets a deferral object for managing the work done in the RefreshRequested event handler.

## -returns

A deferral object.

## -remarks

A deferral should be used if any asynchronous work is being done in the RefreshRequested event handler, so that the next event in the sequence isn't raised until this work is completed.

## -see-also

## -examples
