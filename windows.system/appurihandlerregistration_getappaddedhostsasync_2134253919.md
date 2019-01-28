---
-api-id: M:Windows.System.AppUriHandlerRegistration.GetAppAddedHostsAsync
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public IAsyncOperation<IVector<AppUriHandlerHost>> AppUriHandlerRegistration.GetAppAddedHostsAsync()
-->

# Windows.System.AppUriHandlerRegistration.GetAppAddedHostsAsync

## -description
Retrieves the set of hosts added by [SetAppAddedHostsAsync](appurihandlerregistration_setappaddedhostsasync_654710773.md) for the given registration.

## -returns
The set of hosts last added by [SetAppAddedHostsAsync](appurihandlerregistration_setappaddedhostsasync_654710773.md).

## -remarks
This set does not include hosts defined in the AppxManifest.

## -see-also
[SetAppAddedHostsAsync](appurihandlerregistration_setappaddedhostsasync_654710773.md)

## -examples
```csharp
// Application logic can determine which are the new domains to register 
// Here we just have a hardcoded list. 
List<AppUriHandlerHost> hosts = await registration.GetAppAddedHostsAsync(); 
 
// Application logic can determine which are the new domains to register 
hosts.AddRange(new[] { 
    new AppUriHandlerHost("www.contoso.com"), 
    new AppUriHandlerHost("*.example.contoso.com") 
    }); 
 
// Application logic can determine which domains to remove from the list 
hosts.RemoveAll(_ => _.Name == "removed.contoso.com"); 
 
await registration.SetAppAddedHostsAsync(hosts); 
```
