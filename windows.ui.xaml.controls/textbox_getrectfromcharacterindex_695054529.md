---
-api-id: M:Windows.UI.Xaml.Controls.TextBox.GetRectFromCharacterIndex(System.Int32,System.Boolean)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Rect GetRectFromCharacterIndex(System.Int32 charIndex, System.Boolean trailingEdge)
-->

# Windows.UI.Xaml.Controls.TextBox.GetRectFromCharacterIndex

## -description
Returns a rectangular region for the leading or trailing edge of a character at a specific character index.



## -parameters
### -param charIndex
A zero-based index of the character for which to retrieve the rectangle.

### -param trailingEdge
**true** to get the trailing edge; **false** to get the leading edge of the character.

## -returns
A rectangle for the edge of the character at the specified index.

## -remarks
To override the context menu, handle the [ContextMenuOpening](textbox_contextmenuopening.md) event and replace the default menu with a custom menu. Use GetRectFromCharacterIndex to determine where to position the custom menu. For an example of this, see Scenario 2 of the [ContextMenu sample](https://github.com/microsoft/Windows-universal-samples/tree/master/archived/ContextMenu). For design info, see [Guidelines for context menus](/windows/uwp/design/controls-and-patterns/index).

Because this method returns a rectangle that represents a character edge, the width of the rectangle that's returned is always 0. To get the width of a character, you must subtract the **X** value of the leading [Rect](../windows.foundation/rect.md) from the **X** value of the trailing [Rect](../windows.foundation/rect.md).

## -examples
This example shows how to use GetRectFromCharacterIndex to determine the rectangle for the selected text. For the complete example, see Scenario 2 of the [ContextMenu sample](https://github.com/microsoft/Windows-universal-samples/tree/master/archived/ContextMenu).

```csharp
// Returns a rect for selected text.
// If no text is selected, returns caret location.
// Text box should not be empty.
private Rect GetTextboxSelectionRect(TextBox textbox)
{
    Rect rectFirst, rectLast;
    if (textbox.SelectionStart == textbox.Text.Length)
    {
        rectFirst = textbox.GetRectFromCharacterIndex(textbox.SelectionStart - 1, true);
    }
    else
    {
        rectFirst = textbox.GetRectFromCharacterIndex(textbox.SelectionStart, false);
    }

    int lastIndex = textbox.SelectionStart + textbox.SelectionLength;
    if (lastIndex == textbox.Text.Length)
    {
        rectLast = textbox.GetRectFromCharacterIndex(lastIndex - 1, true);
    }
    else
    {
        rectLast = textbox.GetRectFromCharacterIndex(lastIndex, false);
    }

    GeneralTransform buttonTransform = textbox.TransformToVisual(null);
    Point point = buttonTransform.TransformPoint(new Point());

    // Make sure that we return a valid rect if selection is on multiple lines
    // and end of the selection is to the left of the start of the selection.
    double x, y, dx, dy;
    y = point.Y + rectFirst.Top;
    dy = rectLast.Bottom - rectFirst.Top;
    if (rectLast.Right > rectFirst.Left)
    {
        x = point.X + rectFirst.Left;
        dx = rectLast.Right - rectFirst.Left;
    }
    else
    {
        x = point.X + rectLast.Right;
        dx = rectFirst.Left - rectLast.Right;
    }

    return new Rect(x, y, dx, dy);
}
```



## -see-also
