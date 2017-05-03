---
-api-id: M:Windows.UI.ApplicationSettings.WebAccountCommand.#ctor(Windows.Security.Credentials.WebAccount,Windows.UI.ApplicationSettings.WebAccountCommandInvokedHandler,Windows.UI.ApplicationSettings.SupportedWebAccountActions)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public WebAccountCommand(Windows.Security.Credentials.WebAccount webAccount, Windows.UI.ApplicationSettings.WebAccountCommandInvokedHandler invoked, Windows.UI.ApplicationSettings.SupportedWebAccountActions actions)
-->

# Windows.UI.ApplicationSettings.WebAccountCommand.WebAccountCommand

## -description
Initializes a new instance of the [WebAccountCommand](webaccountcommand.md) class.

## -parameters
### -param webAccount
The web account to associate with the current command.

### -param invoked
The delegate that handles the command.

### -param actions
A bitmask of web account actions.

## -remarks
Add instances of the [WebAccountCommand](webaccountcommand.md) class to the [WebAccountCommands](accountssettingspanecommandsrequestedeventargs_webaccountcommands.md) collection.

## -examples

## -see-also
[WebAccount](../windows.security.credentials/webaccount.md), [WebAccountCommandInvokedHandler](webaccountcommandinvokedhandler.md), [SupportedWebAccountActions](supportedwebaccountactions.md)