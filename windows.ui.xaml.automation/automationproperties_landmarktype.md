---
-api-id: P:Windows.UI.Xaml.Automation.AutomationProperties.LandmarkType
-api-type: winrt attachedproperty
---

# Windows.UI.Xaml.Automation.AutomationProperties.LandmarkType

<!--
see GetLandmarkType, and SetLandmarkType
-->

## -description

Gets or sets a [Landmark Type Identifier](/windows/desktop/WinAuto/landmark-type-identifiers) associated with an element.

## -remarks

The `LandmarkType` property describes a *landmark*, an element that represents a meaningful group of elements. For example, a search landmark could represent a set of controls related to searching. Landmarks have many similarities with headings; for more information about how to use landmarks and headings, see [Landmarks and Headings](/windows/uwp/design/accessibility/landmarks-and-headings).

If `CustomLandmarkType` is used then [LocalizedLandmarkType](automationproperties_localizedlandmarktype.md) is required to describe the custom landmark.

<ul><li>Type: [AutomationLandmarkType](../windows.ui.xaml.automation.peers/automationlandmarktype.md)</li><li>Identifier field: <a href="/uwp/api/windows.ui.xaml.automation.automationproperties.landmarktypeproperty">LandmarkTypeProperty</a></li><li>Accessor methods: <a href="/uwp/api/windows.ui.xaml.automation.automationproperties.getlandmarktype">GetLandmarkType</a>, <a href="/uwp/api/windows.ui.xaml.automation.automationproperties.setlandmarktype">SetLandmarkType</a></li></ul>

## -see-also

[Landmark Type Identifier](/windows/desktop/WinAuto/landmark-type-identifiers), [XAML attached properties](/windows/uwp/xaml-platform/attached-properties-overview)

## -examples
