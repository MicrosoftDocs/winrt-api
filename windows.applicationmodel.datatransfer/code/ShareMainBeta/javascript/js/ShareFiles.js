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
            shareFiles();
        }
    };
    //<SnippetHowToShareFiles_JS>
    //<SnippetHowToShareFiles>
    var imageFile;
    var picker = new Windows.Storage.Pickers.FileOpenPicker();
    picker.fileTypeFilter.replaceAll([".jpg", ".bmp", ".gif", ".png", ".wmv"]);
    picker.pickSingleFileAsync().then(function (file) {
        logText("PickImage: Picker returned a file");
        imageFile = file;
    });

    //<SnippetShareFileFunction_JS>
    //<SnippetShareFileFunction>
    function onDeferredImageRequested(request) {
        try {
            if (imageFile) {
                // This is to make sure deferral works even in synchronous case
                var deferral = request.getDeferral();
                var imageStreamRef = Windows.Storage.Streams.RandomAccessStreamReference.createFromFile(imageFile);
                request.setData(imageStreamRef);
                deferral.complete();
            }
        } catch (exc) {
            // Error handling goes here.
        }
    }
    //</SnippetShareFileFunction>
    //</SnippetShareFileFunction_JS>
    
    
    function shareFiles() {
        var dataTransferManager = Windows.ApplicationModel.DataTransfer.DataTransferManager.getForCurrentView();
        dataTransferManager.addEventListener("datarequested", function (e) {
            var request = e.request;
            request.data.properties.title = "Share Files Example";
            request.data.properties.description = "A demonstration that shows how to share files.";
            //<SnippetFileTypesProperty_JS>
            //<SnippetFileTypesProperty>
            request.data.properties.fileTypes.replaceAll([".jpg", ".bmp", ".gif", ".png", ".wmv"]);
            //</SnippetFileTypesProperty>
            //</SnippetFileTypesProperty_JS>
            //<SnippetSetDataProvider_JS>
            //<SnippetSetDataProvider>
            request.data.setDataProvider(Windows.ApplicationModel.DataTransfer.StandardDataFormats.bitmap, onDeferredImageRequested);
            //</SnippetSetDataProvider>
            //</SnippetSetDataProvider_JS>
        });
    }
    
    //</SnippetHowToShareFiles>
    //</SnippetHowToShareFiles_JS>
    app.start();
})();