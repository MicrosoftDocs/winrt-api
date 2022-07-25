---
-api-id: P:Windows.UI.Xaml.Automation.AutomationProperties.IsPeripheralProperty
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DependencyProperty IsPeripheralProperty { get; }
-->

# Windows.UI.Xaml.Automation.AutomationProperties.IsPeripheralProperty

## -description

Identifies [AutomationProperties.IsPeripheral](automationproperties_isperipheral.md) XAML attached property.



## -property-value
The dependency property identifier.

## -remarks
Peripheral UI appears and supports user interaction, but does not take keyboard focus when it appears. Examples of peripheral UI includes popups, flyouts, context menus, or floating notifications.

When the **IsPeripheral** property is **true**, a client application can't assume that focus was taken by the element even if it's currently keyboard-interactive.

This property is relevant for these control types:

## -property-value

The identifier for the [AutomationProperties.IsPeripheral](automationproperties_isperipheral.md) XAML attached property.

## -remarks

## -examples

## -see-also

[AutomationProperties.IsPeripheral](automationproperties_isperipheral.md), [XAML attached properties](/windows/uwp/xaml-platform/attached-properties-overview)
