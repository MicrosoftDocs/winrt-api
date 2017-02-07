// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232509
(function () {
    "use strict";

    var app = WinJS.Application;

// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232509
(function () {
    "use strict";

    WinJS.Binding.optimizeBindingReferences = true;

    var app = WinJS.Application;
    var activation = Windows.ApplicationModel.Activation;

    app.onactivated = function (args) {
        if (args.detail.kind === activation.ActivationKind.launch) {
            if (args.detail.previousExecutionState !== activation.ApplicationExecutionState.terminated) {
                // TODO: This application has been newly launched. Initialize
                // your application here.
            } else {
                // TODO: This application has been reactivated from suspension.
                // Restore application state here.
            }
            args.setPromise(WinJS.UI.processAll());
        }
    };

    // <SnippetInitialize>
    app.onactivated = function (args) {
        if (args.detail.kind === Windows.ApplicationModel.Activation.ActivationKind.launch) {

            id("advertiseForPeersButton").addEventListener("click", advertiseForPeers);
            id("acceptButton").addEventListener("click", acceptConnection);
            id("findPeersButton").addEventListener("click", findPeers);
            id("stopFindingPeersButton").addEventListener("click", stopFindingPeers);
            displayNameTextBox.value = Windows.Networking.Proximity.PeerFinder.displayName;
            Windows.Networking.Proximity.PeerFinder.addEventListener("connectionrequested", connectionRequested);

            // Detect if app launched from a tap.
            if ((args.detail.kind === Windows.ApplicationModel.Activation.ActivationKind.launch) &&
                (args.detail.arguments === "Windows.Networking.Proximity.PeerFinder:StreamSocket")) {

                advertiseForPeers(true);
            }

            args.setPromise(WinJS.UI.processAll());
        }
    };

    function id(elementId) {
        return document.getElementById(elementId);
    }
    // </SnippetInitialize>

    // <SnippetFindPeers>
    var started = false;

    // Click event for "Advertise" button.
    function advertiseForPeers(launchedFromTap) {
        Windows.Networking.Proximity.PeerFinder.displayName = displayNameTextBox.Text;

        if (Windows.Networking.Proximity.PeerFinder.supportedDiscoveryTypes &
            Windows.Networking.Proximity.PeerDiscoveryTypes.triggered) {

            Windows.Networking.Proximity.PeerFinder.addEventListener(
                "triggeredconnectionstatechanged", triggeredConnectionStateChanged);

            id("messageDiv").innerHTML +=
                "You can tap to connect a peer device that is " +
                "also advertising for a connection.<br />";
        } else {
            id("messageDiv").innerHTML +=
		        "Tap to connect is not supported.<br />";
        }

        if (!launchedFromTap) {
            if (!(Windows.Networking.Proximity.PeerFinder.SupportedDiscoveryTypes &
                  Windows.Networking.Proximity.PeerDiscoveryTypes.Browse)) {
                id("messageDiv").innerHTML +=
                    "Peer discovery using Wi-Fi Direct is not supported.<br />";
            }
        }

        if (!started) {
            Windows.Networking.Proximity.PeerFinder.start();
            started = true;
        }
    }

    function triggeredConnectionStateChanged(e) {
        if (e.state === Windows.Networking.Proximity.TriggeredConnectState.peerFound) {
            id("messageDiv").innerHTML +=
                "Peer found. You may now pull your devices out of proximity.<br />";
        }
        if (e.state === Windows.Networking.Proximity.TriggeredConnectState.completed) {
            id("messageDiv").innerHTML += "Connected. You may now send a message.<br />";
            sendMessage(e.socket);
        }
    }


    // Click event for "Browse" button.
    function findPeers() {
        if (Windows.Networking.Proximity.PeerFinder.supportedDiscoveryTypes &
            Windows.Networking.Proximity.PeerDiscoveryTypes.browse) {

            Windows.Networking.Proximity.PeerFinder.findAllPeersAsync().done(
        function (peerInfoCollection) {
            if (peerInfoCollection.length > 0) {
                // Connect to first peer found - example only.
                // In your app, provide the user with a list of available peers.
                connectToPeer(peerInfoCollection[0]);
            }
        },
        function (err) {
            id("messageDiv").innerHTML += "Error finding peers: " + err + "<br />";
        });
        } else {
            id("messageDiv").innerHTML +=
		    "Peer discovery using Wi-Fi Direct is not supported.<br />";
        }
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

        requestingPeer = null;
    }

    function stopFindingPeers() {
        Windows.Networking.Proximity.PeerFinder.stop();
        started = false;
        if (proximitySocket != null) { closeSocket(); }
    }

    // Handle external connection requests.
    var requestingPeer;

    function connectionRequested(e) {
        id("messageDiv").innerHTML +=
            "Connection requested by " + e.peerInformation.DisplayName + ". " +
            "Click 'Accept Connection' to connect.";
        requestingPeer = e.PeerInformation;
    }

    function acceptConnection() {
        if (requestingPeer == null) {
            id("messageDiv").innerHTML += "No peer connection has been requested.";
            return;
        }

        connectToPeer(requestingPeer);
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
                    if (byteCount > 0) {
                        id("messageDiv").innerHTML += "Message sent: " + msg + "<br />";
                    } else {
                        id("messageDiv").innerHTML += "The remote peer closed the socket.";
                        closeSocket();
                    }
                },
                function (err) {
                    id("messageDiv").innerHTML += "Send error: " + err.message + "<br />";
                    closeSocket();
                });
        }
    }

    // Read out and print the message received from the socket.
    function startReader(socket, reader) {
        var initialLength = 4;
        reader.loadAsync(initialLength).done(
        function (byteCount) {
            if (byteCount > 0) {
                var msgLength = reader.readInt32();
                reader.loadAsync(msgLength).done(
                    function (byteCount) {
                        if (byteCount > 0) {
                            var message = reader.readString(msgLength);
                            id("messageDiv").innerHTML += "Received message: " + message + "<br />";

                            // After receiving a message, listen for the next message.
                            startReader(socket, reader);
                        }
                        else {
                            id("messageDiv").innerHTML += "The remote peer closed the socket.";
                            closeSocket();
                        }
                    },
                    function (err) {
                        id("messageDiv").innerHTML += "Receive error: " + err.message + "<br />";
                        reader.close();
                    });
            }
            else {
                id("messageDiv").innerHTML += "The remote peer closed the socket.";
                reader.close();
            }
        },
        function (err) {
            id("messageDiv").innerHTML += "Receive error: " + err.message + "<br />";
            reader.close();
        });
    }

    function closeSocket() {
        if (proximitySocket) {
            proximitySocket.close();
            proximitySocket = null;
        }

        if (dataWriter) {
            dataWriter.close();
            dataWriter = null;
        }
    }
    //</SnippetSendMessage>

    app.start();
})();


    app.start();
})();
