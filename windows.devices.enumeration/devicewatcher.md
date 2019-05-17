---
-api-id: T:Windows.Devices.Enumeration.DeviceWatcher
-api-type: winrt class
---

<!-- Class syntax.
public class DeviceWatcher : Windows.Devices.Enumeration.IDeviceWatcher, Windows.Devices.Enumeration.IDeviceWatcher2
-->

# Windows.Devices.Enumeration.DeviceWatcher

## -description
Enumerates devices dynamically, so that the app receives notifications if devices are added, removed, or changed after the initial enumeration is complete.

## -remarks
An app calls [Start](devicewatcher_start_1587696324.md) to begin the search for devices. During this initial enumeration, the DeviceWatcher raises an [Added](devicewatcher_added.md) event for each device that's found, until all devices are found. The DeviceWatcher raises an [EnumerationCompleted](devicewatcher_enumerationcompleted.md) event when the initial enumeration is complete, and continues to raise events if a device is added, updated, or removed.

The following diagram shows how the DeviceWatcher transitions between the states represented by [DeviceWatcherStatus](devicewatcherstatus.md) enumeration.

<img src="images/statediagram.png" alt="state diagram of DeviceWatcher states"></img>

The [Start](devicewatcher_start_1587696324.md) method can only be called when the DeviceWatcher is in the **Created**, **Stopped** or **Aborted** state. The [Status](devicewatcher_status.md) property indicates the DeviceWatcher state. When re-starting the watcher, wait for the [Stopped](devicewatcher_stopped.md) event before calling [Start](devicewatcher_start_1587696324.md).

[Stop](devicewatcher_stop_1201535524.md) transitions the DeviceWatcher to the **Stopping** state and completes immediately. The watcher will transition to the **Stopped** state once all events that are already in the process of being raised have completed.

Apps may wait for the [Stopped](devicewatcher_stopped.md) event if they need to know when the DeviceWatcher has stopped. Callers must wait for the [Stopped](devicewatcher_stopped.md) event before they can call [Start](devicewatcher_start_1587696324.md) to restart the watcher. Callers may unsubscribe from events if they do not want to receive any additional events after [Stop](devicewatcher_stop_1201535524.md) but do not want to wait for the [Stopped](devicewatcher_stopped.md) event.

> [!NOTE]
> An app must subscribe to all of the [added](devicewatcher_added.md), [removed](devicewatcher_removed.md), and [updated](devicewatcher_updated.md) events to be notified when there are device additions, removals or updates. If an app handles only the [added](devicewatcher_added.md) event, it will not receive an update if a device is added to the system after the initial device enumeration completes.

## -examples
For complete implementations in C#, C++, and JavaScript, see the [Device enumeration and pairing sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/DeviceEnumerationAndPairing).

This example incrementally enumerates devices, adding them to a list each time a device is found, and also handling removals and updates. The onAdded function that handles the [added](devicewatcher_added.md) event takes a [DeviceInformation](deviceinformation.md) object. Once enumeration is complete, the app prints a list of devices. The app also prints a message if devices are added, updated, or removed after the initial enumeration completes.

```html
<!DOCTYPE html>
<html>
<head>
    <title>Device Enumeration Sample</title>
    <script>
    var watcher;
    var deviceArray = new Array(); // Saves the enumeration results.

    function WatchDevices() {
        try {
            output.innerHTML = ""; // Clears output field.

            watcher = 
                Windows.Devices.Enumeration.DeviceInformation.createWatcher();
            // Add event handlers
            watcher.addEventListener("added", onAdded);
            watcher.addEventListener("removed", onRemoved);
            watcher.addEventListener("updated", onUpdated);
            watcher.addEventListener("enumerationcompleted", 
                onEnumerationCompleted);
            watcher.addEventListener("stopped", onStopped);
            // Start enumerating and listening for events
            watcher.start();
        } catch (e) {
            document.getElementById("statusMessage").innerHTML = 
                "Failed to create watcher, error: " + e.message;
        }
    }

    function stopWatcher() {
        try {
            watcher.stop();
        }
        catch (e) {
            document.getElementById("statusMessage").innerHTML = 
                "Failed to stop watcher: " + e.message;
        }
    }

    function onAdded(devinfo) {
        document.getElementById("output").innerHTML += "<p>Device added: " + 
            devinfo.name + "</p>";
        deviceArray.push(devinfo);
    }

    function onUpdated(devUpdate) {
        document.getElementById("output").innerHTML += "<p>Device updated.</p>";
        for (var i = 0; i < deviceArray.length; i++) {
            if (deviceArray[i].id == devUpdate.id) {
                deviceArray[i].update(devUpdate);
            }
        }
    }

    function onRemoved(devupdate) {
        document.getElementById("output").innerHTML += "<p>Device removed.</p>";
        for (var i = 0; i < deviceArray.length; i++) {
            if (deviceArray[i].id == devupdate.id) {
                deviceArray[i].slice(devupdate);
            }
        }
    }

    function onEnumerationCompleted(obj) {
        document.getElementById("output").innerHTML += 
            "<p>Enumeration Completed.</p>";
        printDeviceArray(document.getElementById("output"));
    }

    function onStopped(obj) {
        document.getElementById("output").innerHTML += "<p>Stopped.</p>";
    }


    // Prints the friendly name of the device interface, 
    // its ID (device interface path), and whether it is enabled.
    function printDevice(deviceInterface, outputDestination) {
        outputDestination.innerHTML += "<p>Name: " + 
            deviceInterface.name + "<p/>"; 
        outputDestination.innerHTML += "<p>Interface ID: " + 
            deviceInterface.id + "<p/>";    
        outputDestination.innerHTML += "<p>Enabled: " + 
            deviceInterface.isEnabled + "<p/>";
        outputDestination.innerHTML += "<br/>";
    }

    function printDeviceArray(outputDestination) {
        for (var i = 0; i < deviceArray.length; i++) {
            printDevice(deviceArray[i], outputDestination);
        }
    }

    </script>
</head>
<body role="application">
    <h1>Device Enumeration Sample</h1>
    <h2>Input</h2>
    <div>            
        <div>
        <p>This example incrementally enumerates devices, adding them to a list each time a device is found, and also watching for
            updates. After enumeration is complete, the list of devices is printed.</p> 
            <input type="button" value="Watch(All Devices)" onclick="WatchDevices()"/>
            <br/><br/>

            <input type="button" value="Stop" onclick="stopWatcher()"/>
            <br/><br/>
        </div>
    </div>

    <h2>Output</h2>
        <div id="statusMessage"></div>
        <!--  Output -->
        <div  id="output"></div>
</body>
</html>
```

## -see-also
[Device enumeration and pairing sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/DeviceEnumerationAndPairing)
