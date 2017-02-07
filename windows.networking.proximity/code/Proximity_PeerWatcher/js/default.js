// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232509
(function () {
    "use strict";

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

    app.oncheckpoint = function (args) {
        // TODO: This application is about to be suspended. Save any state
        // that needs to persist across suspensions here. You might use the
        // WinJS.Application.sessionState object, which is automatically
        // saved and restored across suspension. If you need to complete an
        // asynchronous operation before your application is suspended, call
        // args.setPromise().
    };


    // <Snippet_StartPeerWatcher_JS>
    var _peerWatcher;
    var _peerWatcherIsRunning = false;
    var _peerFinderStarted = false;

    // The list of peers discovered by the PeerWatcher.
    var _discoveredPeers = new Array();

    function peerFinder_StartPeerWatcher() {
        if (!_peerFinderStarted) {
            // PeerFinder must be started first.
           return;
        }

        if (_peerWatcherIsRunning) {
            // PeerWatcher is already running.
            return;
        }

        try {
            if (!_peerWatcher)
            {
                _peerWatcher = PeerFinder.createWatcher();

                // Add PeerWatcher event handlers. Only add handlers once.
                peerWatcher.addEventListener("added", peerWatcher_Added); 
                peerWatcher.addEventListener("removed", peerWatcher_Removed); 
                peerWatcher.addEventListener("updated",  peerWatcher_Updated); 
                peerWatcher.addEventListener("enumerationcompleted", peerWatcher_EnumerationCompleted); 
                peerWatcher.addEventListener("stopped", peerWatcher_Stopped); 
            }

            // Empty the list of discovered peers.
            _discoveredPeers = new Array();

            // Start the PeerWatcher.
            _peerWatcher.start();

            _peerWatcherIsRunning = true;
        }
        catch (ex)
        {
            // Exceptions can occur if PeerWatcher.Start is called multiple times or
            // PeerWatcher.Start is called the PeerWatcher is stopping.
        }
    }
        
    function cleanup() {
        if (_peerWatcher) {
            // Remove event handlers.
            peerWatcher.removeEventListener("added", peerWatcher_Added); 
            peerWatcher.removeEventListener("removed", peerWatcher_Removed); 
            peerWatcher.removeEventListener("updated", peerWatcher_Updated); 
            peerWatcher.removeEventListener("enumerationCompleted", peerWatcher_EnumerationCompleted); 
            peerWatcher.removeEventListener("stopped", peerWatcher_Stopped); 

            _peerWatcher = null;
        }
    }
    // </Snippet_StartPeerWatcher_JS>

    // <Snippet_StopPeerWatcher_JS>
    function peerFinder_StopPeerWatcher() {
        try {
            _peerWatcher.Stop();
        }
        catch (ex) {
            // Handle the exception.
        }
    }
    // </Snippet_StopPeerWatcher_JS>

    // <Snippet_PeerWatcherAdded_JS>
    function peerWatcher_Added(peerInfo) {
        _discoveredPeers.Add(peerInfo);
    }
    // </Snippet_PeerWatcherAdded_JS>

    // <Snippet_PeerWatcherRemoved_JS>
    function peerWatcher_Removed(peerInfo)
    {
        // Find and remove the peer form the list of discovered peers.
        var match = null;
        var i;
        _discoveredPeers.forEach(function (e, i) { 
            if (e.id === peerInfo.id) { match = e; index = i; } 
        }); 
        if (match) { 
            _discoveredPeers.splice(index, 1); 
        } 
    }
    // </Snippet_PeerWatcherRemoved_JS>

    // <Snippet_PeerWatcherUpdated_JS>
    function peerWatcher_Updated(peerInfo)
    {
        // Find and update the peer in the list of discovered peers.
        var match = null;
        var i;
        _discoveredPeers.forEach(function (e, i) { 
            if (e.id === peerInfo.id) { match = e; index = i; } 
        }); 
        if (match) { 
            _discoveredPeers.setAt(index, peerInfo); 
        } 
    }
    // </Snippet_PeerWatcherUpdated_JS>

    // <Snippet_PeerWatcherEnumerationCompleted_JS>
    function peerWatcher_EnumerationCompleted()
    {
        if (_discoveredPeers.length == 0)
        {
            // No peers discovered for this enumeration.
        }
    }
    // </Snippet_PeerWatcherEnumerationCompleted_JS>

    // <Snippet_PeerWatcherStopped_JS>
    function peerWatcher_Stopped()
    {
        _peerWatcherIsRunning = false;

        // Update UI now that the PeerWatcher is stopped.
    }
    // </Snippet_PeerWatcherStopped_JS>


    app.start();
})();
