---
-api-id: M:Windows.UI.Xaml.Automation.AutomationProperties.GetDescribedBy(Windows.UI.Xaml.DependencyObject)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IVector<Windows.UI.Xaml.DependencyObject> GetDescribedBy(Windows.UI.Xaml.DependencyObject element)
-->

# Windows.UI.Xaml.Automation.AutomationProperties.GetDescribedBy

## -description
Gets a collection of elements that provide more information about the specified automation element.



## -parameters
### -param element
The automation element for which to get the described by collection.

## -returns
A collection of elements that provide more information about the automation element specified by the *element* parameter.

## -remarks
The described by collection is used when an automation element is explained by another segment of the application UI. For example, the collection can contain a text element of "2,529 items in 85 groups, 10 items selected" from a complex custom list object. Instead of using the object model for clients to digest similar information, the described by collection can offer quick access to UI elements that may already offer useful end-user information describing the UI element.

## -examples

## -see-also

[AutomationProperties.DescribedBy](automationproperties_describedby.md)
