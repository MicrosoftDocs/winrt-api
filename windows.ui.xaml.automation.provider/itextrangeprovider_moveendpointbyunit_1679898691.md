---
-api-id: M:Windows.UI.Xaml.Automation.Provider.ITextRangeProvider.MoveEndpointByUnit(Windows.UI.Xaml.Automation.Text.TextPatternRangeEndpoint,Windows.UI.Xaml.Automation.Text.TextUnit,System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public int MoveEndpointByUnit(Windows.UI.Xaml.Automation.Text.TextPatternRangeEndpoint endpoint, Windows.UI.Xaml.Automation.Text.TextUnit unit, System.Int32 count)
-->

# Windows.UI.Xaml.Automation.Provider.ITextRangeProvider.MoveEndpointByUnit

## -description
Moves one endpoint of the text range the specified number of text units within the document range.



## -parameters
### -param endpoint
The endpoint to move.

### -param unit
The text measure unit for moving.

### -param count
The number of units to move. A positive value moves the endpoint forward. A negative value moves it backward. A value of 0 has no effect.

## -returns
The number of units actually moved, which can be less than the number requested if moving the endpoint runs into the beginning or end of the document.

## -remarks

## -examples

## -see-also
