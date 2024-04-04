---
-api-id: M:Windows.Devices.Enumeration.DeviceInformation.CreateFromIdAsync(System.String,Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.Enumeration.DeviceInformation> CreateFromIdAsync(System.String deviceId, Windows.Foundation.Collections.IIterable<System.String> additionalProperties)
-->

# Windows.Devices.Enumeration.DeviceInformation.CreateFromIdAsync

## -description
Creates a [DeviceInformation](deviceinformation.md) object from a [DeviceInformation](deviceinformation.md) ID and a list of additional properties.

## -parameters
### -param deviceId
A string containing the [DeviceInformation](deviceinformation.md) ID.

### -param additionalProperties
An iterable list of additional properties to include in the [Properties](deviceinformation_properties.md) property of the [DeviceInformation](deviceinformation.md) objects in the enumeration results. For more info on what the properties represent, see [Device information properties](/windows/uwp/devices-sensors/device-information-properties).

## -returns
An object for starting and managing the asynchronous creation of the [DeviceInformation](deviceinformation.md) object.

## -remarks

## -examples
The following example builds a list of properties to include in the [DeviceInformation](deviceinformation.md) object to create from a [DeviceInformation](deviceinformation.md) ID.The savedId variable in this example is a [DeviceInformation](deviceinformation.md) ID previously saved by the application, obtained from the [id](deviceinformation_id.md) property of the last-used [DeviceInformation](deviceinformation.md) object.

```javascript
    // Create a set of two additional properties
    var propertiesToRetrieve = new Array();
    propertiesToRetrieve.push("System.InterfaceClassGuid");
    propertiesToRetrieve.push("System.Storage.IsPortable");

    // Create a DeviceInformation object from a saved ID
    var Enum = Windows.Devices.Enumeration;
    var DevInf = Enum.DeviceInformation;
    DevInf.createFromIdAsync(savedId, propertiesToRetrieve).then(
        function(devinfo) {
            // Use the created DeviceInformation object
            printMessage("Created DeviceInformation. Name: " + devinfo.name);
        },
        function (e) {
            displayError("Failed to create DeviceInformation: " + e.message);
        });
```

## -see-also
[CreateFromIdAsync(String)](deviceinformation_createfromidasync_728202765.md)
