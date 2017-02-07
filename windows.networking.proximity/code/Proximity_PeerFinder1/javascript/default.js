// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232509
(function () {
    "use strict";

    var app = WinJS.Application;

    // <SnippetInitialize>
    // This function responds to all application activations.
    app.onactivated = function (eventObject) {
        if (eventObject.detail.kind === Windows.ApplicationModel.Activation.ActivationKind.launch) {

            id("tapToConnectButton").addEventListener("click", tapToConnect);
            id("startFindingPeersButton").addEventListener("click", startFindingPeers);
            id("stopFindingPeersButton").addEventListener("click", stopFindingPeers);

            WinJS.UI.processAll();
        }
    };

    function id(elementId) {
        return document.getElementById(elementId);
    }
    // </SnippetInitialize>

    // <SnippetFindPeers>
    // Click event for "Tap" button.
    function tapToConnect() {
        if (Windows.Networking.Proximity.PeerFinder.supportedDiscoveryTypes &
            Windows.Networking.Proximity.PeerDiscoveryTypes.triggered) {

                Windows.Networking.Proximity.PeerFinder.start();

                Windows.Networking.Proximity.PeerFinder.addEventListener(
		            "triggeredconnectionstatechanged", triggeredConnectionStateChanged);

                id("messageDiv").innerHTML +=
		            "Click 'Click Here to Tap to Connect' on the peer device " +
                    "and enter proximity to connect.<br />";
            }
        else {
            id("messageDiv").innerHTML +=
		        "Tap to connect is not supported.<br />";
        }
    }

    function triggeredConnectionStateChanged(e) {
        if (e.state === Windows.Networking.Proximity.TriggeredConnectState.peerFound) {
            id("messageDiv").innerHTML += "Peer found. You may now exit proximity.<br />";
        }
        if (e.state === Windows.Networking.Proximity.TriggeredConnectState.completed) {
            id("messageDiv").innerHTML += "Connected. You may now send a message.<br />";
            sendMessage(e.socket);
        }
    }


    // Click event for "Start" button.
    function startFindingPeers() {
        if (Windows.Networking.Proximity.PeerFinder.supportedDiscoveryTypes &
            Windows.Networking.Proximity.PeerDiscoveryTypes.browse) {

                Windows.Networking.Proximity.PeerFinder.start();
                findPeers();
            }
        else {
            id("messageDiv").innerHTML +=
		        "Peer discovery using Wi-Fi Direct is not supported.<br />";
        }
    }

    // Click event for "Stop" button.
    function stopFindingPeers() {
        Windows.Networking.Proximity.PeerFinder.stop();
        proximitySocket.close();
    }

    function findPeers() {
        Windows.Networking.Proximity.PeerFinder.findAllPeersAsync().done(
            function (peerInfoCollection) {
                if (peerInfoCollection.length > 0) {
                    // Connect to first peer found.
                    connectToPeer(peerInfoCollection[0]);
                }
            },
            function (err) {
                id("messageDiv").innerHTML += "Error finding peers: " + err + "<br />";
            });
    }

    function connectToPeer(peerInfo) {
        id("messageDiv").innerHTML += ("Peer found. Connecting to " + peerInfo.displayName + "<br />");
        Windows.Networking.Proximity.PeerFinder.connectAsync(peerInfo).done(
            function (socket) {
                id("messageDiv").innerHTML += "Connection successful. You may now send messages.<br />";
                sendMessage(socket);
            },
            function (err) {
                id("messageDiv").innerHTML += "Connection failed: " + err + "<br />";
            });
    }
    // </SnippetFindPeers>

    // <SnippetSendMessage>
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
                    id("messageDiv").innerHTML += "Message sent: " + msg + "<br />";
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
        });
    }
    //</SnippetSendMessage>

    app.start();
})();
