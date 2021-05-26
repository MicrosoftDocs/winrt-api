---
-api-id: P:Windows.UI.Xaml.Automation.AutomationProperties.AutomationId
-api-type: winrt attachedproperty
---

# Windows.UI.Xaml.Automation.AutomationProperties.AutomationId

<!--
see GetAutomationId, and SetAutomationId
-->


## -description

Gets or sets the string that uniquely identifies the element to Microsoft UI Automation.

## -remarks

When it is available, the `AutomationId` of an element must be the same in any instance of the application, regardless of the local language. The value should be unique among sibling elements, but not necessarily unique across the entire desktop. For example, multiple instances of an application, or multiple folder views in Windows Explorer, can contain elements with the same `AutomationId` property, such as "SystemMenuBar".

Although support for `AutomationId` is always recommended for better automated testing support, this property is not mandatory. Where it is supported, `AutomationId` is useful for creating a test automation script that runs regardless of the UI language. Clients should make no assumptions regarding the `AutomationId` values exposed by other applications. `AutomationId` is not guaranteed to be stable across different releases or builds of an application.

<ul><li>Type: string</li><li>Identifier field: <a href="/uwp/api/windows.ui.xaml.automation.automationproperties.automationidproperty">AutomationIdProperty</a></li><li>Accessor methods: <a href="/uwp/api/windows.ui.xaml.automation.automationproperties.getautomationid">GetAutomationId</a>, <a href="/uwp/api/windows.ui.xaml.automation.automationproperties.setautomationid">SetAutomationId</a></li></ul>

## -see-also

[XAML attached properties](/windows/uwp/xaml-platform/attached-properties-overview)

## -examples


