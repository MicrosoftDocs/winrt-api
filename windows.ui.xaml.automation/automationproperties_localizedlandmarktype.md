---
-api-id: P:Windows.UI.Xaml.Automation.AutomationProperties.LocalizedLandmarkType
-api-type: winrt attachedproperty
---

# Windows.UI.Xaml.Automation.AutomationProperties.LocalizedLandmarkType

<!--
see GetLocalizedLandmarkType, and SetLocalizedLandmarkType
-->

## -description

Gets or sets a localized text string that describes the type of landmark that the automation element represents.

## -remarks

This should be used in tandem with [UIA_CustomLandmarkTypeId](/windows/desktop/WinAuto/landmark-type-identifiers) however, `LocalizedLandmarkType` should always take precedence over [LandmarkType](automationproperties_landmarktype.md) and be used to describe the landmark before `LandmarkType`.

The string must match the application UI language or the operating system default UI language.

<ul><li>Type: string</li><li>Identifier field: <a href="/uwp/api/windows.ui.xaml.automation.automationproperties.localizedlandmarktypeproperty">LocalizedLandmarkTypeProperty</a></li><li>Accessor methods: <a href="/uwp/api/windows.ui.xaml.automation.automationproperties.getlocalizedlandmarktype">GetLocalizedLandmarkType</a>, <a href="/uwp/api/windows.ui.xaml.automation.automationproperties.setlocalizedlandmarktype">SetLocalizedLandmarkType</a></li></ul>

## -see-also

[LandmarkType](automationproperties_landmarktype.md), [XAML attached properties](/windows/uwp/xaml-platform/attached-properties-overview)

## -examples


