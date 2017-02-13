---
-api-id: M:Windows.UI.Xaml.Controls.Maps.MapControl.TryRotateAsync(System.Double)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> TryRotateAsync(System.Double degrees)
-->

# Windows.UI.Xaml.Controls.Maps.MapControl.TryRotateAsync

## -description
Starts an asynchronous operation to rotate the map's camera from its current position.

## -parameters
### -param degrees
The degrees that the map's camera rotates in a horizontal clockwise direction.

## -returns
Contains the results of the operation: **true** if the operation completed successfully; otherwise, **false**.

## -remarks
Consider this method when you want to replace the default UI control with your own.

Heading values greater than 360 degrees are normalized to their equivalent 0-360 degree value.

## -examples

## -see-also
