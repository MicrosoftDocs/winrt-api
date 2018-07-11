---
-api-id: T:Windows.UI.Xaml.Core.Direct.IXamlDirectObject
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IXamlDirectObject 
-->

# Windows.UI.Xaml.Core.Direct.IXamlDirectObject

## -description

Represents the primary object type that participates in the XamlDirect set of APIs.

## -remarks

The XamlDirect APIs allows middleware authors to access most of Xaml at a more primitive level, achieving better CPU and working set performance.  
[IXamlDirectObject](ixamldirectobject.md) is the minimal handle to Xaml's internal object instances. It is used only by XamlDirect APIs.

## -see-also

[XamlDirect](xamldirect.md) class

## -examples

The following example shows how to create an instance of an internal Xaml object of type Border.

```C#
IXamlDirectObject border = XamlDirect.CreateInstance(XamlTypeIndex.Border);
```