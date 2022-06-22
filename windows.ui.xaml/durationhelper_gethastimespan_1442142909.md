---
-api-id: M:Windows.UI.Xaml.DurationHelper.GetHasTimeSpan(Windows.UI.Xaml.Duration)
-api-type: winrt method
---

<!-- Method syntax
public bool GetHasTimeSpan(Windows.UI.Xaml.Duration target)
-->

# Windows.UI.Xaml.DurationHelper.GetHasTimeSpan

## -description

Returns whether the **TimeSpan** component of a given [Duration](duration.md) holds a non-null value. C# and Microsoft Visual Basic code should use [Duration.HasTimeSpan](/dotnet/api/windows.ui.xaml.duration.hastimespan?view=dotnet-uwp-10.0&preserve-view=true) instead.



## -parameters

### -param target

The [Duration](duration.md) value to evaluate.

## -returns

**true** if the **TimeSpan** component of the provided [Duration](duration.md) is not **null**; otherwise, **false**.

## -remarks

If this method returns **false**, then the [Duration](duration.md) is either uninitialized or holds one of the special values of **Automatic** or **Forever**.

## -examples

## -see-also
