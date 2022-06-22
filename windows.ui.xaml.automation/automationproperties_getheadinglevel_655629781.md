---
-api-id: M:Windows.UI.Xaml.Automation.AutomationProperties.GetHeadingLevel(Windows.UI.Xaml.DependencyObject)
-api-type: winrt method
---

<!-- Method syntax.
public AutomationHeadingLevel AutomationProperties.GetHeadingLevel(DependencyObject element)
-->

# Windows.UI.Xaml.Automation.AutomationProperties.GetHeadingLevel

## -description

Gets the value of the [AutomationProperties.HeadingLevel](automationproperties_headinglevel.md) property for the specified [DependencyObject](../windows.ui.xaml/dependencyobject.md).



## -parameters

### -param element

The specified [DependencyObject](../windows.ui.xaml/dependencyobject.md).

## -returns

The value of the [AutomationProperties.HeadingLevel](automationproperties_headinglevel.md) property.

## -remarks

Heading elements organize the user interface and make it easier to navigate. Some assistive technology (AT) allows users to quickly jump between headings. Headings have a level from 1 to 9.

![Mouse settings page in Windows Ease of Access settings](images/MouseSettings.png)

Examples of headings would be section titles within the Windows Settings app. For instance, under the **Ease of Access** -> **Mouse** page, **Pointer size**, **Pointer color**, and **Mouse keys** would be a heading of level 1.

## -see-also

[AutomationProperties.HeadingLevel](automationproperties_headinglevel.md), [SetHeadingLevel](automationproperties_setheadinglevel_870496555.md), [Landmarks and Headings](/windows/uwp/design/accessibility/landmarks-and-headings), [Attached properties overview](/windows/uwp/xaml-platform/attached-properties-overview)

## -examples
