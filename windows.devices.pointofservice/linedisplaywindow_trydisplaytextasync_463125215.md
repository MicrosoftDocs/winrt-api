---
-api-id: M:Windows.Devices.PointOfService.LineDisplayWindow.TryDisplayTextAsync(System.String,Windows.Devices.PointOfService.LineDisplayTextAttribute,Windows.Foundation.Point)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<bool> LineDisplayWindow.TryDisplayTextAsync(String text, LineDisplayTextAttribute displayAttribute, Point startPosition)
-->

# Windows.Devices.PointOfService.LineDisplayWindow.TryDisplayTextAsync

## -description
Try to display the specified text at a specified position in the line display window, using the specified display attribute.

## -parameters

### -param text
The text to be displayed.

### -param displayAttribute
The display attribute used. This argument can take one of the following values:

```Csharp
typedef enum LineDisplayTextAttribute
{
  Normal = 0,
  Blink = 1,
  Reverse = 2,
  ReverseBlink = 3
} LineDisplayTextDisplayAttribute;
```

+ Normal: display text normally
+ Blink: display text blinking
+ Reverse: display text reversed
+ ReverseBlink: display text reversed and blinking

### -param startPosition
The row and column at which to start displaying the text.

## -returns
True if the text was displayed successfully; otherwise, false.

## -remarks

## -see-also

## -examples
