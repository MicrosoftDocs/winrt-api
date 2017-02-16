---
-api-id: M:Windows.Media.Protection.HdcpSession.SetDesiredMinProtectionAsync(Windows.Media.Protection.HdcpProtection)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.Protection.HdcpSetProtectionResult> SetDesiredMinProtectionAsync(Windows.Media.Protection.HdcpProtection protection)
-->

# Windows.Media.Protection.HdcpSession.SetDesiredMinProtectionAsync

## -description
Asynchronously attempts to set the protection of the [HdcpSession](hdcpsession.md) instance with the given protection level.

## -parameters
### -param protection
The level of protection at which to set the [HdcpSession](hdcpsession.md) instance.

## -returns
The result of the operation.

## -remarks
It is a good idea to listen for the [Completed](https://msdn.microsoft.com/library/windows/apps/br206599.aspx) event on this function, and then to check the results by calling [GetResults](https://msdn.microsoft.com/library/windows/apps/br206600.aspx) on the operation and compare it to the values of the [HdcpSetProtectionResult](hdcpsetprotectionresult.md) enumeration. This way, you can implement your own logic depending on the result of trying to set HDCP. For a usage example, see [HdcpSession](hdcpsession.md).

## -examples

## -see-also
