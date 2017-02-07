// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232509
(function () {
    "use strict";

    var app = WinJS.Application;

    // This function responds to all application activations.
    app.onactivated = function (eventObject) {
        if (eventObject.detail.kind === Windows.ApplicationModel.Activation.ActivationKind.launch) {
            // TODO: Initialize your application here.
            WinJS.UI.processAll();
        }
    };


    var storageItems = new Array();
    var picker = new Windows.Storage.Pickers.FileOpenPicker();
    picker.fileTypeFilter.replaceAll([".jpg", ".bmp", ".gif", ".png", ".wmv"]);
    picker.pickMultipleFilesAsync().then(function (files) {
        storageItems = files;
        shareStorageItems(files);
    });

    //<SnippetHowToShareStorageItems_JS>
    //<SnippetHowToShareStorageItems>
    function registerForShare() {
        var dataTransferManager = Windows.ApplicationModel.DataTransfer.DataTransferManager.getForCurrentView();
        dataTransferManager.addEventListener("datarequested", shareStorageItemsHandler);
    }

    function shareStorageItemsHandler(e) {
        var request = e.request;
        request.data.properties.title = "Share StorageItems Example";
        request.data.properties.description = "A demonstration that shows how to share.";
        var deferral = request.getDeferral();
        Windows.ApplicationModel.Package.current.installedLocation.getFileAsync("images\\logo.png").done(function (logoFile) {
            //<SnippetSetStorageItems_JS>
            //<SnippetSetStorageItems>
            request.data.setStorageItems([logoFile]);
            //</SnippetSetStorageItems>
            //</SnippetSetStorageItems_JS>
            deferral.complete();
        }, function (err) {
            request.failWithDisplayText(err);
        });
    }
    //</SnippetHowToShareStorageItems>
    //</SnippetHowToShareStorageItems_JS>



    app.start();
})();
