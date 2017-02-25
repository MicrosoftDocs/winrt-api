---
-api-id: P:Windows.UI.Xaml.Automation.AutomationProperties.NameProperty
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DependencyProperty NameProperty { get; }
-->

# Windows.UI.Xaml.Automation.AutomationProperties.NameProperty

## -description
Identifies the [AutomationProperties.Name](automationproperties_name.md) attached property, which is a string that holds the name of the automation element.

## -property-value
The identifier for the [AutomationProperties.Name](automationproperties_name.md) attached property.

## -remarks
The [Name](automationproperties_name.md) property should be the same as the label text on screen. For example, [Name](automationproperties_name.md) should be "Browse" for a button element with the label "Browse". The [Name](automationproperties_name.md) property must not include the mnemonic character for the access keys (that is, "&amp;"), which is underlined in the UI text presentation. Also, the [Name](automationproperties_name.md) property should not be an extended or modified version of the on-screen label because the inconsistency between the name and the label can cause confusion among client applications and users.

When the corresponding label text is not visible on screen, or when it is replaced by graphics, alternative text should be chosen. The alternative text should be concise, intuitive, and localized to the application UI language, or to the operating system default UI language. The alternative text should not be a detailed description of the visual details, but a concise description of the UI function or feature as if it were labeled by simple text. For example, the Windows Start menu button is named "Start" (button) instead of "Windows Logo on blue round sphere graphics" (button). For more information, see [Creating Text Equivalents for Images](https://msdn.microsoft.com/library/ms971334).

When a UI label uses text graphics (for example, using "&gt;&gt;" for a button that adds an item from left to right), the [Name](automationproperties_name.md) property should be overridden by an appropriate text alternative (for example, "Add"). However the practice of using text graphics as a UI label is discouraged due to both localization and accessibility concerns.

The [Name](automationproperties_name.md) property must not include the control role or type information, such as "button" or "list"; otherwise, it will conflict with the text from the [LocalizedControlType](automationproperties_localizedcontroltypeproperty.md) property when these two properties are appended (many existing assistive technologies do this).

The [Name](automationproperties_name.md) property cannot be used as a unique identifier among siblings. However, as long as it is consistent with the UI presentation, the same [Name](automationproperties_name.md) value can be supported among peers. For test automation, the clients should consider using the [AutomationId](automationproperties_automationid.md) or [RuntimeId](../windows.ui.xaml.automation.peers/rawelementproviderruntimeid.md) property.

Text controls do not always have to have the [Name](automationproperties_name.md) property be identical to the text that is displayed within the control, so long as the **Text** pattern is also supported.

## -examples

## -see-also
