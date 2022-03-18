---
-api-id: T:Windows.Gaming.UI.GameMonitor
-api-type: winrt class
---

<!-- Class syntax.
public class GameMonitor 
-->

# Windows.Gaming.UI.GameMonitor

## -description

Allows an app to get the game monitor permission state of the device, and potentially prompt the user to enable game monitoring.

> [!IMPORTANT]
> As of Windows 10, version 1809 (10.0; Build 17763), this API is removed from the public API surface of Windows.

## -remarks

This class uses **TruePlay**, a system on Windows 10 that helps to combat cheating in PC games. As of Windows 10, version 1809 (10.0; Build 17763), TruePlay is removed from Windows. A game enrolled in TruePlay will run in a protected process, which mitigates a class of common attacks. The TruePlay APIs for UWP allow limited interaction between games and the game monitoring system on Windows 10 PCs.

You can use these WinRT APIs, in tandem with the native APIs in **&lt;gamemonitor.h&gt;**, to work with the game monitoring system. The documentation for TruePlay is no longer published.

## -see-also

[GameMonitoringPermission Enum](gamemonitoringpermission.md)

## -examples

The following example asks the customer for consent to enable game monitoring if it's not already enabled:

```cppcx
void DisplayGameMonitoringConsentUI() 
{ 
    auto gameMonitor = Windows::Gaming::UI::GameMonitor::GetDefault(); 

    if (gameMonitor != nullptr) 
    { 
        create_task(gameMonitor->RequestPermissionAsync())
            .then([this] (GameMonitoringPermission permissionState) 
            { 
                if (permissionState == GameMonitoringPermission::Allowed) 
                { 
                    // Continue with gaming experience. 
                } 
                else if (permissionState == GameMonitoringPermission::DeniedByUser
                    || permissionState == GameMonitoringPermission::DeniedBySystem) 
                { 
                    // Game has attempted mitigation. The game will likely exit. 
                }
            }); 
    } 
    else 
    { 
        // This is game-dependent - some games may proceed, others 
        // may require game monitoring for some scenarios, etc. 
    } 
} 
```
