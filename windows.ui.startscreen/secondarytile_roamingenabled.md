---
-api-id: P:Windows.UI.StartScreen.SecondaryTile.RoamingEnabled
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public bool RoamingEnabled { get;  set; }
-->

# Windows.UI.StartScreen.SecondaryTile.RoamingEnabled

## -description
Gets or sets a value that determines whether the secondary tile will be reacquired through the cloud when the parent app is installed by the user, using their Microsoft account, on another computer. Note that as of Windows 8.1, roaming is the default behavior. This is the opposite of the default Windows 8 behavior, where roaming was opt-in.

> This property always returns **false** on Windows Phone 8.1.

## -property-value
Set to **true** if roaming is enabled; otherwise, **false**. The default is **true**. 

> Setting this value in a Windows Phone Store app has no effect, and this property always returns **false**.

## -remarks

## -examples

## -see-also
[Secondary tiles sample](http://go.microsoft.com/fwlink/p/?linkid=231487)