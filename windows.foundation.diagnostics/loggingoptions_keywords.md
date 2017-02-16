---
-api-id: P:Windows.Foundation.Diagnostics.LoggingOptions.Keywords
-api-type: winrt property
---

<!-- Property syntax
public long Keywords { get;  set; }
-->

# Windows.Foundation.Diagnostics.LoggingOptions.Keywords

## -description
Gets or sets the keyword value that represents the different categories that an event belongs to.

## -property-value
The keyword value.

## -remarks
Each bit represents a category that an event belongs to. Event Tracing for Windows (ETW) tools are able to filter events based on keyword.

> [!IMPORTANT]
> Only the lower 48 bits are available for user-defined event categories. The top eight bits of the keyword value are reserved for future definition and must be set to zero (0). The next eight bits are reserved by Microsoft.

## -examples

## -see-also
