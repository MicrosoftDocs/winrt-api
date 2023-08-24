---
-api-id: T:Windows.Devices.Printers.PdlPassthroughProvider
-api-type: winrt class
---

# Windows.Devices.Printers.PdlPassthroughProvider

<!--
public sealed class PdlPassthroughProvider
-->


## -description

Represents a page description language (PDL) pass-through provider.

## -remarks

A page description language (PDL) is a formal way of describing a printed page at a high level (whereas a low-level way of describing a printed page might be a bitmap or raster). One well-known example of a PDL is the PDF format. The default format for Windows printing is XPS. And by default all printing content is converted to XPS before being converted to the particular PDL format that the printer supports. When the PDL is PDF, for example, converting by way of XPS causes some quality loss. And that's because XPS doesn't support the color fidelity that's supported by PDF.

But you can perform high-quality printing by what's called PDL pass-through. For example, you can pass a PDF document from a PDF printing application directly to an Internet Printing Protocol (IPP) printer whose PDL is PDF. And that process bypasses any intermediary and lossy conversion to XPS. The PDL in question needn't necessarily be PDF; you can perform PDL pass-through with any PDL.

The target printers for PDL pass-through are IPP Printers. With IPP Printers, there are no custom drivers; and print support applications (PSAs) can be added in order to provide customization. Also, the Windows print system can identify the PDL formats that are supported by the printer.

You can check whether a printer is an IPP by calling [IppPrintDevice.IsIppPrinter](./ippprintdevice_isippprinter_869798417.md); and you can check whether an IPP printer supports PDL pass-through by getting the value of the [IppPrintDevice.IsPdlPassthroughSupported](./ippprintdevice_ispdlpassthroughsupported_1510208979.md) property. Then, you can begin a print job by using a **PdlPassthroughProvider**, and write PDL content via PDL pass-through.

## -see-also

## -examples
