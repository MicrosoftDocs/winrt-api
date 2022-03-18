---
-api-id: P:Windows.UI.Xaml.Automation.AutomationProperties.LandmarkTypeProperty
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DependencyProperty LandmarkTypeProperty { get; }
-->

# Windows.UI.Xaml.Automation.AutomationProperties.LandmarkTypeProperty

## -description
Gets the identifier for the landmark type attached property, which is a [Landmark Type Identifier](/windows/desktop/WinAuto/landmark-type-identifiers) associated with an element.

Equivalent WinUI property: [Microsoft.UI.Xaml.Automation.AutomationProperties.LandmarkTypeProperty](/windows/winui/api/microsoft.ui.xaml.automation.automationproperties.landmarktypeproperty).

## -property-value
The identifier for the landmark type attached property.

## -remarks
The **LandmarkType** property describes a *landmark*, an element that represents a meaningful group of elements. For example, a search landmark could represent a set of controls related to searching. Landmarks have many similiarities with headings; for more information about how to use landmarks and headings, see [Landmarks and Headings](/windows/uwp/design/accessibility/landmarks-and-headings).

If **CustomLandmarkType** is used then [LocalizedLandmarkType](automationproperties_getlocalizedlandmarktype_1997420092.md) is required to describe the custom landmark.

## -examples

## -see-also
