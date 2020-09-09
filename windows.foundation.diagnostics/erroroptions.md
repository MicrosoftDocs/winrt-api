---
-api-id: T:Windows.Foundation.Diagnostics.ErrorOptions
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Foundation.Diagnostics.ErrorOptions : uint
-->

# ErrorOptions

## -description
Specifies the type of diagnostic error reporting for a thread.

## -enum-fields
### -field None:0
No error reporting occurs for the thread.

### -field SuppressExceptions:1
Exceptions are suppressed and not reported.

### -field ForceExceptions:2
Exceptions are reported.

### -field UseSetErrorInfo:4
Error information for [SetErrorInfo](/previous-versions/windows/desktop/api/oleauto/nf-oleauto-seterrorinfo) is used.

### -field SuppressSetErrorInfo:8
Error information for [SetErrorInfo](/previous-versions/windows/desktop/api/oleauto/nf-oleauto-seterrorinfo) is suppressed and not reported.


## -remarks

## -examples

## -see-also
[GetErrorOptions](runtimebrokererrorsettings_geterroroptions_955722078.md), [SetErrorOptions](runtimebrokererrorsettings_seterroroptions_108183281.md)
