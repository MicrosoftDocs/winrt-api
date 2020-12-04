---
-api-id: P:Windows.UI.Xaml.Automation.AutomationProperties.IsPeripheralProperty
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DependencyProperty IsPeripheralProperty { get; }
-->

# Windows.UI.Xaml.Automation.AutomationProperties.IsPeripheralProperty

## -description
Identifies the Boolean dependency property that indicates if the automation element represents peripheral UI.

Equivalent WinUI property: [Microsoft.UI.Xaml.Automation.AutomationProperties.IsPeripheralProperty](/windows/winui/api/microsoft.ui.xaml.automation.automationproperties.isperipheralproperty).

## -property-value
The dependency property identifier.

## -remarks
Peripheral UI appears and supports user interaction, but does not take keyboard focus when it appears. Examples of peripheral UI includes popups, flyouts, context menus, or floating notifications.

When the **IsPeripheral** property is **true**, a client application can't assume that focus was taken by the element even if it's currently keyboard-interactive.

This property is relevant for these control types:


+ Group controls
+ Menu controls
+ Pane controls
+ ToolBar controls
+ ToolTip controls
+ Window controls
+ Custom controls


## -examples

## -see-also
