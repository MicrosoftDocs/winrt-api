//// Copyright (c) Microsoft Corporation. All rights reserved

(

function () {
    "use strict";
    var page = WinJS.UI.Pages.define("/html/scenario1.html",

        {
            ready: function (element, options) {
                document.getElementById("btnStartReading").addEventListener("click", startReceivingData, false);
                document.getElementById("btnEndReading").addEventListener("click", endReceivingData, false);
                document.getElementById("btnStartReading").disabled = false;
                document.getElementById("btnEndReading").disabled = true;
            },

            unload: function () {
                if (document.getElementById("btnStartReading").disabled) {
                    if (_claimedScanner !== null) {
                        _claimedScanner.removeEventListener("datareceived", onDataReceived);
                        _claimedScanner.close();
                        _claimedScanner = null;
                    }
                    _scanner = null;
                }
            }
        });
    //<SnippetCreateBarcodeScannerJS>
    //Creates the barcode scanner, claims it for exclusive use, adds a data event listener, 
    //and enables it to receive data.
    var _scanner = null;
    var _claimedScanner = null;

    function startReceivingData() {
        Windows.Devices.PointOfService.BarcodeScanner.getDefaultAsync().then(function (scanner) {
            if (scanner !== null) {
                _scanner = scanner;

                scanner.claimScannerAsync().done(function (claimedScanner) {
                    if (claimedScanner !== null) {
                        _claimedScanner = claimedScanner;
                        claimedScanner.isDecodeDataEnabled = true;

                        claimedScanner.addEventListener("datareceived", onDataReceived);
                        claimedScanner.enableAsync().done(function () {

                            document.getElementById("btnStartReading").disabled = true;
                            document.getElementById("btnEndReading").disabled = false;
                        }, function error(e) {
                            // "Failed to enable scanner."
                        });

                    } else {
                        //"Could not claim the scanner."
                    }
                }, function error(e) {
                    //"Could not claim the scanner."
                });

            } else {
                //"Barcode scanner not found. Connect a barcode scanner."
            }

        }, function error(e) {
            //"Asynchronous method failed."
        });
    }
    //</SnippetCreateBarcodeScannerJS>

    //<SnippetDataReceivedJS>
    function onDataReceived(args) {
        var tempScanLabel = Windows.Storage.Streams.DataReader.fromBuffer(args.report.scanDataLabel).readString(args.report.scanDataLabel.length);
        var tempScanData = Windows.Storage.Streams.DataReader.fromBuffer(args.report.scanData).readString(args.report.scanData.length);
        var tempScanType = args.report.scanDataType;
        WinJS.logAppend("Got data",  "status");

        document.getElementById("scanDataId").textContent = tempScanType;
        document.getElementById("scanData").textContent = tempScanData;
        document.getElementById("scanDataLabel").textContent = tempScanLabel;

    }
    //</SnippetDataReceivedJS>
    function endReceivingData() {
        if (_claimedScanner !== null) {
            _claimedScanner.removeEventListener("datareceived", onDataReceived);
            _claimedScanner.close();
            _claimedScanner = null;
        }
        _scanner = null;
        WinJS.logAppend("Click the Start Receiving Data Button..", "status");
        document.getElementById("btnStartReading").disabled = false;
        document.getElementById("btnEndReading").disabled = true;
        document.getElementById("scanDataId").textContent = "No Data";
        document.getElementById("scanData").textContent = "No Data";
        document.getElementById("scanDataLabel").textContent = "No Data";
       
    }


})();
