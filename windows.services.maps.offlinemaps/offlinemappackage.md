---
-api-id: T:Windows.Services.Maps.OfflineMaps.OfflineMapPackage
-api-type: winrt class
---

<!-- Class syntax.
public class OfflineMapPackage
-->

# Windows.Services.Maps.OfflineMaps.OfflineMapPackage

## -description
Represents a map package for offline use.

## -remarks
Use this class to asynchronously find map packages that you are interested in using offline. You can check the status of packages to determine whether those packages exist on your local system. If they do not, you can asynchronously download them to your system.

## -see-also

## -examples
The following example finds a map package by using a geographical location. If the map package has not been previously downloaded to the local system, this code asynchronously downloads that map.

```csharp

private async Task getMapPackages()
{
    Geopoint myPoint = new Geopoint(new BasicGeoposition()
    {
        //Geopoint for Seattle
        Latitude = 47.604,
        Longitude = -122.329
    });

    var queryResult = await OfflineMapPackage.FindPackagesAsync(myPoint);

    if (queryResult.Status == OfflineMapPackageQueryStatus.Success)
    {
        foreach (OfflineMapPackage package in queryResult.Packages)
        {
            if (package.Status != OfflineMapPackageStatus.Downloaded)
            {
                var downloadRequestResult = await package.RequestStartDownloadAsync();

                if (downloadRequestResult.Status == OfflineMapPackageStartDownloadStatus.Success)
                {
                    // do something with the offline map package.
                }
            }
        }
    }
}

```
