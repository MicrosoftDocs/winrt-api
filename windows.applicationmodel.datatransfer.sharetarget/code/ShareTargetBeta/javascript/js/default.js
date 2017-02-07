// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232509
(function () {
    "use strict";
    /* The code here is not intended to run. It provides basic framework for snippets for documentation purposes. 
    I am including it here so if we need to change the code, we can do so using the snippet system. */

    //<SnippetShareTargetBasicEventHandler>
    var app = WinJS.Application;

    app.onactivated = function (eventObject) {
        //<SnippetShareTargetBasicDetectShareTarget>
        if (eventObject.detail.kind === Windows.ApplicationModel.Activation.ActivationKind.shareTarget) {
            // Code to handle activation goes here.
        }
        //</SnippetShareTargetBasicDetectShareTarget>
    };

    function shareTargetPseudoCode() {
        // Just getting the shareOperation object.
        //<SnippetShareTargetShareOperationObject>
        shareOperation = eventObject.detail.shareOperation;
        //</SnippetShareTargetShareOperationObject>
        //<SnippetReportCompleted>
        shareOperation.reportCompleted();
        //</SnippetReportCompleted>
    }


    app.start();
    //</SnippetShareTargetBasicEventHandler>
})();
