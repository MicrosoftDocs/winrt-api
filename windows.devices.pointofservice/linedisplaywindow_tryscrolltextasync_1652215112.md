---
-api-id: M:Windows.Devices.PointOfService.LineDisplayWindow.TryScrollTextAsync(Windows.Devices.PointOfService.LineDisplayScrollDirection,System.UInt32)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<bool> LineDisplayWindow.TryScrollTextAsync(LineDisplayScrollDirection direction, UInt32 numberOfColumnsOrRows)
-->

# Windows.Devices.PointOfService.LineDisplayWindow.TryScrollTextAsync

## -description
Scroll the window text contents the specified number of lines in the specified direction.

## -parameters

### -param direction
The direction in which to scroll text. This argument can contain the following values:
```CSharp
typedef enum LineDisplayScrollDirection
{
  Up = 0,
  Down = 1,
  Left = 2,
  Right = 3
} LineDisplayScrollDirection;
```
+ Up: scroll text upwards
+ Down: scroll text downwards
+ Left: scroll text left
+ Right: scroll text right

### -param numberOfColumnsOrRows
The number of columns or rows to scroll. Columns are used if the scroll direction is left or right, while rows are used if the scroll direction is up or down.

## -returns

## -remarks

## -see-also

## -examples
