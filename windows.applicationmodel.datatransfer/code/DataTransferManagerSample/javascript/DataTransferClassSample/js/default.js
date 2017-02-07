/* The following code is intended to provide snippets for DataTransferManager class. */
/*Test comment*/

(function () {
    'use strict';
    // Uncomment the following line to enable first chance exceptions.
    // Debug.enableFirstChanceException(true);

    WinJS.Application.onmainwindowactivated = function (e) {
        if (e.detail.kind === Windows.ApplicationModel.Activation.ActivationKind.launch) {
            setupShare();
            captureTargetAppChosen();
            launchShare();
        }
    }

    /* The following snippet demonstrates the basic functionality of the DataTransferManager class.
    It is intended to be used with the DataTransferManager class reference topic. */

// <SnippetDataTransferManager_1>
    function setupShare() {
        var dataTransferManager = Windows.ApplicationModel.DataTransfer.DataTransferManager.getForCurrentView();
        dataTransferManager.addEventListener("datarequested", function (e) {
            var request = e.request;
            request.data.properties.title = "Share Demonstration";
            request.data.setText("Hello World!");
        });
    }
    // </SnippetDataTransferManager_1>

    /* The following snippet shows the use of the targetapplicationchosen event. */

    // <SnippetDataTransferManager_2>

    function captureTargetAppChosen() {
        var dataTransferManager = Windows.ApplicationModel.DataTransfer.DataTransferManager.getForCurrentView();
        dataTransferManager.addEventListener("targetapplicationchosen", function (e) {
            var appName = e.applicationName;
            document.write(appName);
        });
    }
    // </SnippetDataTransferManager_2>

    /* The following snippet shows how to launch the share UI programmatically. */

    // <SnippetDataTransferManager_3>
    function launchShare() {
        var shareButton = document.createElement("button");
        shareButton.setAttribute("id", "showShareButton");
        shareButton.innerText = "Click to share!";
        shareButton.addEventListener("click", function () {
            Windows.ApplicationModel.DataTransfer.DataTransferManager.showShareUI();
        });
        document.body.appendChild(shareButton);
    }
    // </SnippetDataTransferManager_3>
    WinJS.Application.start();
})();