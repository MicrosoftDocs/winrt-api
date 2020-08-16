---
-api-id: T:Windows.ApplicationModel.Resources.Core.ResourceManager
-api-type: winrt class
---

<!-- Class syntax.
public class ResourceManager : Windows.ApplicationModel.Resources.Core.IResourceManager, Windows.ApplicationModel.Resources.Core.IResourceManager2
-->

# Windows.ApplicationModel.Resources.Core.ResourceManager

## -description

Provides access to application resource maps and more advanced resource functionality.

## -remarks

## -examples

This example is based on scenario 13 of the [Application resources and localization sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/ApplicationResources). See the sample for the more complete solution.

```javascript
// Create a ResourceContext.
var resourceContext = new Windows.ApplicationModel.Resources.Core.ResourceContext();

// Set the specific context for lookup of resources.
var qualifierValues = resourceContext.qualifierValues;
qualifierValues["language"] = "en-US";
qualifierValues["contrast"] = "standard";
qualifierValues["scale"] = "140";
qualifierValues["homeregion"] = "021"; // Northern America

// Resources actually reside within Scenario13 Resource Map.
var resourceIds = [
    '/Scenario13/languageOnly',
    '/Scenario13/scaleOnly',
    '/Scenario13/contrastOnly',
    '/Scenario13/homeregionOnly',
    '/Scenario13/multiDimensional',
];

var output = { str: "" };
resourceIds.forEach(function (resourceId) {
    renderNamedResource(resourceId, resourceContext, output);
});

function renderNamedResource(resourceId, resourceContext, output) {
    output.str += "Resource ID " + resourceId + ":\n";
    // Lookup the resource in the mainResourceMap (the one for this package).
    var namedResource = Windows.ApplicationModel.Resources.Core.ResourceManager.current.mainResourceMap.lookup(resourceId);

    // Return a ResourceCandidateVectorView of all possible resources candidates
    // resolved against the context in order of appropriateness.
    var resourceCandidates = namedResource.resolveAll(resourceContext);

    resourceCandidates.forEach(function (candidate, index) {
        renderCandidate(candidate, index, output);
    });
    output.str += "\n";
}

function renderCandidate(candidate, index, output) {
    // Get all the various qualifiers for the candidate (such as language, scale, contrast).
    candidate.qualifiers.forEach(function (qualifier) {
        output.str += "qualifierName: " + qualifier.qualifierName + "\n";
        output.str += "qualifierValue: " + qualifier.qualifierValue + "\n";
        output.str += "isDefault: ";
        output.str += (qualifier.isDefault) ? "true\n" : "false\n";
        output.str += "isMatch: ";
        output.str += (qualifier.isMatch) ? "true\n" : "false\n";
        output.str += "score: " + qualifier.score + "\n";
        output.str += "\n";
    });
}
```

## -see-also

[Creating and retrieving resources in ](http://msdn.microsoft.com/en-us/library/windows/apps/hh694557.aspx), [App resources and localization sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/ApplicationResources), [Application resources and localization sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620487)
