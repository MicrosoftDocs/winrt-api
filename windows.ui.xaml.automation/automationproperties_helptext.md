---
-api-id: P:Windows.UI.Xaml.Automation.AutomationProperties.HelpText
-api-type: winrt attachedproperty
---

# Windows.UI.Xaml.Automation.AutomationProperties.HelpText

<!--
see GetHelpText, and SetHelpText
-->

## -description

Gets or sets a help text string associated with the automation element.

## -remarks

The `HelpText` property is typically obtained from [tooltip](../windows.ui.xaml.controls/tooltip.md) text associated with the element. The property can also be supported with placeholder text appearing in edit or list controls. For example, "Type text here for search" is a good candidate the `HelpText` property for an edit control that places the text prior to the user's actual input. However, it is not adequate for the name property of the edit control.

When `HelpText` is supported, the string must match the application UI language or the operating system default UI language.

<ul><li>Type: string</li><li>Identifier field: <a href="/uwp/api/windows.ui.xaml.automation.automationproperties.helptextproperty">HelpTextProperty</a></li><li>Accessor methods: <a href="/uwp/api/windows.ui.xaml.automation.automationproperties.gethelptext">GetHelpText</a>, <a href="/uwp/api/windows.ui.xaml.automation.automationproperties.sethelptext">SetHelpText</a></li></ul>

## -see-also

[XAML attached properties](/windows/uwp/xaml-platform/attached-properties-overview)

## -examples
