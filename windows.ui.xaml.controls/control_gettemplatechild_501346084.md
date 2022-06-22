---
-api-id: M:Windows.UI.Xaml.Controls.Control.GetTemplateChild(System.String)
-api-type: winrt method
---

<!-- Method syntax
protected Windows.UI.Xaml.DependencyObject GetTemplateChild(System.String childName)
-->

# Windows.UI.Xaml.Controls.Control.GetTemplateChild

## -description
Retrieves the named element in the instantiated [ControlTemplate](controltemplate.md) visual tree.



## -parameters
### -param childName
The name of the element to find.

## -returns
The named element from the template, if the element is found. Can return null if no element with name *childName* was found in the template.

## -remarks
You call GetTemplateChild to get references to objects in a controls [Template](control_template.md) after it's instantiated. The [ControlTemplate](controltemplate.md) is instantiated in the [OnApplyTemplate](../windows.ui.xaml/frameworkelement_onapplytemplate_1955470198.md) method. You can use the GetTemplateChild method inside your [OnApplyTemplate](../windows.ui.xaml/frameworkelement_onapplytemplate_1955470198.md) override and keep a reference to the objects you need.

## -examples

## -see-also
[OnApplyTemplate](../windows.ui.xaml/frameworkelement_onapplytemplate_1955470198.md)
