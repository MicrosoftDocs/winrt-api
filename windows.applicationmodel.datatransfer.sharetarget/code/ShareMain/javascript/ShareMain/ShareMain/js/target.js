var shareOperation = null;

function activatedHandler(eventArgs) {
    shareOperation = eventArgs.shareOperation;
    if (eventArgs.kind === Windows.ApplicationModel.Activation.ActivationKind.shareTarget) {

        /* Sample that shows how to process text that has been shared by a source app.
        Use this just for testing purposes. For samples/snippets, use the code found in activatedHandlerBasic. */

        if (shareOperation.data.contains(Windows.ApplicationModel.DataTransfer.StandardDataFormats.text)) {
            var output = document.createElement("div");
            var shareData = shareOperation.data.getText();
            output.innerText = shareData;
            document.body.appendChild(output);
        }

        /* Sample that shows how to process html that has been shared by a source app. Demonstrates:
            * StandardDataFormats.html
            * getHtml
        */
        //<SnippetShareTargetHtml>
        if (shareOperation.data.contains(Windows.ApplicationModel.DataTransfer.StandardDataFormats.html)) {
            var output = document.createElement("div");
            var shareData = shareOperation.data.getHtml();
            output.innerHTML = shareData;
            document.body.appendChild(output);
        }
        //</SnippetShareTargetHtml>

        /* Sample that shows how to process a URI that has been shared by a source app. Demonstrates:
            * StandardDataFormats.uri
            * getUri
        */
        //<SnippetShareTargetUri>
        if (shareOperation.data.contains(Windows.ApplicationModel.DataTransfer.StandardDataFormats.uri)) {
            var output = document.createElement("iframe");
            var shareData = shareOperation.data.getUri();
            output.setAttribute("src", shareData.rawUri);
            document.body.appendChild(output);
        }
        //</SnippetShareTargetUri>

        /* Sample that shows how to process an image that has been shared by a source app. Demonstrates:
            * StandardDataFormats.bitmap
            * DataPackagePropertySet.Thumbnail ***Note: use with other example in source.js***
            * getBitmap
        */
        //<SnippetShareTargetBitmap_Thumbnail>
        if (shareOperation.data.contains(Windows.ApplicationModel.DataTransfer.StandardDataFormats.bitmap)) {
            if (shareOperation.data.properties.thumbnail) {
                shareOperation.data.properties.thumbnail.getStreamAsync().then(function (thumbnailStream) {
                    var thumbnailBlob = msWWA.createBlobFromRandomAccessStream(thumbnailStream.contentType, thumbnailStream);
                    var thumbnailUrl = URL.createObjectURL(thumbnailBlob, false);
                    var thumbnailDisplay = document.createElement("img");
                    thumbnailDisplay.setAttribute("src", thumbnailUrl);
                    document.body.appendChild(thumbnailDisplay);
                });
            }
            var bitmapStream = shareOperation.data.getBitmap();
            var imageBlob = msWWA.createBlobFromRandomAccessStream("image/bmp", bitmapStream);
            var imageDisplay = document.createElement("img");
            imageDisplay.setAttribute("src", URL.createObjectURL(imageBlob, false));
            document.body.appendChild(imageDisplay);
        }
        //</SnippetShareTargetBitmap_Thumbnail>

        /* Sample that shows how to process files that have been shared by a source app. Demonstrates:
            * StandardDataFormats.storageItems
            * getStorageItemsAsync
        */
        //<SnippetShareTargetStorageItems>
        if (shareOperation.data.contains(Windows.ApplicationModel.DataTransfer.StandardDataFormats.storageItems)) {
            shareOperation.data.getStorageItemsAsync().then(function (storageItems) {
                var fileList = "";
                for (var i = 0; i < storageItems.size; i++) {
                    fileList += storageItems.getAt(i).name;
                    if (i < storageItems.size - 1) {
                        fileList += ", ";
                    }
                }
                var output = document.createElement("div");
                output.innerText = fileList;
                document.body.appendChild(output);
            });
        }
        //</SnippetShareTargetStorageItems>
    }
}
/* The following is a basic example of how to handle a shareOperation. It demonstrates:
        * ShareOperation (general)
        * ShareOperation.data
        * DataPackage.contains
        * getText
        * StandardDataFormats.text
        * shareOperation.reportCompleted()
    */
//<SnippetHowToShareText>
function activatedHandlerBasic(eventArgs) {
    //<SnippetShareTargetBasic>
    if (eventArgs.kind === Windows.ApplicationModel.Activation.ActivationKind.shareTarget) {
        shareOperation = eventArgs.shareOperation;
        if (shareOperation.data.contains(Windows.ApplicationModel.DataTransfer.StandardDataFormats.text)) {
            var output = document.createElement("div");
            var shareData = shareOperation.data.getText();
            output.innerText = shareData;
            document.body.appendChild(output);
            shareOperation.reportCompleted();
        }
    }
    //</SnippetShareTargetBasic>
}
//</SnippetHowToShareText>
//<SnippetAddEventHandler>
Windows.UI.WebUI.WebUIApplication.addEventListener("activated", activatedHandler);
//</SnippetAddEventHandler>
// Adding another event handler to so we can have a sample that shows a basic way of handling share operations.
//Windows.UI.WebUI.WebUIApplication.addEventListener("activated", activatedHandlerBasic);