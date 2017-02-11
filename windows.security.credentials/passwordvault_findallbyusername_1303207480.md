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
The user name to be searched for.

## -returns
When this method returns, contains an [IVectorView](http://msdn.microsoft.com/library/644aa3d0-6f4d-406e-9adc-7f02fe575e90) of credential objects that match the search criteria.

## -remarks
Each object returned will have the proper resource and user name, but it will not include the password.

## -examples

## -see-also
