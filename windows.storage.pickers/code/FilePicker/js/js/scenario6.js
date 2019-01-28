﻿//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//// PARTICULAR PURPOSE.
////
//// Copyright (c) Microsoft Corporation. All rights reserved

(function () {
    "use strict";

    var fileToken;

    var page = WinJS.UI.Pages.define("/html/scenario6.html", {
        ready: function (element, options) {
            document.getElementById("saveFileButton").addEventListener("click", saveFile, false);
            document.getElementById("writeFileButton").addEventListener("click", writeFile, false);
        }
    });

    function saveFile() {
        // Clean scenario output
        WinJS.log && WinJS.log("", "sample", "status");

        // Verify that we are currently not snapped, or that we can unsnap to open the picker
        var currentState = Windows.UI.ViewManagement.ApplicationView.value;
        if (currentState === Windows.UI.ViewManagement.ApplicationViewState.snapped &&
            !Windows.UI.ViewManagement.ApplicationView.tryUnsnap()) {
            // Fail silently if we can't unsnap
            return;
        }

        // Create the picker object and set options
        var savePicker = new Windows.Storage.Pickers.FileSavePicker();
        // Dropdown of file types the user can save the file as
        savePicker.fileTypeChoices.insert("Plain Text", [".txt"]);
        // Default file name if the user does not type one in or select a file to replace
        savePicker.suggestedFileName = "New Document";

        savePicker.pickSaveFileAsync().then(function (file) {
            if (file) {
                fileToken = Windows.Storage.AccessCache.StorageApplicationPermissions.futureAccessList.add(file);
                WinJS.log && WinJS.log("Received File: " + file.name, "sample", "status");
                writeFileButton.disabled = false;
            } else {
                // The picker was dismissed with no selected file
                WinJS.log && WinJS.log("Operation cancelled.", "sample", "status");
            }
        });
    }

    function writeFile() {
        if (fileToken) {
            //<Snippetall_cachedfilemanager_defer>
            Windows.Storage.AccessCache.StorageApplicationPermissions.futureAccessList.getFileAsync(fileToken).then(function (file) {
                if (file) {
                    // Prevent updates to the remote version of the file until we finish making changes and call CompleteUpdatesAsync.
                    Windows.Storage.CachedFileManager.deferUpdates(file);
                    var now = Windows.Globalization.DateTimeFormatting.DateTimeFormatter.longTime.format(new Date());
                    Windows.Storage.FileIO.appendTextAsync(file, "\nText Added @ " + now).then(function () {
                        Windows.Storage.CachedFileManager.completeUpdatesAsync(file).then(function (fileUpdateStatus) {
                            switch (fileUpdateStatus) {
                                case Windows.Storage.Provider.FileUpdateStatus.complete:
                                    WinJS.log && WinJS.log("File " + file.name + " was saved.", "sample", "status");
                                    printFileAsync(file);
                                    break;

                                case Windows.Storage.Provider.FileUpdateStatus.completeAndRenamed:
                                    WinJS.log && WinJS.log("File " + file.name + " was renamed and saved.", "sample", "status");
                                    Windows.Storage.AccessCache.StorageApplicationPermissions.futureAccessList.addOrReplace(fileToken, file);
                                    printFileAsync(file);
                                    break;

                                default:
                                    WinJS.log && WinJS.log("File " + file.name + " couldn't be saved.", "sample", "status");
                                    break;
                            }
                        }, WinJS.log);
                    }, WinJS.log);
                }
            }, WinJS.log);
            //</Snippetall_cachedfilemanager_defer>
        }
    }

    function printFileAsync(file) {
        Windows.Storage.FileIO.readTextAsync(file).then(function (fileContent) {
            WinJS.log && WinJS.log("Received File: " + file.name + "\n" + "File Content: " + fileContent, "sample", "status");
        }, WinJS.log);
    }
})();
