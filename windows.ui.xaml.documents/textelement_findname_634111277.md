---
-api-id: M:Windows.UI.Xaml.Documents.TextElement.FindName(System.String)
-api-type: winrt method
---

<!-- Method syntax
public object FindName(System.String name)
-->

# Windows.UI.Xaml.Documents.TextElement.FindName

## -description
Retrieves an object in the object model / runtime object graph by referencing the object's **x:Name** or **Name** attribute value.



## -parameters
### -param name
The name of the object to retrieve.

## -returns
The object that has the specified name, or null if no object is retrieved.

## -remarks
[FrameworkElement](../windows.ui.xaml/frameworkelement.md) is the class that implements [Name](../windows.ui.xaml/frameworkelement_name.md) support for most other run-time classes, but [TextElement](textelement.md) is not a [FrameworkElement](../windows.ui.xaml/frameworkelement.md) derived class. [TextElement](textelement.md) supports its own [Name](textelement_name.md) and FindName implementations, and the underlying logic for name lookup does not differentiate between [TextElement](textelement.md) and [FrameworkElement](../windows.ui.xaml/frameworkelement.md). You can use the [TextElement](textelement.md)-implemented FindName to find a named [FrameworkElement](../windows.ui.xaml/frameworkelement.md), and vice versa.

Because FindName relies on all the XAML sources being parsed for the **Name** attributes, you should not attempt to call FindName until the XAML is loaded.

Names and FindName are influenced by the concept of a XAML namescope. 
<!--For more information, see ...-->

## -examples

## -see-also
