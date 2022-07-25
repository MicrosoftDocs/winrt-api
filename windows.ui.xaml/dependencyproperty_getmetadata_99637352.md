---
-api-id: M:Windows.UI.Xaml.DependencyProperty.GetMetadata(Windows.UI.Xaml.Interop.TypeName)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Xaml.PropertyMetadata GetMetadata(Windows.UI.Xaml.Interop.TypeName forType)
-->

# Windows.UI.Xaml.DependencyProperty.GetMetadata

## -description
Retrieves the property metadata value for the dependency property as registered to a type. You specify the type you want info from as a type reference.



## -parameters
### -param forType
The name of the specific type from which to retrieve the dependency property metadata, as a type reference ([System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true) for Microsoft .NET, a [TypeName](../windows.ui.xaml.interop/typename.md) helper struct for Visual C++ component extensions (C++/CX)).

## -returns
A property metadata object.

## -remarks

## -examples
This example implements a utility method that reports the default value of a given dependency property as it exists in [FrameworkElement](frameworkelement.md), based on the default value registered and stored in the metadata.



[!code-csharp[DPGetMetadata](../windows.ui.xaml/code/DOandDP/csharp/Class1.cs#SnippetDPGetMetadata)]

[!code-vb[DPGetMetadata](../windows.ui.xaml/code/DOandDP/vbnet/Class1.vb#SnippetDPGetMetadata)]

## -see-also
[Custom dependency properties](/windows/uwp/xaml-platform/custom-dependency-properties), [Dependency properties overview](/windows/uwp/xaml-platform/dependency-properties-overview)
9e66-f71c-4daa-9994-617c886fda7e)
