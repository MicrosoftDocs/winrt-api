---
-api-id: M:Windows.Devices.Printers.IppPrintDevice.GetMaxSupportedPdlVersion(System.String)
-api-type: winrt method
---

# Windows.Devices.Printers.IppPrintDevice.GetMaxSupportedPdlVersion(System.String)

<!--
public string GetMaxSupportedPdlVersion (string pdlContentType);
-->


## -description

Retrieves a string indicating the maximum supported PDL version for the specified PDL content type.

## -parameters

### -param pdlContentType

## -returns

A string indicating the maximum supported PDL version. The format of the string will be "MajorVersion.MinorVersion" where the version numbers are integers. Valid examples include "1.0" and "1.1". Invalid examples include "1.1a" and "1.2b". If the printer does not support PDL or has not specified a maximum version, the return value will be "0".

## -remarks

## -see-also

## -examples


