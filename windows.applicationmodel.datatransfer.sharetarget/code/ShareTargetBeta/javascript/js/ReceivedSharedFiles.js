// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232509
(function () {
    "use strict";

    var app = WinJS.Application;

    // This function responds to all application activations.
    app.onactivated = function (eventObject) {
        if (eventObject.detail.kind === Windows.ApplicationModel.Activation.ActivationKind.shareTarget) {
            shareOperation - eventObject.detail.shareOperation;
            //<SnippetReceivedContentContainsStorageItems>
            if (shareOperation.data.contains(Windows.ApplicationModel.DataTransfer.StandardDataFormats.storageItems)) {
                // Code to process storageitems goes here.
            }
            //</SnippetReceivedContentContainsStorageItems>

            // Hopefully, this code will work anyway.
            //<SnippetHowToReceiveFiles>
            if (shareOperation.data.contains(Windows.ApplicationModel.DataTransfer.StandardDataFormats.storageItems)) {
                //<SnippetReportStarted>
                shareOperation.reportStarted();
                //</SnippetReportStarted>
                //<SnippetGetStorageItemAsync>
                shareOperation.data.getStorageItemsAsync().then(function (storageItems) {
                    var fileList = "";
                    for (var i = 0; i < storageItems.size; i++) {
                        fileList += storageItems.getAt(i).name;
                        if (i < storageItems.size - 1) {
                            fileList += ", ";
                        }
                    }
                    filesDiv = document.createElement("div");
                    filesDiv.innerText = fileList;
                    document.body.appendChild(filesDiv);
                });
                //</SnippetGetStorageItemAsync>
                shareOperation.reportCompleted();
            }
            //</SnippetHowToReceiveFiles>
        }
    };

    //<SnippetHowToCreateQuickLink>
    function reportCompleted() {
        //<SnippetGetQuickLinkObject>
        var quickLink = new Windows.ApplicationModel.DataTransfer.ShareTarget.QuickLink();
        //</SnippetGetQuickLinkObject>
        //<SnippetQuickLinkId>
        quickLink.id = "123456789";
        //</SnippetQuickLinkId>
        //<SnippetQuickLinkTitleAndIcon>
        quickLink.title = id("quickLinkTitle").value;
        
        // For quicklinks, the supported FileTypes and DataFormats are set 
        // independently from the manifest.
        //<SnippetQuickLinkFormatsAndTypes>
        var dataFormats = Windows.ApplicationModel.DataTransfer.StandardDataFormats;
        quickLink.supportedFileTypes.replaceAll(["*"]);
        quickLink.supportedDataFormats.replaceAll([dataFormats.text, dataFormats.uri, 
            dataFormats.bitmap, dataFormats.storageItems, dataFormats.html, customFormatName]);
        //</SnippetQuickLinkFormatsAndTypes>

        Windows.ApplicationModel.Package.current.installedLocation.getFileAsync("images\\user.png").then(function (iconFile) {
            quickLink.thumbnail = Windows.Storage.Streams.RandomAccessStreamReference.createFromFile(iconFile);
            shareOperation.reportCompleted(quickLink);
        });
        //</SnippetQuickLinkTitleAndIcon>
        //<SnippetReportCompletedQuickLink>
        shareOperation.reportCompleted(quickLink);
        //</SnippetReportCompletedQuickLink>
    }
    //</SnippetHowToCreateQuickLink>
       

    app.start();
})();
