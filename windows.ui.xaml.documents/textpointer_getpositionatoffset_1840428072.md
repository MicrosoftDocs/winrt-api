---
-api-id: M:Windows.UI.Xaml.Documents.TextPointer.GetPositionAtOffset(System.Int32,Windows.UI.Xaml.Documents.LogicalDirection)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Xaml.Documents.TextPointer GetPositionAtOffset(System.Int32 offset, Windows.UI.Xaml.Documents.LogicalDirection direction)
-->

# Windows.UI.Xaml.Documents.TextPointer.GetPositionAtOffset

## -description
Returns a [TextPointer](textpointer.md) to the position indicated by the specified offset, in symbols, from the beginning of the current [TextPointer](textpointer.md) and in the specified direction.



## -parameters
### -param offset
An offset, in symbols, for which to calculate and return the position. If the offset is negative, the returned [TextPointer](textpointer.md) precedes the current [TextPointer](textpointer.md); otherwise, it follows.

### -param direction
One of the [LogicalDirection](logicaldirection.md) values that specifies the logical direction of the returned [TextPointer](textpointer.md).

## -returns
A [TextPointer](textpointer.md) to the position indicated by the specified offset and in the direction specified by the direction parameter, or null if the offset extends past the end of the content.

## -remarks

## -examples

## -see-also
