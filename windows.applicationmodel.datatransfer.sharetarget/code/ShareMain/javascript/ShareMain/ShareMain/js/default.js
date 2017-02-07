(function () {
    'use strict';
    // Uncomment the following line to enable first chance exceptions.
    // Debug.enableFirstChanceException(true);

    WinJS.Application.onmainwindowactivated = function (e) {
        if (e.detail.kind === Windows.ApplicationModel.Activation.ActivationKind.launch) {
            // TODO: startup code here
        }
    }

    //Test function to loop through the elements in an object:
    function whatIHave(object) {
        var properties = "";
        var functions = "";
        for (var propertyName in object) {
            // Check if it’s NOT a function
            if (!(object[propertyName]instanceof Function)) {
                properties += propertyName + ", ";
            }
        }

        for (var functionName in object) {
            // Check if it IS a function
            if (object[functionName]instanceof Function) {
                functions += functionName + ", ";
            }

        }

        var propContainer = document.createElement("div");
        propContainer.innerHTML = "Properties<br>" + properties + "<br>Functions<br>" + functions;
        document.body.appendChild(propContainer);
    }

    WinJS.Application.start();
})();