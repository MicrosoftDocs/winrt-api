---
-api-id: M:Windows.Security.Credentials.PasswordVault.FindAllByUserName(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IVectorView<Windows.Security.Credentials.PasswordCredential> FindAllByUserName(System.String userName)
-->

# Windows.Security.Credentials.PasswordVault.FindAllByUserName

## -description
Searches the Credential Locker for credentials that match the user name specified.

## -parameters
### -param userName
The user name to be searched for. If a match does not exist, an exception will throw. 

## -returns
When this method returns, contains an [IVectorView](/previous-versions/br224594(v=vs.85)) of credential objects that match the search criteria.

## -remarks
Each object returned will have the proper resource and user name, but it will not include the password.

## -examples

## -see-also
