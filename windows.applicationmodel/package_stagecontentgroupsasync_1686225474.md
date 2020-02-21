---
-api-id: M:Windows.ApplicationModel.Package.StageContentGroupsAsync(Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<PackageContentGroup>> Package.StageContentGroupsAsync(IIterable<String> names)
-->

# Windows.ApplicationModel.Package.StageContentGroupsAsync


## -description

Put the packages in the specified content groups into the staging queue.

## -parameters

### -param names

The names of the content groups to stage.

## -returns

A list of [PackageContentGroup](packagecontentgroup.md) objects for each content group specified by the _names_  parameter.

## -remarks

This function completes when all requested groups are staged. The returned list may contain a null element if the named group in that position does not exist. Use  [PackageCatalog.PackageContentGroupStaging](packagecatalog_packagecontentgroupstaging.md) to observe staging progress.

Be sure to check [PackageContentGroup.State](packagecontentgroupstate.md) to verify that the group was successfully staged. Referencing files in a group that is not fully staged may result in unexpected application behavior. Content groups return to the **PackageContentGroupState.NotStaged** state if the staging operation cannot be completed.

## -see-also

## -examples

