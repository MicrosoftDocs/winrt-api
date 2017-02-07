//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//// PARTICULAR PURPOSE.
////
//// Copyright (c) Microsoft Corporation. All rights reserved

(function () {
    "use strict";

    var sampleTitle = "Search contract JS sample";

    var scenarios = [
        { url: "/html/scenario1.html", title: "Using the Search contract" },
        { url: "/html/scenario2.html", title: "Suggestions from an app-defined list" },
        { url: "/html/scenario3.html", title: "Suggestions in East Asian languages" },
        { url: "/html/scenario4.html", title: "Suggestions provided by Windows" },
        { url: "/html/scenario5.html", title: "Suggestions from Open Search" },
        { url: "/html/scenario6.html", title: "Suggestions from a service returning XML" },
        { url: "/html/scenario7.html", title: "Open Search charm by typing" }
    ];

    // Scenario 1 : Supporting Search Contract Activation.
    //<Snippetactevent_searchkind_js>
    //<Snippetlistenevent_querysubmitted_js>
    //<Snippetlistenevent_suggestionreq_js
    WinJS.Application.addEventListener("activated", activated, false);
    //</Snippetlistenevent_suggestionreq_js
    //</Snippetlistenevent_querysubmitted_js>
    //</Snippetlistenevent_resultsuggestionchosen_js>

    //<Snippetactevent_handler_js>
    //<Snippetjs_searchactivated_handler>
    function activated(eventObject) {
        if (eventObject.detail.kind === Windows.ApplicationModel.Activation.ActivationKind.launch) {
            // Use setPromise to indicate to the system that the splash screen must not be torn down
            // until after processAll and navigate complete asynchronously.
            eventObject.setPromise(WinJS.UI.processAll().then(function () {
                // Navigate to either the first scenario or to the last running scenario
                // before suspension or termination.
                var url = WinJS.Application.sessionState.lastUrl || scenarios[0].url;
                return WinJS.Navigation.navigate(url);
            }));
        //<Snippetsearchkind_js>
        //<Snippetsearchquerytext_js>
        //<Snippetidentify_searchactivation_open_js>
        } else if (eventObject.detail.kind === Windows.ApplicationModel.Activation.ActivationKind.search) {
        //</Snippetidentify_searchactivation_open_js>
            // Use setPromise to indicate to the system that the splash screen must not be torn down
            // until after processAll and navigate complete asynchronously.
            eventObject.setPromise(WinJS.UI.processAll().then(function () {
                //<Snippetsearchquerytext_open_js>
                if (eventObject.detail.queryText === "") {
                //</Snippetsearchquerytext_open_js>
                    // Navigate to your landing page since the user is pre-scoping to your app.
                } else {
                    // Display results in UI for eventObject.detail.queryText and eventObject.detail.language.
                    // eventObject.detail.language represents user's locale.
                //<Snippetsearchquerytext_close_js>
                }
                //</Snippetsearchquerytext_close_js>

                // Navigate to the first scenario since it handles search activation.
                var url = scenarios[0].url;
                return WinJS.Navigation.navigate(url, { searchDetails: eventObject.detail });
            }));
        //<Snippetidentify_searchactivation_close_js>
        }
        //</Snippetidentify_searchactivation_close_js>
        //</Snippetsearchkind_js>
        //</Snippetsearchquerytext_js>
    }
    //</Snippetactevent_handler_js>
    //</Snippetjs_searchactivated_handler>
    //</Snippetactevent_searchkind_js>

    // Scenario 1 : Support receiving a search query while running as the main application.
    //<Snippethandle_querysubmitted_js>
    //<Snippetall_searchpane_querysubmitted_register>
    Windows.ApplicationModel.Search.SearchPane.getForCurrentView().onquerysubmitted = function (eventObject) {
        WinJS.log && WinJS.log("User submitted the search query: " + eventObject.queryText, "sample", "status");
    };
    //</Snippethandle_querysubmitted_js>
    //</Snippetall_searchpane_querysubmitted_register>

    WinJS.Navigation.addEventListener("navigated", function (eventObject) {
        var url = eventObject.detail.location;
        var host = document.getElementById("contentHost");
        // Call unload method on current scenario, if there is one
        host.winControl && host.winControl.unload && host.winControl.unload();
        WinJS.Utilities.empty(host);
        eventObject.detail.setPromise(WinJS.UI.Pages.render(url, host, eventObject.detail.state).then(function () {
            WinJS.Application.sessionState.lastUrl = url;
        }));
    });

    WinJS.Namespace.define("SdkSample", {
        sampleTitle: sampleTitle,
        scenarios: scenarios
    });

    WinJS.Application.start();
})();
