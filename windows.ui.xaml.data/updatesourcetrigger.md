---
-api-id: T:Windows.UI.Xaml.Data.UpdateSourceTrigger
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Data.UpdateSourceTrigger : int
-->

# UpdateSourceTrigger

## -description

Defines constants that indicate when a binding source is updated by its binding target in two-way binding.

## -enum-fields

### -field Default:0

Use default behavior from the dependency property that uses the binding.

### -field PropertyChanged:1

The binding source is updated whenever the binding target value changes. This is detected automatically by the binding system.

### -field Explicit:2

The binding source is updated only when you call the [BindingExpression.UpdateSource](bindingexpression_updatesource_190615267.md) method. (Not supported for `x:Bind`.)

### -field LostFocus:3

The binding source is updated whenever the binding target element loses focus.

## -remarks

> [!NOTE]
> The default UpdateSourceTrigger value is `Default` rather than `PropertyChanged` for legacy reasons. This evaluates as a `PropertyChanged` update behavior for most dependency properties, but evaluates as `LostFocus` for the `TextBox.Text` property.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1709 | 16299 | LostFocus |

## -examples

## -see-also
