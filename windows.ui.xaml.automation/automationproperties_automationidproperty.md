---
-api-id: P:Windows.UI.Xaml.Automation.AutomationProperties.AutomationIdProperty
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DependencyProperty AutomationIdProperty { get; }
-->

# Windows.UI.Xaml.Automation.AutomationProperties.AutomationIdProperty

## -description
Identifies the [AutomationProperties.AutomationId](automationproperties_automationid.md) attached property, which is a string containing the UI Automation identifier (ID) for the automation element.

## -property-value
The identifier for the [AutomationProperties.AutomationId](automationproperties_automationid.md) attached property.

## -remarks
When it is available, the [AutomationId](automationproperties_automationid.md) of an element must be the same in any instance of the application, regardless of the local language. The value should be unique among sibling elements, but not necessarily unique across the entire desktop. For example, multiple instances of an application, or multiple folder views in Windows Explorer, can contain elements with the same [AutomationId](automationproperties_automationid.md) property, such as "SystemMenuBar".

Although support for [AutomationId](automationproperties_automationid.md) is always recommended for better automated testing support, this property is not mandatory. Where it is supported, [AutomationId](automationproperties_automationid.md) is useful for creating a test automation script that runs regardless of the UI language. Clients should make no assumptions regarding the [AutomationId](automationproperties_automationid.md) values exposed by other applications. [AutomationId](automationproperties_automationid.md) is not guaranteed to be stable across different releases or builds of an application.

## -examples

## -see-also
