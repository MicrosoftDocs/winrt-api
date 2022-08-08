---
-api-id: M:Windows.Foundation.Diagnostics.LoggingFields.AddUInt8Array(System.String,System.Byte[],Windows.Foundation.Diagnostics.LoggingFieldFormat,System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public void AddUInt8Array(System.String name, System.Byte[] value, Windows.Foundation.Diagnostics.LoggingFieldFormat format, System.Int32 tags)
-->

# Windows.Foundation.Diagnostics.LoggingFields.AddUInt8Array

## -description
Adds an 8-bit unsigned integer array field with the specified field name, format, and tags.

## -parameters
### -param name
Name of the event field.

### -param value
The value for the event field. The default format for the array is binary. See the remarks section for other formats that may be specified.

### -param format
The format of the event field. Specifies an optional formatting hint that may be used by Event Tracing for Windows (ETW) tools.

### -param tags
The user-defined tag for the event field. Specifies up to twenty-eight bits of user-defined field processing metadata for use by a custom ETW processing tool. The top four bits are reserved and must be set to zero (0).

## -remarks
Use the *format* parameter to specify the format of the array. You may use the following [LoggingFieldFormat](loggingfieldformat.md) formats:<table>
   <tr><td>Default</td><td>No format is specified.</td></tr>
   <tr><td>Boolean</td><td>Data is treated as an array of boolean values</td></tr>
   <tr><td>Hexadecimal</td><td>Data is treated as an array of 8-bit integers, formatted as hexadecimal</td></tr>
   <tr><td>Ipv6Address</td><td>Data is treated as an IPv6 address</td></tr>
   <tr><td>Json</td><td>Data is treated as a Multi-Byte Character Set (MBCS) JavaScript Object Notation (JSON) string</td></tr>
   <tr><td>Signed</td><td>Data is treated as an array of signed 8-bit integers</td></tr>
   <tr><td>String</td><td>Data is treated as a MBCS string</td></tr>
   <tr><td>SocketAddress</td><td>Data is treated as a [sockaddr](/windows/desktop/WinSock/sockaddr-2)</td></tr>
   <tr><td>Unsigned</td><td>Data is treated as an array of unsigned 8-bit integers</td></tr>
   <tr><td>XML</td><td>Data is treated as an MBCS XML string</td></tr>
</table>



## -examples

## -see-also
[AddUInt8Array(String, Byte\[\])](/uwp/api/windows.foundation.diagnostics.loggingfields.adduint8array#windows-foundation-diagnostics-loggingfields-adduint8array(system-string-system-byte())), [AddUInt8Array(String, Byte\[\], LoggingFieldFormat)](/uwp/api/windows.foundation.diagnostics.loggingfields.adduint8array#windows-foundation-diagnostics-loggingfields-adduint8array(system-string-system-byte()-windows-foundation-diagnostics-loggingfieldformat))