// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232509
(function () {
    "use strict";


    var app = WinJS.Application;

    app.onactivated = function (eventObject) {
        if (eventObject.detail.kind === Windows.ApplicationModel.Activation.ActivationKind.launch) {
            
            //initializeProximityDevice();
            initializeUI();

            WinJS.UI.processAll();
        }
    };

    function exclude0() {
    // <SnippetArriveDepart>
    function id(elementId) {
        return document.getElementById(elementId);
    }

    var proximityDevice;

    function initializeProximityDevice() {
        proximityDevice = Windows.Networking.Proximity.ProximityDevice.getDefault();

        if (proximityDevice) {
            proximityDevice.addEventListener("devicearrived", proximityDeviceArrived);
            proximityDevice.addEventListener("devicedeparted", proximityDeviceDeparted);

            id("messageDiv").innerHTML += "Proximity device initialized.<br />";
        }
        else {
            id("messageDiv").innerHTML += "Failed to initialized proximity device.<br />";
        }
    }

    function proximityDeviceArrived(device) {
        id("messageDiv").innerHTML += "Proximate device arrived. id = " + device.deviceId + "<br />";
    }

    function proximityDeviceDeparted(device) {
        id("messageDiv").innerHTML += "Proximate device departed. id = " + device.deviceId + "<br />";
    }
    // </SnippetArriveDepart>
    }


    function initializeUI() {
        id("startFindingPeersButton").addEventListener("click", startFindingPeers);
        id("stopFindingPeersButton").addEventListener("click", stopFindingPeers);
    }
    // <SnippetConnect>
    function id(elementId) {
        return document.getElementById(elementId);
    }
    
    // Click event for "Start" button.
    function startFindingPeers() {
        if (Windows.Networking.Proximity.PeerFinder.supportedDiscoveryTypes &
            Windows.Networking.Proximity.PeerDiscoveryTypes.triggered) {

            Windows.Networking.Proximity.PeerFinder.start();

            Windows.Networking.Proximity.PeerFinder.addEventListener(
		"triggeredconnectionstatechanged", triggeredConnectionStateChanged);

            id("messageDiv").innerHTML += 
		"Waiting for peers. Enter proximity to connect. " +
		"Call PeerFinder.start() on the peer to send and receive messages.<br />";
        }
        else {
            id("messageDiv").innerHTML += 
		"Peer discovery using tapping is not supported.<br />";
        }

    }

    function triggeredConnectionStateChanged(e) {
        if (e.state === Windows.Networking.Proximity.TriggeredConnectState.completed) {
            id("messageDiv").innerHTML += "Connected. You may now send a message.<br />";
            sendMessage(e.socket);
        }
    }

    var proximitySocket;
    var dataWriter;

    // Reference socket streams for writing and reading messages.
    function sendMessage(socket) {
        id("sendMessageButton").addEventListener("click", sendMessageText);

        // Get the network socket from the proximity connection.
        proximitySocket = socket;

        // Create DataWriter for writing messages to peers.
        dataWriter = new Windows.Storage.Streams.DataWriter(proximitySocket.outputStream);
                
        // Listen for messages from peers.
        var dataReader = new Windows.Storage.Streams.DataReader(proximitySocket.inputStream);
        startReader(proximitySocket, dataReader);
    }

    // Send a message to the socket.
    function sendMessageText() {        
        var msg = id("sendMessageText").value;
        
        if (msg.length > 0) {
            var msgLength = dataWriter.measureString(msg);
            dataWriter.writeInt32(msgLength);
            dataWriter.writeString(msg);
            dataWriter.storeAsync().done(
                function (byteCount) {
                    id("messageDiv").innerHTML += "Message sent: " + msg.value + "<br />";
                },
                function (err) {
                    id("messageDiv").innerHTML += "Send error: " + err.message + "<br />";
                });
        }
    }

    // Read out and print the message received from the socket.
    function startReader(socket, reader) {
        var initialLength = 4; 
        reader.loadAsync(initialLength).done(
        function () {
            var msgLength = reader.readInt32();
            reader.loadAsync(msgLength).done(
                function () {
                    var message = reader.readString(msgLength);
                    id("messageDiv").innerHTML += "Received message: " + message + "<br />";

                    // After receiving a message, listen for the next message.
                    startReader(socket, reader);
                },
                function (err) {
                    id("messageDiv").innerHTML += "Error: " + err.message + "<br />";
                    socket.close();
                });
        },
        function (err) {
            id("messageDiv").innerHTML += "Error: " + err.message + "<br />";
            socket.close();
        });
    }
    // </SnippetConnect>

    function exclude1() {
        // <SnippetPublishSubscribe>
        function id(elementId) {
            return document.getElementById(elementId);
        }

        var proximityDevice;
        var publishedMessageId = -1;
        var subscribedMessageId = -1;

        function initializeProximityDevice() {
            proximityDevice = Windows.Networking.Proximity.ProximityDevice.getDefault();

            if (proximityDevice) {
                id("publishMessageButton").addEventListener("click", publishMessage);
                id("subscribeForMessageButton").addEventListener("click", subscribeForMessage);
		id("stopSubscribingForMessageButton").addEventListener("click", 
		    stopSubScribingForMessage);
		id("stopPublishingMessageButton").addEventListener("click", 
		    stopPublishingMessage);
            }
            else {
                id("messageDiv").innerHTML += "Failed to initialized proximity device.<br />";
            }
        }

        function publishMessage() {
            // Stop publishing the current message.
            if (publishedMessageId != -1) {
                proximityDevice.stopPublishingMessage(publishedMessageId);
            }

            publishedMessageId = 
		proximityDevice.publishMessage("Windows.SampleMessage", id("messageText").value);
        }

        function subscribeForMessage() {
            // Only subscribe for the message one time.
            if (subscribedMessageId === -1) {
                subscribedMessageId = 
		    proximityDevice.subscribeForMessage("Windows.SampleMessage", messageReceived);
            }
        }

        function messageReceived(device, message) {
            id("messageDiv").innerHTML += "Message received: " + message.dataAsString + "<br />";
        }

	function stopSubscribingForMessage() {
	    proximityDevice.stopSubscribingForMessage(subscribedMessageId);
            subscribedMessageId = -1;
	}

	function stopPublishingMessage() {
	    proximityDevice.stopPublishingMessage(publishedMessageId);
            publishedMessageId = -1;
	}
        // </SnippetPublishSubscribe>
    }

    function exclude5() {
        // <SnippetPublishSubscribe2>
        function id(elementId) {
            return document.getElementById(elementId);
        }

        var proximityDevice;
        var publishedMessageId = -1;
        var subscribedMessageId = -1;

        function initializeProximityDevice() {
            proximityDevice = Windows.Networking.Proximity.ProximityDevice.getDefault();

            if (proximityDevice) {
                id("publishMessageButton").addEventListener("click", publishMessage);
                id("subscribeForMessageButton").addEventListener("click", subscribeForMessage);
		id("stopSubscribingForMessageButton").addEventListener("click", 
		    stopSubScribingForMessage);
		id("stopPublishingMessageButton").addEventListener("click", 
		    stopPublishingMessage);
            }
            else {
                id("messageDiv").innerHTML += "Failed to initialized proximity device.<br />";
            }
        }

        function publishMessage() {
            // Stop publishing the current message.
            if (publishedMessageId != -1) {
                proximityDevice.stopPublishingMessage(publishedMessageId);
            }

            publishedMessageId = 
		proximityDevice.publishMessage("Windows.SampleMessage", id("messageText").value,
                                               messagePublished);
        }

	function messagePublished(sender, messageId) {
	    // The message has been successfully published.
        }

        function subscribeForMessage() {
            // Only subscribe for the message one time.
            if (subscribedMessageId === -1) {
                subscribedMessageId = 
		    proximityDevice.subscribeForMessage("Windows.SampleMessage", messageReceived);
            }
        }

        function messageReceived(device, message) {
            id("messageDiv").innerHTML += "Message received: " + message.dataAsString + "<br />";
        }

	function stopSubscribingForMessage() {
	    proximityDevice.stopSubscribingForMessage(subscribedMessageId);
            subscribedMessageId = -1;
	}

	function stopPublishingMessage() {
	    proximityDevice.stopPublishingMessage(publishedMessageId);
            publishedMessageId = -1;
	}
        // </SnippetPublishSubscribe2>
    }


   function exclude() {


        // Need wifi to test

        var g_sendSocket;

        function initializeUI() {
            id("startFindingPeersButton").addEventListener("click", startFindingPeers);
            id("stopFindingPeersButton").addEventListener("click", stopFindingPeers);
        }

        // <SnippetFindPeers>           
        function startFindingPeers() {
            if (Windows.Networking.Proximity.PeerFinder.supportedDiscoveryTypes &
                Windows.Networking.Proximity.PeerDiscoveryTypes.browse) {

                Windows.Networking.Proximity.PeerFinder.findAllPeersAsync().done(
                    function (peerInfoCollection) {
                        id("messageDiv").innerHTML += 
                            "Found " + peerInfoCollection.size + " peers.<br />";

                        if (peerInfoCollection.size < 1) { return; }

                        for (var i = 0; i < peerInfoCollection.size; i++) {
                            id("messageDiv").innerHTML += 
                                "Peer: " + peerInfoCollection[i].displayName + "<br />";
                        }
                        
                        // Connect to the first peer found.
                        id("messageDiv").innerHTML += 
                            "Connecting to " + peerInfoCollection[0].displayName + "<br />";
                        Windows.Networking.Proximity.PeerFinder.connectAsync(
			    peerInfoCollection[0]).done(
                                function (socket) {
                                    sendMessage(socket);
                                });
                    });
            }
        }

        var proximitySocket;
        var dataWriter;

        // Reference socket streams for writing and reading messages.
        function sendMessage(socket) {
            id("sendMessageButton").addEventListener("click", sendMessageText);

            // Get the network socket from the proximity connection.
            proximitySocket = socket;

            // Create DataWriter for writing messages to peers.
            dataWriter = 
                new Windows.Storage.Streams.DataWriter(proximitySocket.outputStream);

            // Listen for messages from peers.
            var dataReader = 
                new Windows.Storage.Streams.DataReader(proximitySocket.inputStream);
            startReader(proximitySocket, dataReader);
        }

        // Send a message to the socket.
        function sendMessageText() {
            var msg = id("sendMessageText").value;

            if (msg.length > 0) {
                var msgLength = dataWriter.measureString(msg);
                dataWriter.writeInt32(msgLength);
                dataWriter.writeString(msg);
                dataWriter.storeAsync().done(
                function (byteCount) {
                    id("messageDiv").innerHTML += 
                        "Message sent: " + msg.value + "<br />";
                },
                function (err) {
                    id("messageDiv").innerHTML += 
                        "Send error: " + err.message + "<br />";
                });
            }
        }

        // Read out and print the message received from the socket.
        function startReader(socket, reader) {
            var initialLength = 4;
            reader.loadAsync(initialLength).done(
            function () {
                var msgLength = reader.readInt32();
                reader.loadAsync(msgLength).done(
                    function () {
                        var message = reader.readString(msgLength);
                        id("messageDiv").innerHTML += "Received message: " + message + "<br />";

                        // After receiving a message, listen for the next message.
                        startReader(socket, reader);
                    },
                    function (err) {
                        id("messageDiv").innerHTML += "Error: " + err.message + "<br />";
                        socket.close();
                    });
            },
            function (err) {
                id("messageDiv").innerHTML += "Error: " + err.message + "<br />";
                socket.close();
            });
        }
        // </SnippetFindPeers>

        function stopFindingPeers() {
            Windows.Networking.Proximity.PeerFinder.stop();
            if (g_sendSocket) { g_sendSocket.close(); }
        }

        // <SnippetConnectionRequested>
        Windows.Networking.Proximity.PeerFinder.onconnectionrequested = connectionRequested;

        function connectionRequested(e) {
            id("messageDiv").innerHTML += 
		"Connection Requested from peer: " + e.peerInformation.displayName;
        }
        // </SnippetConnectionRequested>

    }

    app.start();
})();
