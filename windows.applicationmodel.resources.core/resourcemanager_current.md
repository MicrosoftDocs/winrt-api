---
-api-id: P:Windows.ApplicationModel.Resources.Core.ResourceManager.Current
-api-type: winrt property
---

<!-- Property syntax
public Windows.ApplicationModel.Resources.Core.ResourceManager Current { get; }
-->

# Windows.ApplicationModel.Resources.Core.ResourceManager.Current

## -description
Gets the [ResourceManager](resourcemanager.md) for the currently running application.

## -property-value
The application default [ResourceManager](resourcemanager.md), initialized with the resources for all of the packages in the package graph.

## -remarks
Returns ERROR_MRM_INVALID_PRI_FILE if one of the packages contains a malformed PRI file.

## -examples

## -see-also
