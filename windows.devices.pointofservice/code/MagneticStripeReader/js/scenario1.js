//// Copyright (c) Microsoft Corporation. All rights reserved

(function () {
    "use strict";
    var page = WinJS.UI.Pages.define("/html/scenario1.html", {
        ready: function (element, options) {
            document.getElementById("startReadButton").addEventListener("click", startRead, false);
            document.getElementById("endReadButton").addEventListener("click", endRead, false);
            document.getElementById("startReadButton").disabled = false;
            document.getElementById("endReadButton").disabled = false;
        },

        unload: function () {
            if (document.getElementById("startReadButton").disabled) {
                if (_claimedReader !== null) {
                    _claimedReader.removeEventListener("bankcarddatareceived", onBankCardDataReceived);
                    _claimedReader.close();
                    _claimedReader = null;
                }

                _reader = null;
            }
        }
    });

    //<SnippetCreateMagStripeReaderJS>
    //Creates the magnetic stripe reader, claims it for exclusive use, adds a data event listener, 
    //and enables it to receive data.
    var _reader = null;
    var _claimedReader = null;

    function startRead() {
        Windows.Devices.PointOfService.MagneticStripeReader.getDefaultAsync().then(function (reader) {
            if (reader !== null) {
                _reader = reader;
                
                reader.claimReaderAsync().done(function (claimedReader) {
                    _claimedReader = claimedReader;
                    claimedReader.isDecodeDataEnabled = true;
                   
                    claimedReader.addEventListener("bankcarddatareceived", onBankCardDataReceived);
                    claimedReader.enableAsync().done(function () {
                       
                        document.getElementById("startReadButton").disabled = true;
                        document.getElementById("endReadButton").disabled = false;
                    }, function error(e) {
                        // "Failed to enable the magnetic stripe reader."
                    });
                }, function error(e) {
                    //"Could not claim the magnetic stripe reader."
                });
            }
            else {
                //"Could not claim the magnetic stripe reader."
            }
               
        }, function error(e) {
            //"Magnetic stripe reader not found. Connect a magnetic stripe reader."
        });
    }
    //</SnippetCreateMagStripeReaderJS>

    //<SnippetMagStripeReaderDataReceivedJS>
    function onBankCardDataReceived(args) {
        WinJS.log && WinJS.log("Got data", "sample", "status");

        document.getElementById("expirationDate").textContent = args.expirationDate;
        document.getElementById("firstName").textContent = args.firstName;
        document.getElementById("middleInitial").textContent = args.middleInitial;
        document.getElementById("serviceCode").textContent = args.serviceCode;
        document.getElementById("suffix").textContent = args.suffix;
        document.getElementById("surname").textContent = args.surname;
        document.getElementById("title").textContent = args.title;
    }
    //</SnippetMagStripeReaderDataReceivedJS>

    function endRead() {
        if (_claimedReader !== null) {
            _claimedReader.removeEventListener("bankcarddatareceived", onBankCardDataReceived);
            _claimedReader.close();
            _claimedReader = null;
        }
        _reader = null;
        WinJS.log("Click the Start Receiving Data Button..", "sample", "status");
        document.getElementById("startReadButton").disabled = false;
        document.getElementById("endReadButton").disabled = true;

        document.getElementById("expirationDate").textContent = "No data";
        document.getElementById("firstName").textContent = "No data";
        document.getElementById("middleInitial").textContent = "No data";
        document.getElementById("serviceCode").textContent = "No data";
        document.getElementById("suffix").textContent = "No data";
        document.getElementById("surname").textContent = "No data";
        document.getElementById("title").textContent = "No data";
    }
})();
