---
-api-id: E:Windows.Security.Authentication.Web.Core.WebAccountMonitor.AccountPictureUpdated
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler AccountPictureUpdated<WebAccountMonitor, WebAccountEventArgs>
-->

# Windows.Security.Authentication.Web.Core.WebAccountMonitor.AccountPictureUpdated

## -description
Fires when a monitored [WebAccount's](../windows.security.credentials/webaccount.md) picture changes.

## -remarks
When a picture is updated, WAM will fire both the Updated and AccountPictureUpdated events so that users who were tracking picture updates by listening to Updated event wont regress. 
 
A new Boolean property “IsPictureUpdated” exists in the payload of the events that allows callers listening only to AccountUpdated events to differentiate between a picuture update and a normal account update. 

## -see-also
[Updated](webaccountmonitor_updated.md)

## -examples

