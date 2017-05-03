---
-api-id: M:Windows.Networking.Connectivity.NetworkInformation.GetConnectionProfiles
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.Collections.IVectorView<Windows.Networking.Connectivity.ConnectionProfile> GetConnectionProfiles()
-->

# Windows.Networking.Connectivity.NetworkInformation.GetConnectionProfiles

## -description
Gets a list of profiles for connections, active or otherwise, on the local machine.

## -returns
An array of [ConnectionProfile](connectionprofile.md) objects.

## -remarks
The following example demonstrates how to retrieve a [ConnectionProfile](connectionprofile.md). The function calls [getConnectionProfiles](networkinformation_getinternetconnectionprofile.md) to retrieve all available connections on a device and display using a list. Alternatively, your app can call [getInternetConnectionProfile](networkinformation_getinternetconnectionprofile.md) to retrieve the [ConnectionProfile](connectionprofile.md) representing the connection currently used for Internet connectivity.



```javascript
function DisplayConnectionProfileList() {
    var profileList = "";
    var ConnectionProfiles = networkInfo.getConnectionProfiles();
        if (ConnectionProfiles.length !== 0) {
            for (var i = 0; i < ConnectionProfiles.length; i++) {

                //Display Connection profile info for each profile by passing it
																//to a function that accesses and displays the connection properties
                profileList += getConnectionProfileInfo(ConnectionProfiles[i]);
                profileList += "-------------------------\n\r";
            }
            mySample.displayStatus(profileList);
        }
        else {
            mySample.displayStatus("No profiles found");
        }
    }

    catch (e) {
        mySample.displayError("Exception Caught: " + e + "\n\r");
    }
}
```



For additional examples of how [NetworkInformation](networkinformation.md) class methods are implemented to retrieve connection profiles, see [Quickstart: Retrieving network connection information](http://msdn.microsoft.com/library/ef383500-f2a9-4b93-8f6b-1f87560305d8).

## -examples

## -see-also
