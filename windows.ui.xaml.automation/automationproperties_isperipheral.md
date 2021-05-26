---
-api-id: P:Windows.UI.Xaml.Automation.AutomationProperties.IsPeripheral
-api-type: winrt attachedproperty
---

# Windows.UI.Xaml.Automation.AutomationProperties.IsPeripheral

<!--
see GetIsPeripheral, and SetIsPeripheral
-->

## -description

Gets or sets a value that indicates whether the automation element represents peripheral UI.

## -remarks

Peripheral UI appears and supports user interaction, but does not take keyboard focus when it appears. Examples of peripheral UI includes popups, flyouts, context menus, or floating notifications.

When the `IsPeripheral` property is `true`, a client application can't assume that focus was taken by the element even if it's currently keyboard-interactive.

This property is relevant for these control types:

+ Group controls
+ Menu controls
+ Pane controls
+ ToolBar controls
+ ToolTip controls
+ Window controls
+ Custom controls

<ul><li>Type: Boolean</li><li>Identifier field: <a href="/uwp/api/windows.ui.xaml.automation.automationproperties.isperipheralproperty">IsPeripheralProperty</a></li><li>Accessor methods: <a href="/uwp/api/windows.ui.xaml.automation.automationproperties.getisperipheral">GetIsPeripheral</a>, <a href="/uwp/api/windows.ui.xaml.automation.automationproperties.setisperipheral">SetIsPeripheral</a></li></ul>

## -see-also

[XAML attached properties](/windows/uwp/xaml-platform/attached-properties-overview)

## -examples
