﻿//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//// PARTICULAR PURPOSE.
////
//// Copyright (c) Microsoft Corporation. All rights reserved

(function () {
    "use strict";
    var page = WinJS.UI.Pages.define("/html/scenario4.html", {
        ready: function (element, options) {
            document.getElementById("save").addEventListener("click", saveFile, false);
        }
    });

    function saveFile(fileContents) {
        // Clean scenario output
        WinJS.log && WinJS.log("", "sample", "status");

        //<Snippetall_savepicker_checksnapped_show>
        //<Snippetjs_savepicker_checksnapped_show>
        // Verify that we are currently not snapped, or that we can unsnap to open the picker
        var currentState = Windows.UI.ViewManagement.ApplicationView.value;
        if (currentState === Windows.UI.ViewManagement.ApplicationViewState.snapped &&
            !Windows.UI.ViewManagement.ApplicationView.tryUnsnap()) {
            // Fail silently if we can't unsnap
            return;
        }

        //<Snippetall_savepicker_setprops_show>
        //<Snippetjs_savepicker_setprops_show>
        //<Snippetall_savepicker_setprops>
        //<Snippetjs_savepicker_setprops>
        // Create the picker object and set options
        var savePicker = new Windows.Storage.Pickers.FileSavePicker();
        savePicker.suggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.documentsLibrary;
        // Dropdown of file types the user can save the file as
        savePicker.fileTypeChoices.insert("Plain Text", [".txt"]);
        // Default file name if the user does not type one in or select a file to replace
        savePicker.suggestedFileName = "New Document";
        //</Snippetjs_savepicker_setprops>
        //</Snippetall_savepicker_setprops>

        //<Snippetall_savepicker_show>
        //<Snippetjs_savepicker_show>
        savePicker.pickSaveFileAsync().then(function (file) {
            if (file) {
                // Prevent updates to the remote version of the file until we finish making changes and call CompleteUpdatesAsync.
                Windows.Storage.CachedFileManager.deferUpdates(file);
                // write to file
                Windows.Storage.FileIO.writeTextAsync(file, fileContents).done(function () {
                    // Let Windows know that we're finished changing the file so the other app can update the remote version of the file.
                    // Completing updates may require Windows to ask for user input.
                    Windows.Storage.CachedFileManager.completeUpdatesAsync(file).done(function (updateStatus) {
                        if (updateStatus === Windows.Storage.Provider.FileUpdateStatus.complete) {
                            WinJS.log && WinJS.log("File " + file.name + " was saved.", "sample", "status");
                        } else {
                            WinJS.log && WinJS.log("File " + file.name + " couldn't be saved.", "sample", "status");
                        }
                    });
                });
            } else {
                WinJS.log && WinJS.log("Operation cancelled.", "sample", "status");
            }
        });
        //</Snippetjs_savepicker_show>
        //</Snippetall_savepicker_show>
        //</Snippetjs_savepicker_setprops_show>
        //</Snippetall_savepicker_setprops_show>
        //</Snippetjs_savepicker_checksnapped_show>
        //</Snippetall_savepicker_checksnapped_show>
    }
})();
