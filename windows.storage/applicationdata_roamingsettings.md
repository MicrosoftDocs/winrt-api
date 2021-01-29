---
-api-id: P:Windows.Storage.ApplicationData.RoamingSettings
-api-type: winrt property
---

<!-- Property syntax
public Windows.Storage.ApplicationDataContainer RoamingSettings { get; }
-->

# Windows.Storage.ApplicationData.RoamingSettings

## -description
Gets the application settings container in the roaming app data store.

## -property-value
The application settings container.

## -remarks

> [!WARNING]
> As of Windows 10, version 1909, it was [announced](/windows/deployment/planning/windows-10-deprecated-features) that Package State Roaming (PSR) will be removed in a future update. PSR allows non-Microsoft developers to access roaming data on devices, enabling developers of UWP applications to write data to Windows and synchronize it to other instantiations of Windows for that user.
> 
>The recommended replacement for PSR is [Azure App Service](/azure/app-service/). Azure App Service is widely supported, well documented, reliable, and supports cross-platform/cross-ecosystem scenarios such as iOS, Android and web.

See [LocalSettings](applicationdata_localsettings.md) for remarks and examples on accessing RoamingSettings.

## -examples

## -see-also

[Store and retrieve settings and other app data](/windows/uwp/app-settings/store-and-retrieve-app-data)
