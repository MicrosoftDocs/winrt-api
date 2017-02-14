---
-api-id: P:Windows.System.Profile.SharedModeSettings.IsEnabled
-api-type: winrt property
---

<!-- Property syntax
public bool IsEnabled { get; }
-->

# Windows.System.Profile.SharedModeSettings.IsEnabled

## -description
Gets a Boolean value that indicates if shared mode is currently enabled.

## -property-value
A Boolean value that indicates if shared mode is currently enabled.

## -remarks
 - Returns **true** when the [EnableSharedPCMode](https://msdn.microsoft.com/en-us/windows/hardware/commercialize/customize/mdm/sharedpc-csp) policy is set.  
 -	Returns **true** when running on a Surface Hub.  
 -	Means the PC is running in scenarios where multiple consecutive users use the PC. For more info on when this is used on Desktop, see [Set up a shared or guest PC with Windows 10](https://technet.microsoft.com/en-us/itpro/windows/manage/set-up-shared-or-guest-pc).

## -examples

## -see-also
