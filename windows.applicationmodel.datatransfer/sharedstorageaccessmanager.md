---
-api-id: T:Windows.ApplicationModel.DataTransfer.SharedStorageAccessManager
-api-type: winrt class
---

<!-- Class syntax.
public class SharedStorageAccessManager 
-->

# Windows.ApplicationModel.DataTransfer.SharedStorageAccessManager

## -description
Enables an app to share a file with another app by passing a token via Uri activation, app service, REST API, etc. The target app redeems the token to get the file shared by the source app.

## -remarks
Here is the sequence of steps that enables an app to share a file with another app by passing a token as part of a Uri activation, for example.


+ The source app calls the [AddFile](sharedstorageaccessmanager_addfile_731286892.md) method to get the sharing token that it passes to the target app, which it launches with a Uri.
+ The target app calls the [RedeemTokenForFileAsync](sharedstorageaccessmanager_redeemtokenforfileasync_2095026872.md) method to get the shared file.
+ Optionally, the source app can call the [RemoveFile](sharedstorageaccessmanager_removefile_245169084.md) method to revoke a token that it obtained previously by calling the [AddFile](sharedstorageaccessmanager_addfile_731286892.md) method.
For more info about Uri activation, see [Launch the default app for a URI](/windows/uwp/launch-resume/launch-default-app).

The use of the SharedStorageAccessManager class and of sharing tokens is subject to the following requirements and restrictions.


+ A sharing token can only be redeemed one time. After that, the token is no longer valid.
+ A sharing token expires after 14 days and is no longer valid.
+ The source app cannot get more than one thousand sharing tokens. After a token is redeemed, removed, or expires, however, it no longer counts against the quota of the source app.

Network files are not supported with this class.

## -examples
In the following example, a source app launches a mapping app and provides a .gpx file that contains driving directions to be displayed by the target app.

First, the source app gets a token for the .gpx file and uses protocol activation to launch the target app.

```csharp
public async void ShareMostRecentDirections()
{
       // Get the most recently opened .gpx file
       // from the recently used file list.
       StorageItemMostRecentlyUsedList mostRecent = 
           StorageApplicationPermissions.MostRecentlyUsedList;

       String mruToken = mostRecent.Entries.FirstOrDefault().Token;
       StorageFile file = await mostRecent.GetFileAsync(mruToken);

       // Get the token to share access to the updated .gpx file.
       String sharingToken = SharedStorageAccessManager.AddFile(file);

       //Launch the driving application .
       Uri driveTo = new Uri("nokia-drive-to:?Gpxfile=" + sharingToken);
       var launch = await Launcher.LaunchURIAsync(driveTo);
}

```

Next, the target app gets the .gpx file by providing the token received from the source app.

```csharp
protected override async void OnActivated(IActivatedEventArgs args)
{
    var protocolArgs = args as ProtocolActivatedEventArgs;

    // Get the token from the URI.
    var queryStrings = new WwwFormUrlDecoder(protocolArgs.Uri.Query);
    string gpxFileToken = queryStrings.GetFirstValueByName("GpxFile");

    // Get the .gpx file and call a custom method
    // to display driving directions.
    if (!string.IsNullOrEmpty(gpxFileToken))
    {
        PlotGpxFile(await
            SharedStorageAccessManager.RedeemTokenForFileAsync(gpxFileToken));
    }
}

```



## -see-also
