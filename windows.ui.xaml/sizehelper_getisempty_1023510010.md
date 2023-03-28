---
-api-id: M:Windows.UI.Xaml.SizeHelper.GetIsEmpty(Windows.Foundation.Size)
-api-type: winrt method
---

<!-- Method syntax
public bool GetIsEmpty(Windows.Foundation.Size target)
-->

# Windows.UI.Xaml.SizeHelper.GetIsEmpty

## -description

 Returns whether a specified [Size](../windows.foundation/size.md) is equivalent to an [Empty](sizehelper_empty.md) [Size](../windows.foundation/size.md). C# and Microsoft Visual Basic code should use [Size.IsEmpty](/dotnet/api/windows.foundation.size.isempty?view=dotnet-uwp-10.0&preserve-view=true) instead.



## -parameters

### -param target

The [Size](../windows.foundation/size.md) to evaluate.

## -returns

 **true** if the specified [Size](../windows.foundation/size.md) is equivalent to an [Empty](sizehelper_empty.md) [Size](../windows.foundation/size.md); otherwise, **false**.

## -remarks

Do not use this method to test for zero area; a size with zero area is not necessarily the [Empty](sizehelper_empty.md) size. For more information, see the [Empty](sizehelper_empty.md) property.

## -examples

## -see-also
