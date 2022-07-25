---
-api-id: M:Windows.UI.Xaml.Automation.Provider.ITextRangeProvider.Move(Windows.UI.Xaml.Automation.Text.TextUnit,System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public int Move(Windows.UI.Xaml.Automation.Text.TextUnit unit, System.Int32 count)
-->

# Windows.UI.Xaml.Automation.Provider.ITextRangeProvider.Move

## -description
Moves the text range the specified number of text units.



## -parameters
### -param unit
The text unit boundary.

### -param count
The number of text units to move. A positive value moves the text range forward; a negative value moves the text range backward; and a value of 0 has no effect.

## -returns
The number of units actually moved. This value can be less than the *count* requested if either of the new text range endpoints is greater than or less than the [DocumentRange](itextprovider_documentrange.md) endpoints. This value can be negative if navigation is happening in the backward direction.

## -remarks

## -examples

## -see-also
