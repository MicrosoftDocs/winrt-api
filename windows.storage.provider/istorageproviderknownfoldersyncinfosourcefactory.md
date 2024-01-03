---
-api-id: T:Windows.Storage.Provider.IStorageProviderKnownFolderSyncInfoSourceFactory
-api-type: winrt interface
---

# Windows.Storage.Provider.IStorageProviderKnownFolderSyncInfoSourceFactory

<!--
public interface IStorageProviderKnownFolderSyncInfoSourceFactory
-->

## -description

The interface that a cloud provider implements to provide instances of [IStorageProviderKnownFolderSyncInfoSource](istorageproviderknownfoldersyncinfosource.md) to File Explorer.

## -remarks

Cloud providers implement this interface and register it as an extension in the app manifest. A new manifest element will be added to the package manifest schema under the `CloudFiles` extension element. You can use this element in the `CloudFiles` namespace:

```xml
<Package
    xmlns:desktop3="http://schemas.microsoft.com/appx/manifest/desktop/windows10/3"
    xmlns:cloudfiles="http://schemas.microsoft.com/appx/manifest/cloudfiles/windows10"
    xmlns:cloudfiles3="http://schemas.microsoft.com/appx/manifest/cloudfiles/windows10/3"
>

<Applications>
    <Application>
        <Extensions>
            <desktop3:Extension>
            <desktop3:CloudFiles>
            <cloudfiles3: StorageProviderKnownFolderSyncInfoSourceFactory >
...
</Applications>
```

Alternatively, for non-packaged Win32 apps, registration of this class can be done directly in the registry by setting the CLSID of the implementation class as the value of the following registry key:

```
HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\StorageProvider
```

This is consistent with the existing mechanism for unpackaged provider registration. This registration allows a storage provider to offer the entry point before a cloud user account is added. When installed globally, cloud providers should register the factory in each user's profile.

## -see-also

[IStorageProviderKnownFolderSyncInfoSource](istorageproviderknownfoldersyncinfosource.md)

## -examples
