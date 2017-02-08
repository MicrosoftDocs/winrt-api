---
-api-id: T:Windows.ApplicationModel.PackageContentGroupState
-api-type: winrt enumeration
---

<!-- Enumeration syntax.
public enum PackageContentGroupState : int {
	Queued = 1
	NotStaged = 0
	Staged = 3
	Staging = 2
}
-->

# Windows.ApplicationModel.PackageContentGroupState

## -description
Describes the download state of the package content group.

## -enum-fields

## -field Staging:2
The package group is currently being downloaded.

## -field Staged:3
The package group has been downloaded.

## -field NotStaged:0
The package group has not been downloaded and is not in the download queue.

## -field Queued:1
The package has not been downloaded but is in the download queue.

## -remarks

## -see-also

## -examples
