---
-api-id: T:Windows.UI.ApplicationSettings.SupportedWebAccountActions
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.UI.ApplicationSettings.SupportedWebAccountActions : uint
-->

# SupportedWebAccountActions

## -description
Specifies actions that your app enables on an web account instance in the account settings pane.

## -enum-fields
### -field None:0
No action.

### -field Reconnect:1
The app attempts to connect to the web account.

### -field Remove:2
The app removes the web account from the account settings pane.

### -field ViewDetails:4
The app displays details about the web account.

### -field Manage:8
The app displays UI for managing the web account.

### -field More:16
The app does a custom action with the web account.


## -remarks

## -examples

## -see-also
[WebAccountAction](webaccountaction.md), [WebAccount](../windows.security.credentials/webaccount.md)