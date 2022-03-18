---
-api-id: M:Windows.Security.Credentials.PasswordVault.FindAllByResource(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IVectorView<Windows.Security.Credentials.PasswordCredential> FindAllByResource(System.String resource)
-->

# Windows.Security.Credentials.PasswordVault.FindAllByResource

## -description
Searches the Credential Locker for credentials matching the resource specified.

## -parameters
### -param resource
The resource to be searched for. If a match does not exist, an exception will throw. 

## -returns
When this method returns, contains an [IVectorView](/previous-versions/br224594(v=vs.85)) of credential objects that match the search criteria.

## -remarks
Each object returned will have the proper resource and user name, but it will not include the password.

## -examples

## -see-also
