---
-api-id: P:Windows.UI.Xaml.Automation.AutomationProperties.AutomationIdProperty
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DependencyProperty AutomationIdProperty { get; }
-->

# Windows.UI.Xaml.Automation.AutomationProperties.AutomationIdProperty

## -description
Identifies the [AutomationProperties.AutomationId](/uwp/api/windows.ui.xaml.automation.automationproperties#xaml-attached-properties) attached property, which is a string containing the UI Automation identifier (ID) for the automation element.

Equivalent WinUI property: [Microsoft.UI.Xaml.Automation.AutomationProperties.AutomationIdProperty](/windows/winui/api/microsoft.ui.xaml.automation.automationproperties.automationidproperty).

## -property-value
The identifier for the [AutomationProperties.AutomationId](/uwp/api/windows.ui.xaml.automation.automationproperties#xaml-attached-properties) attached property.

## -remarks
When it is available, the [AutomationId](/uwp/api/windows.ui.xaml.automation.automationproperties#xaml-attached-properties) of an element must be the same in any instance of the application, regardless of the local language. The value should be unique among sibling elements, but not necessarily unique across the entire desktop. For example, multiple instances of an application, or multiple folder views in Windows Explorer, can contain elements with the same [AutomationId](/uwp/api/windows.ui.xaml.automation.automationproperties#xaml-attached-properties) property, such as "SystemMenuBar".

Although support for [AutomationId](/uwp/api/windows.ui.xaml.automation.automationproperties#xaml-attached-properties) is always recommended for better automated testing support, this property is not mandatory. Where it is supported, [AutomationId](/uwp/api/windows.ui.xaml.automation.automationproperties#xaml-attached-properties) is useful for creating a test automation script that runs regardless of the UI language. Clients should make no assumptions regarding the [AutomationId](/uwp/api/windows.ui.xaml.automation.automationproperties#xaml-attached-properties) values exposed by other applications. [AutomationId](/uwp/api/windows.ui.xaml.automation.automationproperties#xaml-attached-properties) is not guaranteed to be stable across different releases or builds of an application.

## -examples

## -see-also
