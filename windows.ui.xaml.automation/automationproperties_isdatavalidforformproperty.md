---
-api-id: P:Windows.UI.Xaml.Automation.AutomationProperties.IsDataValidForFormProperty
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DependencyProperty IsDataValidForFormProperty { get; }
-->

# Windows.UI.Xaml.Automation.AutomationProperties.IsDataValidForFormProperty

## -description
Identifies the Boolean dependency property that indicates if the data is valid for the form.

## -property-value
The dependency property identifier.

## -remarks
The **IsDataValidForForm** property indicates whether the entered or selected value is valid for the form rule associated with the automation element. For example, if the user entered "425-555-5555" for a zip code field that requires 5 or 9 digits, the **IsDataValidForForm** property can be set to **false** to indicate that the data is not valid.

## -examples

## -see-also
