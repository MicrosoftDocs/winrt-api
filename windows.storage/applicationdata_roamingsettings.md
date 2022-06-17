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
> Roaming data and settings is no longer supported as of Windows 11. The recommended replacement is [Azure App Service](/azure/app-service/). Azure App Service is widely supported, well documented, reliable, and supports cross-platform/cross-ecosystem scenarios such as iOS, Android and web. Settings stored here no longer roam (as of Windows 11), but the settings store is still available.
> 
> This documentation applies to Windows 10 versions 1909 and lower.

See [LocalSettings](applicationdata_localsettings.md) for remarks and examples on accessing RoamingSettings.

## -examples

## -see-also

[Store and retrieve settings and other app data](/windows/uwp/app-settings/store-and-retrieve-app-data)
