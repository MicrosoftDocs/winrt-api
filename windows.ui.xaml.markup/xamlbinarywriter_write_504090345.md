---
-api-id: M:Windows.UI.Xaml.Markup.XamlBinaryWriter.Write(Windows.Foundation.Collections.IVector{Windows.Storage.Streams.IRandomAccessStream},Windows.Foundation.Collections.IVector{Windows.Storage.Streams.IRandomAccessStream},Windows.UI.Xaml.Markup.IXamlMetadataProvider)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Xaml.Markup.XamlBinaryWriterErrorInformation Write(Windows.Foundation.Collections.IVector<Windows.Storage.Streams.IRandomAccessStream> inputStreams, Windows.Foundation.Collections.IVector<Windows.Storage.Streams.IRandomAccessStream> outputStreams, Windows.UI.Xaml.Markup.IXamlMetadataProvider xamlMetadataProvider)
-->

# Windows.UI.Xaml.Markup.XamlBinaryWriter.Write

## -description
Produces a binary representation of XAML. Input streams are produced in text representation, and output streams are populated with XAML in binary (XBF) representation.

> [!IMPORTANT]
> [XamlBinaryWriter](xamlbinarywriter.md) is not intended for use by typical app code. It is intended for use by tools and processes that are directly involved in producing an app package on a developer's machine.



## -parameters
### -param inputStreams
The set of input streams. These are expected to access the text representation of the XAML to write into XBF format.

### -param outputStreams
The set of output streams. When the method returns each output stream provides access to the XBF binary representation. You'd typically use this stream to create a file.

### -param xamlMetadataProvider
A helper object that maps types for XAML productions.

## -returns
A structure that captures any error information that is reported by the conversion into XBF format.

## -remarks
Any input stream that generated error information is skipped and won't write anything into the corresponding output stream.

## -examples

## -see-also
