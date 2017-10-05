---
-api-id: T:Windows.Gaming.UI.GameMonitor
-api-type: winrt class
---

<!-- Class syntax.
public class GameMonitor 
-->

# Windows.Gaming.UI.GameMonitor

## -description

Allows an app to get the game monitor permission state of the device and potentially prompt the user to enable game monitoring.

## -remarks

## -see-also

## -examples

The following example asks the customer for consent to enable game monitoring if it's not already enabled:

```cpp
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
        // This is game dependent - some games may proceed, others 
        // may require game monitoring for some scenarios, etc. 
    } 
} 
```