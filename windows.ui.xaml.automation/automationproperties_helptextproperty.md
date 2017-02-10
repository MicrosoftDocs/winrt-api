---
-api-id: P:Windows.UI.Xaml.Automation.AutomationProperties.HelpTextProperty
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DependencyProperty HelpTextProperty { get; }
-->

# Windows.UI.Xaml.Automation.AutomationProperties.HelpTextProperty

## -description
Identifies the [AutomationProperties.HelpText](automationproperties_helptext.md) attached property, which is a help text string associated with the automation element.

## -property-value
The identifier for the [AutomationProperties.HelpText](automationproperties_helptext.md) attached property.

## -remarks
The [HelpText](automationproperties_helptext.md) property is typically obtained from tooltip text associated with the element. The property can also be supported with placeholder text appearing in edit or list controls. For example, "Type text here for search" is a good candidate the [HelpText](automationproperties_helptext.md) property for an edit control that places the text prior to the user's actual input. However, it is not adequate for the name property of the edit control.

When [HelpText](automationproperties_helptext.md) is supported, the string must match the application UI language or the operating system default UI language.

## -examples

## -see-also
