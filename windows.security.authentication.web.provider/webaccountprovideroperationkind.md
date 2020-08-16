---
-api-id: T:Windows.Security.Authentication.Web.Provider.WebAccountProviderOperationKind
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Security.Authentication.Web.Provider.WebAccountProviderOperationKind : int
-->

# WebAccountProviderOperationKind

## -description
Represents different operations a web account provider can perform. Use this to determine what operation to perform when the provider is activated. Providers must ignore unknown operations.

## -enum-fields
### -field RequestToken:0
Request an authentication token.

### -field GetTokenSilently:1
Get an authentication token without showing any UI.

### -field AddAccount:2
Add a web account.

### -field ManageAccount:3
Manage a web account.

### -field DeleteAccount:4
Delete a web account.

### -field RetrieveCookies:5
Retrieve cookies.

### -field SignOutAccount:6
Sign out a web account.

## -remarks

## -examples

## -see-also
