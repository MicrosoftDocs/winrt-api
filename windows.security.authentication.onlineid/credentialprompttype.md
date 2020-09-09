---
-api-id: T:Windows.Security.Authentication.OnlineId.CredentialPromptType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Security.Authentication.OnlineId.CredentialPromptType : int
-->

# CredentialPromptType

## -description
Provides the ability to control when to show or hide the credential prompt user interface. This includes the user interface for the app to collect user consent to access data stored in Live. The user must see the user interface in order for the app to obtain any user data, if not app will see an error when they try to obtain user data.

> [!NOTE]
> If you are developing for Windows 10 or greater, use the [Windows.Security.Authentication.Web.Core](../windows.security.authentication.web.core/windows_security_authentication_web_core.md) APIs instead. For more information, see [Web account manager](/windows/uwp/security/web-account-manager).

## -enum-fields
### -field PromptIfNeeded:0
Show the UI only if an error occurred.

### -field RetypeCredentials:1
Always show the UI. If a default username exists, the username is automatically inserted into the appropriate field.

### -field DoNotPrompt:2
Never show the UI, even if an error occurs.


## -remarks

## -examples

## -see-also