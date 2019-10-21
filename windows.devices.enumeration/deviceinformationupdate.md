---
-api-id: T:Windows.Devices.Enumeration.DeviceInformationUpdate
-api-type: winrt class
---

<!-- Class syntax.
public class DeviceInformationUpdate : Windows.Devices.Enumeration.IDeviceInformationUpdate, Windows.Devices.Enumeration.IDeviceInformationUpdate2
-->

# Windows.Devices.Enumeration.DeviceInformationUpdate

## -description
Contains updated properties for a [DeviceInformation](deviceinformation.md) object.

## -remarks
The [Updated](devicewatcher_updated.md) event receives a DeviceInformationUpdate, as shown in the example.

You can also instantiate a DeviceInformationUpdate object to pass to [Update](deviceinformation_update_1167410501.md).

## -examples
This example incrementally enumerates devices, adding them to a list each time a device is found, and also watching for updates. Once enumeration is complete, the app prints a list of devices. The app also prints a message if devices are added, updated, or removed after the initial enumeration completes.

```javascript

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
    <h2 >Input</h2>
    <div >            
            <div >
            <p>This example incrementally enumerates devices, adding them to a list each time a device is found, and also watching for updates.
               Once enumeration is complete, the list of devices is printed.</p> 
                <input type="button" value="Watch(All Devices)" onclick="WatchDevices()"/>
                <br/><br/>

                <input type="button" value="Stop" onclick="stopWatcher()"/>
                <br/><br/>
            </div>
    </div>

    <h2 > Output</h2>
            <div id="statusMessage"></div>
            <!--  Output -->
            <div  id="output"></div>
</body>
</html>
    var watcher;
    var deviceArray = new Array(); // Saves the enumeration results

    function WatchDevices() {
        try {
            output.innerHTML = ""; // clear output field

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

```



## -see-also
