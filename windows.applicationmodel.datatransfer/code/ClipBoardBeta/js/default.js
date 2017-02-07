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
            trackClipboardChanges();
        }
    };

    
    function setClipboardContent() {
        
        var dataPackage = new Windows.ApplicationModel.DataTransfer.DataPackage();
        // <SnippetSetContentToDataPackage>
        dataPackage.setText("Hello World!");
        // </SnippetSetContentToDataPackage>
        //<SnippetSetContentToClipboard>
        Windows.ApplicationModel.DataTransfer.Clipboard.setContent(dataPackage);
        //</SnippetSetContentToClipboard>
    }
    


    function cutContent() {
        //<SnippetClipboardCut_Move>
        //<SnippetClipboardGetDataPackage>
        var dataPackage = new Windows.ApplicationModel.DataTransfer.DataPackage();
        //</SnippetClipboardGetDataPackage>
        dataPackage.requestedOperation = Windows.ApplicationModel.DataTransfer.DataPackageOperation.move;
        //</SnippetClipboardCut_Move>
    }


    function copyContent() {
        //<SnippetClipboardCopy>
        var dataPackage = new Windows.ApplicationModel.DataTransfer.DataPackage();
        dataPackage.requestedOperation = Windows.ApplicationModel.DataTransfer.DataPackageOperation.copy;
        //</SnippetClipboardCopy>
    }

    function trackClipboardChanges() {
        //<SnippetTrackClipboardChanges>
        Windows.ApplicationModel.DataTransfer.Clipboard.addEventListener("contentchanged", function (event) {
            //<SnippetGetClipboardContent>
            var dataPackageView = Windows.ApplicationModel.DataTransfer.Clipboard.getContent();
            if (dataPackageView.contains(Windows.ApplicationModel.DataTransfer.StandardDataFormats.text)) {
                dataPackageView.getTextAsync().then(function (text) {
                    // To output the text from this example, you need an HTML element
                    // with an id of "output".
                    document.getElementById("output").innerText = "Clipboard now contains: " + text;
                });
            }
            //</SnippetGetClipboardContent>
        });
        //</SnippetTrackClipboardChanges>
    }


    //<SnippetTrackClipboardChanges1>
    function RegisterEvents() {

        // Register a listener for the ContentChanged event. It is called whenever 
        // the clipboard content changes
        Windows.ApplicationModel.DataTransfer.Clipboard.addEventListener(
            "contentchanged", onClipboardContentChanged); 

	// TODO: Register other event listeners here.

    }
    //</SnippetTrackClipboardChanges1>

    //<SnippetTrackClipboardChanges2>
    function onClipboardContentChanged(e) {
        var dataPackageView = Windows.ApplicationModel.DataTransfer.Clipboard.getContent();
        if (dataPackageView.contains(Windows.ApplicationModel.DataTransfer.StandardDataFormats.bitmap)) {
            // TODO: Enable the Paste command.

        }
    }
    //</SnippetTrackClipboardChanges2>


    app.start();
})();
