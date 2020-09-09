---
-api-id: P:Windows.Services.Store.StoreCanAcquireLicenseResult.ExtendedError
-api-type: winrt property
---

<!-- Property syntax.
public HResult ExtendedError { get; }
-->

# Windows.Services.Store.StoreCanAcquireLicenseResult.ExtendedError

## -description
Gets the error code for the request, if the operation encountered an error.

## -property-value
The error code for the request.

## -remarks

If the **ErrorCode** property of the exception has the value 0x80070005 (E_ACCESSDENIED), this indicates that the specified downloadable content (DLC) add-on is not sellable by the current app. 

## -see-also
[Error codes for Store operations](/windows/uwp/monetize/error-codes-for-store-operations)

## -examples
