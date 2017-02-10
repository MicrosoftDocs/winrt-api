---
-api-id: M:Windows.Storage.ApplicationData.GetPublisherCacheFolder(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Storage.StorageFolder GetPublisherCacheFolder(System.String folderName)
-->

# Windows.Storage.ApplicationData.GetPublisherCacheFolder

## -description
Gets the specified subfolder of the shared storage folder for the publisher of the current app.

## -parameters
### -param folderName
The subfolder to get from the shared storage folder for the publisher of the current app.

## -returns
The specified subfolder.

## -remarks
The strong security model of Windows Runtime app typically prevents apps from sharing data among themselves. It can be useful, however, for apps from the same publisher to share files and settings on a per-user basis. As an app publisher, you can register your app to share a storage folder with other apps that you publish by adding extensions to the app manifest.

Here are some examples of how you can use this shared storage folder if you publish multiple apps.


+ **Share files.** For example, if multiple apps use the same images or the same custom fonts, you can save these files in the shared storage folder.
+ **Share the user's settings in a custom settings file.** For example, if multiple apps use temperatures, you can save a copy of the user's preference for Celsius or Fahrenheit in a custom settings file in the shared storage folder. We recommend that you also store the user's settings with each app or in another master location, however, since the user can clear the contents of the shared storage folder.
The shared storage folder for the app publisher is automatically provisioned when the user installs the first app from the publisher.

The shared storage folder has the following requirements and restrictions.


+ Data in the shared storage folder is not backed up or roamed. Also, the user can clear the contents of the shared storage folder.
+ You cannot use this feature to share data among apps from different publishers.
+ You cannot use this feature to share data among different users.
+ The shared storage folder does not have version management.
**To register an app to use the publisher's shared storage folder**

Manually enter XML similar to the following example in the app manifest to register subfolders. You don't have to create these subfolders. They are automatically provisioned for you.

```xml
<Package>
    …
    <Extensions>
        …
        <Extension Category=”windows.publisherCacheFolders”>
            <PublisherCacheFolder>
                <Folder Name="Folder1">
                <Folder Name="Folder2">
            </PublisherCacheFolder>
        </Extension>
        …
    </Extensions>
    …
</Package>

```

**To access data in the publisher's shared storage folder**

Call the [GetPublisherCacheFolder](applicationdata_getpublishercachefolder.md) method to get one of the registered subfolders from the shared storage folder.

Then use the properties and methods of the [StorageFolder](storagefolder.md) class to read and write files and subfolders in the shared folder.

Access to the shared storage folder has the following requirements and restrictions.


+ There is no default subfolder. You have to specify a subfolder when you call the [GetPublisherCacheFolder](applicationdata_getpublishercachefolder.md) method.
+ You can only access subfolders registered in the app manifest.
+ You can't access the root of the shared storage folder.
**To clean up the data in the publisher's shared storage folder**

Call the [ClearPublisherCacheFolderAsync](applicationdata_clearpublishercachefolderasync.md) method to clear the files and subfolders from the specified subfolder of the shared storage folder for the publisher of the current app.

The shared storage folder is automatically cleaned up when the last app from the publisher is uninstalled.

Data saved in the shared storage folder is not linked to the app that saved it. When you uninstall the app that saved the data, the data remains in the shared storage folder until the last app from the same publisher is uninstalled.

## -examples

## -see-also
[ClearPublisherCacheFolderAsync](applicationdata_clearpublishercachefolderasync.md)