---
-api-id: M:Windows.System.Profile.AnalyticsInfo.GetSystemPropertiesAsync(Windows.Foundation.Collections.IIterable{System.String}) 
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<IMapView<string, string>> AnalyticsInfo.GetSystemPropertiesAsync(IIterable<String> attributeNames)
-->

# Windows.System.Profile.AnalyticsInfo.GetSystemPropertiesAsync

## -description
Asynchronously retrieves the requested system attributes.

## -parameters
### -param attributeNames
An [IIterable](../windows.foundation.collections/iiterable_1.md) list of strings containing the system attributes to retrieve.

## -returns
Returns an [IAsyncOperation](../windows.foundation/iasyncoperation_1.md) object indicating that the task has completed and containing an [IMapView](../windows.foundation.collections/imapview_2.md) object with the requested attributes as Key/Value pairs.

## -remarks
Supported values for the *attributeNames* parameter are potentially endless. There are many providers that hook in and can expose arbitrary values. There a handful of known attributes that are likely to be supported. In most cases, these are case sensitive:  

* App  
* AppVer  
* DeviceFamily  
* FlightRing  
* OSVersionFull  

The intention of this method is to use this information only for analytics and not rely on a particular value on the client. Support for these values will change over time.

## -see-also

## -examples
``` Csharp
using Windows.System.Profile;

// ...
 
var attrNames = new List<string>({"DeviceFamily", "OSVersionFull", "FlightRing"});
var attrData = AnalyticsInfo.GetSystemPropertiesAsync(attrNames).AsTask().GetAwaiter().GetResult();

// The map can be serialized and sent to a backend service for analytics or targeting 
foreach (KeyValuePair<string, string> attr in attrData) 
{ 
    Console.WriteLine($"{attr.Key}={attr.Value}");
}
```
