---
-api-id: M:Windows.Phone.Management.Deployment.InstallationManager.FindPackagesForCurrentPublisher
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IIterable<Windows.ApplicationModel.Package> FindPackagesForCurrentPublisher()
-->

# Windows.Phone.Management.Deployment.InstallationManager.FindPackagesForCurrentPublisher

## -description
Returns all the app packages with the same publisher ID as the app calling this method.

## -returns
A list of app packages with the same publisher ID as the app calling this method.

## -remarks
This method returns all applications associated with the publisher ID of the calling app. This includes:
+ Apps preloaded on the phone.
+ Apps installed by the user.
+ Apps currently stored on the phone's SD card.
+ Enterprise apps.


## -examples
```csharp
using Windows.ApplicationModel;
using Windows.Phone.Management.Deployment;

void DisplayApplicationInfo(string ProductId)
{
         
    IEnumerable<Package> packages = InstallationManager.FindPackagesForCurrentPublisher();

    // Loop over all installed applications looking for the specified ProductId 
    // (not the most efficient way to search, but a simple way to show how to use   
    // the functionality. 
    foreach (Package package in packages)
    {
        if (package.Id.ProductId.ToString().ToLower()== ProductId.ToLower())
        {
            // Dislay the title info in the ApplicationTitle textlock.
            ApplicationTitle.Text = package.Id.Name;

            // Retrieve the icon image by getting its DSS Token.
            string token = package.GetThumbnailToken();

            // Do something with image token.
        
        }
    }
}
```

You can also use this method to see if other apps from your publisher ID are installed on a phone. If they’re installed, you can launch them. To demonstrate, the following example enumerates all apps for the current publisher ID and launches the first app in the enumeration (unless that app happens to be the current app).

```csharp
IEnumerable<Package> apps = Windows.Phone.Management.Deployment.InstallationManager.FindPackagesForCurrentPublisher();
apps.First().Launch(string.Empty);

```



## -see-also
