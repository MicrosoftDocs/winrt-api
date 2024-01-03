---
-api-id: M:Windows.Devices.Printers.IppPrintDevice.IsPdlPassthroughSupported(System.String)
-api-type: winrt method
---

# Windows.Devices.Printers.IppPrintDevice.IsPdlPassthroughSupported(System.String)

<!--
public bool IsPdlPassthroughSupported (string pdlContentType);
-->


## -description

Determines whether the Internet Printing Protocol (IPP) printer device supports page description language (PDL) pass-through for a given PDL format.

## -parameters

### -param pdlContentType

A string representing a PDL format. For example, "application/pdf" or "application/postscript". If *pdlContentType* is null, then the method returns `true` if the printer supports passthrough for *any* PDL.

## -returns

`true` if the printer supports pass-through for the PDL specified in *pdlContentType*; otherwise, `false`.

## -remarks

For more info about PDL, and PDL pass-through, see Remarks in [PdlPassthroughProvider](./pdlpassthroughprovider.md).

If a print support application (PSA) is installed, then the PSA can disable PDL pass-through.

## -see-also

## -examples
