---
-api-id: T:Windows.Media.Protection.HdcpSetProtectionResult
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.Protection.HdcpSetProtectionResult : int
-->

# HdcpSetProtectionResult

## -description
Describes whether setting HDCP was successful.

## -enum-fields
### -field Success:0
HDCP was successfully set.

### -field TimedOut:1
The HDCP operation timed out and protection was not set.

### -field NotSupported:2
The device doesn't support the HDCP level that was attempted.

### -field UnknownFailure:3
The HDCP operation failed for an unknown reason.


## -remarks
You can call [GetResults](/uwp/api/Windows.Foundation.IAsyncOperation_TResult_#Windows_Foundation_IAsyncOperation_1_GetResults) on the HDCP operation, and then check that against this enumeration in order to determine whether it was successful or not. See [HdcpSession](hdcpsession.md) for a usage example.

## -examples

## -see-also