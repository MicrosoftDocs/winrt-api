---
-api-id: M:Windows.System.RemoteSystems.RemoteSystemConnectionRequest.CreateFromConnectionTokenForUser(Windows.System.User,System.String)
-api-type: winrt method
---

<!-- Method syntax.
public RemoteSystemConnectionRequest RemoteSystemConnectionRequest.CreateFromConnectionTokenForUser(User user, String connectionToken)
-->

# Windows.System.RemoteSystems.RemoteSystemConnectionRequest.CreateFromConnectionTokenForUser

## -description
Returns a RemoteSystemConnectionRequest based on a [ConnectionToken](remotesystemconnectionrequest_connectiontoken.md) and a specific [user](user.md).

## -parameters
### -param user
The specific User for which the RemoteSystemConnectionRequest will be created for.

### -param connectionToken
The specific connection token for which the RemoteSystemConnectionRequest will be created with.

## -returns
An instance of the [RemoteSystemConnectionRequest](remotesystemconnectionrequest.md) class.

## -remarks
CreateFromConnectionTokenForUser requires the RemoteSystem capability on Windows, and it requires the RemoteSystem::RequestAccessAsync function to have been called previously. Calling without both of these permissions results in an exception. 

## -see-also
[ConnectionToken](remotesytemconnectionrequest_connectiontoken.md)
[CreateFromConnectionToken](remotesytemconnectionrequest_createfromconnectiontoken.md)
## -examples

