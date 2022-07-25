---
-api-id: T:Windows.UI.Xaml.Markup.XamlBinaryWriter
-api-type: winrt class
---

<!-- Class syntax.
public class XamlBinaryWriter : Windows.UI.Xaml.Markup.IXamlBinaryWriter
-->

# Windows.UI.Xaml.Markup.XamlBinaryWriter

## -description
Produces a pre-parsed binary representation of a XAML production.



## -remarks
The binary representation of XAML uses an XBF file extension. The binary representation enables performance advantages versus loading and parsing a XAML file as text. Loading the binary representation is most useful when loading XAML files that define large resources, such as the generic.xaml files that define templates.

XamlBinaryWriter is not intended for use by typical app code. It is intended for use by tools and processes that are directly involved in producing an app package on a developer's machine.

The XBF format is intended to be write-once. Anyone compiling into the XBF format should always maintain that same XAML in its text representation, so that tools or processes can edit the XAML, and so that the source XAML remains human-readable.

## -examples

## -see-also
