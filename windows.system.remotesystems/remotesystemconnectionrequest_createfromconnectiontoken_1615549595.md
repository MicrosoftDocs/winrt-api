---
-api-id: M:Windows.System.RemoteSystems.RemoteSystemConnectionRequest.CreateFromConnectionToken(System.String)
-api-type: winrt method
---

<!-- Method syntax.
public RemoteSystemConnectionRequest RemoteSystemConnectionRequest.CreateFromConnectionToken(String connectionToken)
-->

# Windows.System.RemoteSystems.RemoteSystemConnectionRequest.CreateFromConnectionToken

## -description
Returns a RemoteSystemConnectionRequest based on a [ConnectionToken](remotesystemconnectionrequest_connectiontoken.md).

## -parameters
### -param connectionToken
The specific connection token for which the RemoteSystemConnectionRequest will be created with.

## -returns
An instance of the [RemoteSystemConnectionRequest](remotesystemconnectionrequest.md) class.

## -remarks
CreateFromConnectionToken requires the RemoteSystem capability on Windows, and it requires the RemoteSystem::RequestAccessAsync function to have been called previously. Calling without both of these permissions results in an exception. 

## -see-also
[ConnectionToken](remotesystemconnectionrequest_connectiontoken.md)
[CreateFromConnectionTokenForUser](remotesystemconnectionrequest_createfromconnectiontokenforuser_1550514484.md)
## -examples

