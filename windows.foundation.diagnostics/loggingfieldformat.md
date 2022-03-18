---
-api-id: T:Windows.Foundation.Diagnostics.LoggingFieldFormat
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Foundation.Diagnostics.LoggingFieldFormat : int
-->

# LoggingFieldFormat

## -description
Specifies the format of an event field.

## -enum-fields
### -field Default:0
No format is specified.

### -field Hidden:1
The field is hidden.

### -field String:2
The field contains a MBCS (8-bit character) string.

### -field Boolean:3
A boolean field.

### -field Hexadecimal:4
A hexadecimal field.

### -field ProcessId:5
A process identifier field.

### -field ThreadId:6
A thread identifier field.

### -field Port:7
A port number field.

### -field Ipv4Address:8
An Internet Protocol version 4 (IPv4) field.

### -field Ipv6Address:9
An Internet Protocol version 6 (IPv6) field.

### -field SocketAddress:10
A socket address field.

### -field Xml:11
An Extensible Markup Language (XML) field.

### -field Json:12
A JavaScript Object Notation (JSON) field.

### -field Win32Error:13
A 32-bit **Win32** error code.

### -field NTStatus:14
A 32-bit Windows **NTSTATUS** value.

### -field HResult:15
A 32-bit Windows **HRESULT** value.

### -field FileTime:16
A 64-bit [FILETIME](/windows/desktop/api/minwinbase/ns-minwinbase-filetime) value.

### -field Signed:17
A signed value.

### -field Unsigned:18
An unsigned value.


## -remarks
When an Event Tracing for Windows (ETW) payload is decoded by an event processing tool such as xperf or Windows Performance Analyzer (WPA), the tool may make use of formatting hints to interpret the field. Formatting hints are optional parameters to **LoggingFields.Add**.
<!--add link once class is added-->
For example, an int32 field may specify the **Hexadecimal ** format to indicate that it should be displayed in unsigned-hexadecimal. A byte-array field may specify the **Signed** format to indicate that it should be treated as a series of signed decimal integers, or it may specify the **String** format to indicate that it should be treated as an MBCS (8-bit character) string.

## -examples

## -see-also
