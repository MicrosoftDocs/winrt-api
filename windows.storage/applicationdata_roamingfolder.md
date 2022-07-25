---
-api-id: P:Windows.Storage.ApplicationData.RoamingFolder
-api-type: winrt property
---

<!-- Property syntax
public Windows.Storage.StorageFolder RoamingFolder { get; }
-->

# Windows.Storage.ApplicationData.RoamingFolder

## -description

Gets the root folder in the roaming app data store.

## -property-value

The file system folder that contains the files.

## -remarks

> [!WARNING]
> Roaming data and settings is no longer supported as of Windows 11. The recommended replacement is [Azure App Service](/azure/app-service/). Azure App Service is widely supported, well documented, reliable, and supports cross-platform/cross-ecosystem scenarios such as iOS, Android and web. Settings stored here no longer roam (as of Windows 11), but the settings store is still available.
> 
> This documentation applies to Windows 10 versions 1909 and lower.

The sync engine has restrictions on the file name conventions that you must follow to ensure the items in the roaming folder can roam. Be sure that your file and folder names do not contain leading whitespace. The sync engine may limit the total size of settings and files that can roam.

You can access files in the roaming app data store using the "ms-appdata:///roaming/" protocol. For example:

`<img src="ms-appdata:///roaming/myFile.png" alt="" />`

## -examples

## -see-also

[Store and retrieve settings and other app data](/windows/uwp/app-settings/store-and-retrieve-app-data)
