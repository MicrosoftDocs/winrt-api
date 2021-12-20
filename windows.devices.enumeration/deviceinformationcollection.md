---
-api-id: T:Windows.Devices.Enumeration.DeviceInformationCollection
-api-type: winrt class
---

<!-- Class syntax.
public class DeviceInformationCollection : Windows.Foundation.Collections.IIterable<Windows.Devices.Enumeration.DeviceInformation>, Windows.Foundation.Collections.IVectorView<Windows.Devices.Enumeration.DeviceInformation>
-->

# Windows.Devices.Enumeration.DeviceInformationCollection

## -description
Represents a collection of [DeviceInformation](deviceinformation.md) objects.

## -remarks
Successful completion of [FindAllAsync](deviceinformation_findallasync_1257462890.md) results in a DeviceInformationCollection containing [DeviceInformation](deviceinformation.md) objects.

### Collection member lists

For JavaScript, DeviceInformationCollection has the members shown in the member lists. In addition, DeviceInformationCollection supports a **length** property, members of **Array.prototype**, and using an index to access items.


<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

DeviceInformationCollection is enumerable, so you can use language-specific syntax such as **foreach** in C# to enumerate the items in the collection. The compiler does the type-casting for you and you won't need to cast to `IEnumerable<DeviceInformation>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](/dotnet/api/system.collections.ienumerable.getenumerator?view=dotnet-uwp-10.0&preserve-view=true), cast to [IEnumerable&lt;T&gt;](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true) with a [DeviceInformation](deviceinformation.md) constraint.


<!--End NET note for IEnumerable support-->

## -examples
```javascript

var DeviceInformation = Enumeration.DeviceInformation;
DeviceInformation.findAllAsync(deviceClass).then(
    successCallback, 
    errorCallback
);

// Handles successful completion of the findAllAsync method.
function successCallback(deviceInformationCollection) {
    var numDevices = deviceInformationCollection.length;
    document.getElementById("statusMessage").innerHTML = 
        numDevices + " device interface(s) found";
    if (numDevices) {
        for (var i = 0; i < numDevices; i++) {
            printFriendlyNameAndID(deviceInformationCollection[i], 
                document.getElementById("Output"));
        }
    } else {
        document.getElementById("statusMessage").innerHTML = "No devices found";
    }
}

// Handles an error completion of the findAllAsync method.
function errorCallback(e) {
    document.getElementById("statusMessage").innerHTML = 
        "Failed to find devices, error: " + e.message;
}

```



## -see-also
