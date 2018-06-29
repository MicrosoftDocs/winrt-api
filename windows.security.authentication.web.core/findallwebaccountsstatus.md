---
-api-id: T:Windows.Security.Authentication.Web.Core.FindAllWebAccountsStatus
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum FindAllWebAccountsStatus : int 
-->

# Windows.Security.Authentication.Web.Core.FindAllWebAccountsStatus

## -description
Contains values that describe the result of a web account enumeration operation (see the **[FindAllAccountsAsync](webauthenticationcoremanager_findallaccountsasync_1139996617.md)** method).

## -enum-fields
### -field Success:0
The enumeration was successful.

### -field ProviderError:3
There was an error with the identity provider. Get the **[ProviderError](findallaccountsresult_providererror.md)** property of the **[FindAllAccountsResult](findallaccountsresult.md)** object for more information.

### -field NotSupportedByProvider:2
The identity provider does not support the account enumeration. For now only inbox providers like MSA and AAD support this operation

### -field NotAllowedByProvider:1
This application is not authenticated to enumerating the list of accounts. Developers must whitelist their apps with the identity provider before they can try to enumerate accounts

## -remarks

## -see-also

## -examples

