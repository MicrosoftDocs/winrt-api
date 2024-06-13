---
-api-id: M:Windows.Devices.Enumeration.DeviceInformation.CreateFromIdAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.Enumeration.DeviceInformation> CreateFromIdAsync(System.String deviceId)
-->

# Windows.Devices.Enumeration.DeviceInformation.CreateFromIdAsync

## -description
Creates a [DeviceInformation](deviceinformation.md) object from a [DeviceInformation](deviceinformation.md) ID.

## -parameters
### -param deviceId
The device ID.

## -returns
An object for starting and managing the asynchronous creation of the [DeviceInformation](deviceinformation.md) object.

## -remarks

## -examples
The savedId variable in this example is a [DeviceInformation](deviceinformation.md) ID previously saved by the application, obtained from the [id](deviceinformation_id.md) property of the last-used [DeviceInformation](deviceinformation.md) object.

```javascript
    // Create a DeviceInformation object from a saved ID
    var Enum = Windows.Devices.Enumeration;
    var DevInf = Enum.DeviceInformation;
    DevInf.createFromIdAsync(savedId).then(
        function(devinfo) {
            // Use the created DeviceInformation object
            printMessage("Created DeviceInformation. Name: " + devinfo.name);
        },
        function (e) {
            displayError("Failed to create DeviceInformation: " + e.message);
        });

```

## -see-also
[CreateFromIdAsync(String, IIterable_1)](deviceinformation_createfromidasync_907774063.md)
