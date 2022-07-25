---
-api-id: P:Windows.UI.Xaml.Automation.AutomationProperties.NameProperty
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DependencyProperty NameProperty { get; }
-->

# Windows.UI.Xaml.Automation.AutomationProperties.NameProperty

## -description

Identifies the [AutomationProperties.Name](automationproperties_name.md) XAML attached property.



## -property-value
The identifier for the [AutomationProperties.Name](/uwp/api/windows.ui.xaml.automation.automationproperties#xaml-attached-properties) attached property.

## -remarks

The [Name](/uwp/api/windows.ui.xaml.automation.automationproperties#xaml-attached-properties) property should be the same as the label text on screen. For example, [Name](/uwp/api/windows.ui.xaml.automation.automationproperties#xaml-attached-properties) should be "Browse" for a button element with the label "Browse". The [Name](/uwp/api/windows.ui.xaml.automation.automationproperties#xaml-attached-properties) property must not include the mnemonic character for the access keys (that is, "&amp;"), which is underlined in the UI text presentation. Also, the [Name](/uwp/api/windows.ui.xaml.automation.automationproperties#xaml-attached-properties) property should not be an extended or modified version of the on-screen label because the inconsistency between the name and the label can cause confusion among client applications and users.

When the corresponding label text is not visible on screen, or when it is replaced by graphics, alternative text should be chosen. The alternative text should be concise, intuitive, and localized to the application UI language, or to the operating system default UI language. The alternative text should not be a detailed description of the visual details, but a concise description of the UI function or feature as if it were labeled by simple text. For example, the Windows Start menu button is named "Start" (button) instead of "Windows Logo on blue round sphere graphics" (button). For more information, see [Creating Text Equivalents for Images](/previous-versions/windows/desktop/dnacc/creating-text-equivalents-for-images).

## -property-value

The identifier for the [AutomationProperties.Name](automationproperties_name.md) XAML attached property.

## -remarks

## -examples

## -see-also

[AutomationProperties.Name](automationproperties_name.md), [Attached properties overview](/windows/uwp/xaml-platform/attached-properties-overview)
