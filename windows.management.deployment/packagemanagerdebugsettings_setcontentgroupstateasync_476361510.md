---
-api-id: M:Windows.Management.Deployment.PackageManagerDebugSettings.SetContentGroupStateAsync(Windows.ApplicationModel.Package,System.String,Windows.ApplicationModel.PackageContentGroupState)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncAction PackageManagerDebugSettings.SetContentGroupStateAsync(Package package, String contentGroupName, PackageContentGroupState state)
-->

# Windows.Management.Deployment.PackageManagerDebugSettings.SetContentGroupStateAsync

## -description
Sets the install state of a content group for debugging.

## -params

## -param package
The streamable app package. 

## -param contentGroupName
The content group name. Case sensitive and must be unique.

## -param state
| State      | Description |
|------------|-------------|
| Staged     | The content group files have been downloaded and are ready to be accessed by the app. |
| NotStaged  | The content group files have not been downloaded and are not in queue. |  
| Queued     | The content group files have not been downloaded but are in queue. |
| Staging    | The content group files are currently being downloaded. | 

## -returns
Returns an IAsyncAction that completes when the content group is finished downloading.

## -remarks

## -see-also

## -examples

