---
-api-id: M:Windows.Devices.PointOfService.LineDisplayWindow.ReadCharacterAtCursorAsync
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<uint> LineDisplayWindow.ReadCharacterAtCursorAsync()
-->

# Windows.Devices.PointOfService.LineDisplayWindow.ReadCharacterAtCursorAsync

## -description
Attempts to asynchronously read the currently displayed character at the current cursor position.

## -returns
Returns the code for the character at the current cursor position. Returns 0 if the method fails.

## -remarks
This method requires [LineDisplayCapabilities.CanReadCharacterAtCursor](linedisplaycapabilities_canreadcharacteratcursor.md) to be True to be succesfully executed.

## -see-also

## -examples

