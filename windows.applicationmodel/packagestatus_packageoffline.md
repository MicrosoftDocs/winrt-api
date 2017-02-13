---
-api-id: P:Windows.ApplicationModel.PackageStatus.PackageOffline
-api-type: winrt property
---

<!-- Property syntax
public bool PackageOffline { get; }
-->

# Windows.ApplicationModel.PackageStatus.PackageOffline

## -description
Indicates whether the package is offline and cannot be used.

## -property-value
**TRUE** indicates that the package is offline; otherwise **FALSE**.

## -remarks
A package is offline if any of the package's files are installed on a volume that is currently offline or cannot be accessed. For example, the package's files may have been installed on removable media that is no longer online.

## -examples

## -see-also
