//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//// PARTICULAR PURPOSE.
////
//// Copyright (c) Microsoft Corporation. All rights reserved

(function () {
    "use strict";

    var page = WinJS.UI.Pages.define("/html/scenario4.html", {
        ready: function (element, options) {
            WinJS.log && WinJS.log("Use the search pane to submit a query", "sample", "status");

            // Have Windows provide suggestions from local files.
            // Scenarios 2-6 introduce different methods of providing suggestions. The local suggestion feature is enabled in this reduced scope
            //  for this sample's purpose, but in the common case, you should place this code in the global scope, e.g. default.js, to run as
            // soon as your app is launched. This way your app can provide suggestions anytime the user brings up the search pane.
            //<Snippetnewlssettings_setprops_setlssettings_js>
            //<Snippetsearchpane_setlssettings_js>
            //<Snippetgetsearchpane_js>
            //<Snippetnewlssettings_setprops_js>
            //<Snippetlssettings_aqs_js>
            //<Snippetlssettings_appendloc_js>
            //<Snippetlssettings_enable_js>
            //<Snippetnewlssettings_js>
            //<Snippetall_localsuggestions>
            var localSuggestionSettings = new Windows.ApplicationModel.Search.LocalContentSuggestionSettings();
            //</Snippetnewlssettings_js>
            localSuggestionSettings.enabled = true;
            //</Snippetlssettings_enable_js>
            localSuggestionSettings.locations.append(Windows.Storage.KnownFolders.musicLibrary);
            //</Snippetlssettings_appendloc_js>
            localSuggestionSettings.aqsFilter = "kind:=music";
            //</Snippetlssettings_aqs_js>
            //</Snippetnewlssettings_setprops_js>
            //</Snippetall_localsuggestions>

            Windows.ApplicationModel.Search.SearchPane.getForCurrentView().setLocalContentSuggestionSettings(localSuggestionSettings);
            //</Snippetgetsearchpane_js>
            //</Snippetsearchpane_setlssettings_js>
            //</Snippetnewlssettings_setprops_setlssettings_js>
        },
        unload: function () {
            // Scenarios 2-6 introduce different methods of providing suggestions. For the purposes of this sample,
            // remove suggestion handling when unloading this page so that it does not conflict with other scenarios.
            // This should not be added to your app.
            //<Snippetnewlssettings_disable_setlssettings_js>
            //<Snippetlssettings_disable_js>
            //<Snippetall_localsuggestions_disable>
            var localSuggestionSettings = new Windows.ApplicationModel.Search.LocalContentSuggestionSettings();
            localSuggestionSettings.enabled = false;
            Windows.ApplicationModel.Search.SearchPane.getForCurrentView().setLocalContentSuggestionSettings(localSuggestionSettings);
            //</Snippetlssettings_disable_js>
            //</Snippetall_localsuggestions_disable>
            //</Snippetnewlssettings_disable_setlssettings_js>
        }
    });
})();
