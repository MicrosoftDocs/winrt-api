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
Error information for [SetErrorInfo](http://msdn.microsoft.com/library/8eaacfac-fc37-4eaa-870b-10b99d598d66) is used.

### -field SuppressSetErrorInfo:8
Error information for [SetErrorInfo](http://msdn.microsoft.com/library/8eaacfac-fc37-4eaa-870b-10b99d598d66) is suppressed and not reported.


## -remarks

## -examples

## -see-also
[GetErrorOptions](runtimebrokererrorsettings_geterroroptions.md), [SetErrorOptions](runtimebrokererrorsettings_seterroroptions.md)
