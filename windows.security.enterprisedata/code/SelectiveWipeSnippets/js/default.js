// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232509
(function () {
    "use strict";

    var app = WinJS.Application;
    var activation = Windows.ApplicationModel.Activation;

    var testButton;

    app.onactivated = function (args) {
        if (args.detail.kind === activation.ActivationKind.launch) {
            if (args.detail.previousExecutionState !== activation.ApplicationExecutionState.terminated) {
                // TODO: This application has been newly launched. Initialize
                // your application here.
            } else {
                // TODO: This application has been reactivated from suspension.
                // Restore application state here.
            }

            testButton = document.getElementById("TestButton");
            testButton.addEventListener("click", testButtonClick, false);
            //addFolder("NewFolder1");
            Windows.Storage.StorageFolder.getFolderFromPathAsync(appRootFolder.localFolder.path + "\\NewFolder1").then(
                function (folder) {
                    protectItem(folder, enterpriseIdentity);
                    var status;
                    Windows.Security.EnterpriseData.FileRevocationManager.getStatusAsync(folder).then(
                        function (s) {
                            status = s;
                        });
                    addFile("NewFile1.txt", folder);
                });

            args.setPromise(WinJS.UI.processAll());
        }
    }

    app.oncheckpoint = function (args) {
        // TODO: This application is about to be suspended. Save any state
        // that needs to persist across suspensions here. You might use the
        // WinJS.Application.sessionState object, which is automatically
        // saved and restored across suspension. If you need to complete an
        // asynchronous operation before your application is suspended, call
        // args.setPromise().
    };

    function testButtonClick() {
        initializeApp("testuser");
        Windows.Storage.StorageFile.getFileFromPathAsync(appRootFolder.localFolder.path + "\\NewFolder1\\NewFile1.txt").then(
                function (file) {
                    getFileContents(file.path);
                });
    }

    //<Snippet_Global_JS>
    var appRootFolder = Windows.Storage.ApplicationData.current;
    var enterpriseIdentity = "example.com";
    var accessDeniedHResult = -2147024891;  // Access Denied (0x80070005)
    //</Snippet_Global_JS>

    //<Snippet_Protect_JS>
    // Add a folder and protect it using Selective Wipe.
    function addFolder(folderName) {
        appRootFolder.localFolder.createFolderAsync(folderName).then(
            function (newFolder) {
                protectItem(newFolder);
            });
    }

    // Add a file and protect it using Selective Wipe.
    function addFile(fileName, folder) {
        folder.createFileAsync(fileName).then(
            function (newFile) {
                Windows.Security.EnterpriseData.
                    FileRevocationManager.getStatusAsync(newFile).then(
                        function (status) {
                            if (status != Windows.Security.EnterpriseData.
                                    FileProtectionStatus.Protected) {
                                protectItem(newFile, enterpriseIdentity);
                            }
                        });
            },
            function (err) {
                // Handle error. For example, file already exists.
            });
    }

    function protectItem(item, enterpriseIdentity) {
        Windows.Security.EnterpriseData.FileRevocationManager.
            protectAsync(item, enterpriseIdentity).then(
                function (status) {
                    return status;
                });
    }
    //</Snippet_Protect_JS>

    //<Snippet_GetStatus_JS>
    function getFileContents(filePath) {
        var stream;
        var file;

        Windows.Storage.StorageFile.getFileFromPathAsync(filePath).then(
            function (f) {
                file = f;
                file.openReadAsync().then(
                    function (s) {
                        stream = s;
                        return stream;
                    },
                    function (err) {
                        if (err.number == accessDeniedHResult) {
                            // Delete file if it has been revoked.
                            selectiveWipeCleanup(file);
                        }
                    });
            });

        return null;
    }

    // Delete items revoked by Selective Wipe.
    function selectiveWipeCleanup(file) {
        Windows.Security.EnterpriseData.FileRevocationManager.
            getStatusAsync(file).then(
                function (status) {
                    if (status == 
                        Windows.Security.EnterpriseData.FileProtectionStatus.revoked) {
                            file.deleteAsync();
                    }
            });

    }
    //</Snippet_GetStatus_JS>

    //<Snippet_Revoke_JS>
    function initializeApp(userName) {
        if (getUserStatus(userName) == "Not Found") {
            Windows.Security.EnterpriseData.FileRevocationManager.revoke(enterpriseIdentity);
        }
    }
    //</Snippet_Revoke_JS>

    function getUserStatus(userName) {
        return "Not Found";
    }

    //<Snippet_CopyProtection_JS>
    function copyFile(file, newFolder) {
        file.copyAsync(newFolder).then(
            function (newFile) {
                Windows.Security.EnterpriseData.FileRevocationManager.
                    copyProtectionAsync(file, newFile);
            },
            function (err) {
                // Handle error. For example, copy already exists.
            });
    }
    //</Snippet_CopyProtection_JS>


    app.start();
})();
