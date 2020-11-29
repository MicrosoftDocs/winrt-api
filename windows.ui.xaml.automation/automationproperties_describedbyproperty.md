---
-api-id: P:Windows.UI.Xaml.Automation.AutomationProperties.DescribedByProperty
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DependencyProperty DescribedByProperty { get; }
-->

# Windows.UI.Xaml.Automation.AutomationProperties.DescribedByProperty

## -description
Gets the identifier for the described by attached property, which is an array of elements that provide more information about the automation element.

Equivalent WinUI property: [Microsoft.UI.Xaml.Automation.AutomationProperties.DescribedByProperty](/windows/winui/api/microsoft.ui.xaml.automation.automationproperties.describedbyproperty).

## -property-value
The identifier for the described by attached property.

## -remarks
**DescribedBy** is used when an automation element is explained by another segment of the application UI. For example, the property can point to a text element of "2,529 items in 85 groups, 10 items selected" from a complex custom list object. Instead of using the object model for clients to digest similar information, the **DescribedBy** property can offer quick access to the UI element that may already offer useful end-user information that describes the UI element.

## -examples

## -see-also
