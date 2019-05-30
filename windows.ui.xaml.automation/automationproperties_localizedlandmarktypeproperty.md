---
-api-id: P:Windows.UI.Xaml.Automation.AutomationProperties.LocalizedLandmarkTypeProperty
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DependencyProperty LocalizedLandmarkTypeProperty { get; }
-->

# Windows.UI.Xaml.Automation.AutomationProperties.LocalizedLandmarkTypeProperty

## -description
Gets the identifier for the localized landmark type attached property, which is a localized text string describing the type of landmark that the automation element represents.

## -property-value
The identifier for the localized landmark type attached property.

## -remarks
This should be used in tandem with [UIA_CustomLandmarkTypeId](https://docs.microsoft.com/windows/desktop/WinAuto/landmark-type-identifiers) however, **LocalizedLandmarkType** should always take precedence over **LandmarkType** and be used to describe the landmark before **LandmarkType**.

The string must match the application UI language or the operating system default UI language.

## -examples

## -see-also
