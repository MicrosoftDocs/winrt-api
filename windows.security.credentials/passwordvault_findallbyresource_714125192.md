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
When this method returns, contains an [IVectorView](https://msdn.microsoft.com/library/644aa3d0-6f4d-406e-9adc-7f02fe575e90) of credential objects that match the search criteria.

## -remarks
Each object returned will have the proper resource and user name, but it will not include the password.

## -examples

## -see-also
