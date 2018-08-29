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
Use default behavior from the dependency property that uses the binding. In Windows Runtime, this evaluates the same as a value with **PropertyChanged**.

### -field PropertyChanged:1
The binding source is updated whenever the binding target value changes. This is detected automatically by the binding system.

### -field Explicit:2
The binding source is updated only when you call the [BindingExpression.UpdateSource](bindingexpression_updatesource_190615267.md) method.


### -field LostFocus:3
The binding source is updated whenever the binding target element loses focus.

## -remarks
> [!NOTE]
> The default [UpdateSourceTrigger](updatesourcetrigger.md) value is **Default** rather than **PropertyChanged** for legacy reasons. Previous XAML frameworks enabled a way to register a dependency property with a value that influenced what its default binding update behavior does. That dependency property behavior isn't implemented in the Windows Runtime.

### Version history

| Version | SDK version | Value added |
| -- | -- | -- |
| 1709 | 16299 | LostFocus |

## -examples

## -see-also
