(function () {
    'use strict';
    // Uncomment the following line to enable first chance exceptions.
    // Debug.enableFirstChanceException(true);


    WinJS.Application.onmainwindowactivated = function (e) {
        if (e.detail.kind === Windows.ApplicationModel.Activation.ActivationKind.launch) {
            shareText();
            //shareTextWithFormat();
            //shareHtml();
            //shareUri();
            //shareBitmap();
            //shareFiles();
            //setDelegate();
            //setData();
        }
    }

    function shareText() {
        /* The following is a basic share example. It demonstrates the following elements of the DataTransfer namespace:
                * DataTransfer.getForCurrentView()
                * DataRequested event
                * DataRequest object
                * DataPackagePropertySet (general)
                * DataPackagePropertySet.title
                * DataPackagePropertySet.description
                * setText()
        */
        //<SnippetShareBasic1>
        var dataTransferManager = Windows.ApplicationModel.DataTransfer.DataTransferManager.getForCurrentView();
        dataTransferManager.addEventListener("datarequested", function (e) {
            var request = e.request;
            request.data.properties.title = "Share Text Example";
            request.data.properties.description = "A demonstration that shows how to share.";
            request.data.setText("Hello World!");
        });
        //</SnippetShareBasic1>
    }

    function shareTextWithFormat() {
        /* The following is a share example that shows how to use setText with a formatId. */
        //<SnippetShareTextWithFormat>
        var dataTransferManager = Windows.ApplicationModel.DataTransfer.DataTransferManager.getForCurrentView();
        dataTransferManager.addEventListener("datarequested", function (e) {
            var request = e.request;
            request.data.properties.title = "Share Text Example";
            request.data.setText(Windows.ApplicationModel.DataTransfer.StandardDataFormats.text, "Hello World!");
        });
        //</SnippetShareTextWithFormat>
    }

    function shareHtml() {
        /* The following is a share example that shows how to use the setHtml method. */
        //<SnippetShareHtml>
        var dataTransferManager = Windows.ApplicationModel.DataTransfer.DataTransferManager.getForCurrentView();
        dataTransferManager.addEventListener("datarequested", function (e) {
            var request = e.request;
            request.data.properties.title = "Share HTML Example";
            request.data.setHtml("<h1>Hello World!</h1>");
        });
        //</SnippetShareHtml>
    }

    function shareUri() {
        /* The following is a share example that shows how to use the setUri method. */
        //<SnippetShareUri>
        var dataTransferManager = Windows.ApplicationModel.DataTransfer.DataTransferManager.getForCurrentView();
        dataTransferManager.addEventListener("datarequested", function (e) {
            var request = e.request;
            var uri = new Windows.Foundation.Uri("http://www.fabrkiam.com");
            request.data.properties.title = "Share URI Example";
            request.data.setUri(uri);
        });
        //</SnippetShareUri>
    }
    //<SnippetShareMain_AsynchronousShare>
    function asynchronousShare() {
        var imageFile = null;
        var picker = new Windows.Storage.Pickers.FileOpenPicker();
        picker.fileTypeFilter.replaceAll([".jpg", ".bmp", ".gif", ".png"]);
        picker.viewMode = Windows.Storage.Pickers.PickerViewMode.thumbnail;
        picker.pickSingleFileAsync().then(function (file) {
            if (file) {
                imageFile = file;
                var dataTransferManager = Windows.ApplicationModel.DataTransfer.DataTransferManager.getForCurrentView();
                //<SnippetShareMain_AddEventListener>
                dataTransferManager.addEventListener("datarequested", function (e) {
                    var request = e.request;
                    request.data.properties.title = "Asynchronous Share Example";
                    //<SnippetShareMain_GetDeferralObject>
                    var deferral = request.getDeferral();
                    //</SnippetShareMain_GetDeferralObject>
                    //<SnippetShareMain_CallAsyncFunction>
                    imageFile.openAsync(Windows.Storage.FileAccessMode.read).then(function (randomAccessStream) {
                        request.data.setBitmap(randomAccessStream);
                        deferral.complete();
                    });
                    //</SnippetShareMain_CallAsyncFunction>
                });
                //</SnippetShareMain_AddEventListener>
            } else {
                var error = document.createElement("div");
                error.innerText = "An error occurred.";
                document.body.appendChild(error);
            }
        });
    }
    //</SnippetShareMain_AsynchronousShare>
    function shareBitmap() {
        /* The following is a share example that demonstrates the following:
            * setBitmap
            * DataPackagePropertySet.thumbnail
            * DataRequest.getDeferral
            * DataRequestDeferral (general)
            * DataRequestDeferral.complete
        */
        //<SnippetShareBitmap_Deferral>
        var imageFile = null;
        var picker = new Windows.Storage.Pickers.FileOpenPicker();
        picker.fileTypeFilter.replaceAll([".jpg", ".bmp", ".gif", ".png"]);
        picker.viewMode = Windows.Storage.Pickers.PickerViewMode.thumbnail;
        picker.pickSingleFileAsync().then(function (file) {
            if (file) {
                imageFile = file;
                var dataTransferManager = Windows.ApplicationModel.DataTransfer.DataTransferManager.getForCurrentView();
                dataTransferManager.addEventListener("datarequested", function (e) {
                    var request = e.request;
                    request.data.properties.title = "Share Image Example";
                    var streamReference = Windows.Storage.Streams.StreamReference.createFromFile(imageFile);
                    request.data.properties.thumbnail = streamReference;
                    request.data.setStorageItems([imageFile]);
                    var deferral = request.getDeferral();
                    imageFile.openAsync(Windows.Storage.FileAccessMode.read).then(function (randomAccessStream) {
                        request.data.setBitmap(randomAccessStream);
                        deferral.complete();
                    });
                });
            } else {
                var error = document.createElement("div");
                error.innerText = "An error occurred.";
                document.body.appendChild(error);
            }
        });
        //</SnippetShareBitmap_Deferral>
    }

    function shareFiles() {
        /* The following sample demonstrates the setStorageItems method. */
        //<SnippetShareStorageItems>
        var picker = new Windows.Storage.Pickers.FileOpenPicker();
        picker.fileTypeFilter.append(".docx");
        picker.viewMode = Windows.Storage.Pickers.PickerViewMode.list;
        picker.pickMultipleFilesAsync().then(function (files) {
            if (files) {
                //If we have files, we can set up the datapackage
                var dataTransferManager = Windows.ApplicationModel.DataTransfer.DataTransferManager.getForCurrentView();
                dataTransferManager.addEventListener("datarequested", function (e) {
                    var request = e.request;
                    request.data.properties.title = "Share Files Example";
                    request.data.setStorageItems(files);
                });
            } else {
                var error = document.createElement("div");
                error.innerText = "An error occurred.";
                document.body.appendChild(error);
            }
        });
        //</SnippetShareStorageItems>
    }

    //<SnippetShareMain_OnDemand>
    function setDelegate() {
        var stringWithHtml = "<h1>This string has HTML tags around it.</h1>";
        var dataTransferManager = Windows.ApplicationModel.DataTransfer.DataTransferManager.getForCurrentView();
        //<SnippetShareMain_AddEventListenerDelegate>
        dataTransferManager.addEventListener("datarequested", function (e) {
            var request = e.request;
            request.data.properties.title = "Share Text Example";
            //<SnippetShareMain_SetDelegate>
            request.data.setDataProvider(Windows.ApplicationModel.DataTransfer.StandardDataFormats.text, function () {
                var tempDiv = document.createElement("div");
                tempDiv.innerHTML = stringWithHtml;
                request.data.setData(Windows.ApplicationModel.DataTransfer.StandardDataFormats.text, tempDiv.innerText);
            });
            //</SnippetShareMain_SetDelegate>
        });
        //</SnippetShareMain_AddEventListenerDelegate>
    }
    //</SnippetShareMain_OnDemand>
    //Not working... yet.
    function shareData() {
        var picker = new Windows.Storage.Pickers.FileOpenPicker();
        picker.fileTypeFilter.append(".pdf");
        picker.viewMode = Windows.Storage.Pickers.PickerViewMode.list;
        picker.pickSingleFileAsync().then(function (file) {
            if (file) {
                //If we have files, we can set up the datapackage
                var dataTransferManager = Windows.ApplicationModel.DataTransfer.DataTransferManager.getForCurrentView();
                dataTransferManager.addEventListener("datarequested", function (e) {
                    var request = e.request;
                    request.data.properties.title = "Share Data Example";
                    request.data.properties.fileTypes = [".pdf"];
                    var streamReference = Windows.Storage.Streams.StreamReference.createFromFile(file);
                    request.data.setData(".pdf", streamReference);
                });
            } else {
                document.getElementById("output").innerText = "An error occurred.";
            }
        });
    }


    WinJS.Application.start();
})();