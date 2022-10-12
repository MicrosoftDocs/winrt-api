---
-api-id: M:Windows.Foundation.Diagnostics.LoggingFields.AddUInt8Array(System.String,System.Byte[],Windows.Foundation.Diagnostics.LoggingFieldFormat)
-api-type: winrt method
---

<!-- Method syntax
public void AddUInt8Array(System.String name, System.Byte[] value, Windows.Foundation.Diagnostics.LoggingFieldFormat format)
-->

# Windows.Foundation.Diagnostics.LoggingFields.AddUInt8Array

## -description
Adds an 8-bit unsigned integer array field with the specified field name and format.

## -parameters
### -param name
Name of the event field.

### -param value
The value for the event field. The default format for the array is binary. See the remarks section for other formats that may be specified.

### -param format
The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.

## -remarks
Use the *format* parameter to specify the format of the array. You may use the following [LoggingFieldFormat](loggingfieldformat.md) formats:

| Value | Description |
|---|---|
| Default | No format is specified. |
| Boolean | Data is treated as an array of boolean values |
| Hexadecimal | Data is treated as an array of 8-bit integers, formatted as hexadecimal |
| Ipv6Address | Data is treated as an IPv6 address |
| Json | Data is treated as a Multi-Byte Character Set (MBCS) JavaScript Object Notation (JSON) string |
| Signed | Data is treated as an array of signed 8-bit integers |
| String | Data is treated as a MBCS string |
| SocketAddress | Data is treated as a [sockaddr](/windows/desktop/WinSock/sockaddr-2) |
| Unsigned | Data is treated as an array of unsigned 8-bit integers |
| XML | Data is treated as an MBCS XML string |

## -examples

## -see-also
[AddUInt8Array(String, Byte\[\])](/uwp/api/windows.foundation.diagnostics.loggingfields.adduint8array#windows-foundation-diagnostics-loggingfields-adduint8array(system-string-system-byte())), [AddUInt8Array(String, Byte\[\], LoggingFieldFormat, Int32)](/uwp/api/windows.foundation.diagnostics.loggingfields.adduint8array#windows-foundation-diagnostics-loggingfields-adduint8array(system-string-system-byte()-windows-foundation-diagnostics-loggingfieldformat-system-int32))