---
-api-id: M:Windows.System.AppUriHandlerRegistration.SetAppAddedHostsAsync(Windows.Foundation.Collections.IIterable{Windows.System.AppUriHandlerHost})
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public IAsyncAction AppUriHandlerRegistration.SetAppAddedHostsAsync(IIterable<AppUriHandlerHost> hosts)
-->

# Windows.System.AppUriHandlerRegistration.SetAppAddedHostsAsync

## -description
Registers hosts in addition to the hosts already defined in the AppxManifest.

## -parameters
### -param hosts
The set of [AppUriHandlerHost](appurihandlerhost.md) objects to register.

## -returns
Represents the asynchronous action.

## -remarks
This API does not override, replace, or remove entries that are registered via the AppxManifest.

## -see-also

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
