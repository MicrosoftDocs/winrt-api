---
-api-id: M:Windows.UI.Xaml.RectHelper.GetIsEmpty(Windows.Foundation.Rect)
-api-type: winrt method
---

<!-- Method syntax
public bool GetIsEmpty(Windows.Foundation.Rect target)
-->

# Windows.UI.Xaml.RectHelper.GetIsEmpty

## -description

 Returns whether a specified [Rect](../windows.foundation/rect.md) is equivalent to an [Empty](recthelper_empty.md) [Rect](../windows.foundation/rect.md). C# and Microsoft Visual Basic code should use [Rect.IsEmpty](/dotnet/api/windows.foundation.rect.isempty?view=dotnet-uwp-10.0&preserve-view=true) instead.



## -parameters

### -param target

The [Rect](../windows.foundation/rect.md) to evaluate.

## -returns

 **true** if the specified [Rect](../windows.foundation/rect.md) is equivalent to an [Empty](recthelper_empty.md) [Rect](../windows.foundation/rect.md); otherwise, **false**.

## -remarks

GetIsEmpty will return **false** if the Rect has a width or height of 0. To check whether the size has a nonzero area, inspect Rect.Width and Rect.Height directly instead of calling this method.

## -examples

## -see-also
