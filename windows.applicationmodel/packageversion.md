---
-api-id: T:Windows.ApplicationModel.PackageVersion
-api-type: winrt struct
---

<!-- Structure syntax.
public struct PackageVersion 
-->

# PackageVersion

## -description
Represents the package version info.

## -struct-fields

### -field Major
The major version number of the package.
    
### -field Minor
The minor version number of the package.

### -field Build
The build version number of the package.

### -field Revision
The revision version number of the package.

## -remarks

## -examples
Use the [Package.Current](package_current.md) property to get the package for the current app. Use the [Package.Id](package_id.md) property to get the package ID, from which you can then get the version.

```javascript
var package = Windows.ApplicationModel.Package.current;
var packageId = package.id;
var version = packageId.version;
```

```csharp
using Windows.ApplicationModel;

Package package = Package.Current;
PackageId packageId = package.Id;
PackageVersion version = packageId.Version;
```

```vb
Dim package As Windows.ApplicationModel.Package = Windows.ApplicationModel.Package.Current
Dim packageId As Windows.ApplicationModel.PackageId = package.Id
Dim version As Windows.ApplicationModel.PackageVersion = packageId.Version
```

```cppwinrt
Windows::ApplicationModel::Package package{ Windows::ApplicationModel::Package::Current() };
Windows::ApplicationModel::PackageId packageId{ package.Id() };
Windows::ApplicationModel::PackageVersion version{ packageId.Version() };
```

```cppcx
Windows::ApplicationModel::Package^ package = Windows::ApplicationModel::Package::Current;
Windows::ApplicationModel::PackageId^ packageId = package->Id;
Windows::ApplicationModel::PackageVersion version = packageId->Version;
```

## -see-also
[PackageId.Version](packageid_version.md)