// <SnippetCreateWatcherAllDevicesJs>
    var watcher;
    var isEnumerationComplete = false;
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
        if (isEnumerationComplete) {
            output.innerHTML = ""; // clear output field
            printDeviceArray(document.getElementById("output"));
        }
        
    }

    function onUpdated(devUpdate) {
        document.getElementById("output").innerHTML += "<p>Device updated.</p>";
        for (var i = 0; i < deviceArray.length; i++) {
            if (deviceArray[i].id == devUpdate.id) {
                deviceArray[i].update(devUpdate);
            }
        }
        output.innerHTML = ""; // clear output field
        printDeviceArray(document.getElementById("output"));
    }

    function onRemoved(devupdate) {
        document.getElementById("output").innerHTML += "<p>Device removed.</p>";
        for (var i = 0; i < deviceArray.length; i++) {
            if (deviceArray[i].id == devupdate.id) {
                deviceArray[i].slice(devupdate);
            }
        }
        output.innerHTML = ""; // clear output field
        printDeviceArray(document.getElementById("output"));
    }

    function onEnumerationCompleted(obj) {
        isEnumerationComplete = true;
        document.getElementById("output").innerHTML += 
            "<p>Enumeration Completed.</p>";
        printDeviceArray(document.getElementById("output"));
    }

    function onStopped(obj) {
        document.getElementById("output").innerHTML += "<p>Stopped.</p>";
        if (watcher.status == Windows.Devices.Enumeration.DeviceWatcherStatus.aborted) {
           document.getElementById("output").innerHTML += 
            "<p>Enumeration stopped unexpectedly. </p>";
           document.getElementById("output").innerHTML += 
            "<p>Click the Watch button to restart enumeration.</p>";
        } else if (watcher.status == Windows.Devices.Enumeration.DeviceWatcherStatus.stopped) {
           document.getElementById("output").innerHTML += 
            "<p>You requested to stop enumeration. </p>";
           document.getElementById("output").innerHTML += 
            "<p>Click the Watch button to restart enumeration.</p>";
        }

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
        outputDestination.innerHTML += "<br />";
    }

    function printDeviceArray(outputDestination) {
        for (var i = 0; i < deviceArray.length; i++) {
            printDevice(deviceArray[i], outputDestination);
        }
    }
// </SnippetCreateWatcherAllDevicesJs>

