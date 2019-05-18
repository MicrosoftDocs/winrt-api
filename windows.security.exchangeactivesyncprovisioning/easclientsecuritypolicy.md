---
-api-id: T:Windows.Security.ExchangeActiveSyncProvisioning.EasClientSecurityPolicy
-api-type: winrt class
---

<!-- Class syntax.
public class EasClientSecurityPolicy : Windows.Security.ExchangeActiveSyncProvisioning.IEasClientSecurityPolicy
-->

# Windows.Security.ExchangeActiveSyncProvisioning.EasClientSecurityPolicy

## -description
> [!NOTE]
> EasClientSecurityPolicy may be unavailable for releases after Windows 10.

Modern mail apps evaluate and apply the EAS security policies. An EasClientSecurityPolicy object is constructed by the caller app to set policies received from the Exchange server or application.

## -remarks
All of the property values for this class can be retrieved using get() only if the property values are previously set. Getting a policy value without previously setting it will result in HRESULT_FROM_WIN32(ERROR_NO_DATA) returned from the get() call.

## -examples

## -see-also
