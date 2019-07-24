# RestAMP - WinAmp REST harness
This application is a simple REST harness for the WinAmp media player.  Requires admin rights if a url reservation is not done with netsh in advance.

### Endpoints
* /restamp/play
* /restamp/pause
* /restamp/prev
* /restamp/next
* /restamp/status

### URL Reservation
With an Admin Command Prompt you can run the following command to allow a non-admin user rights to run RestAmp.

`netsh http add urlacl url=http://+:8000/restamp user=DOMAIN\user`

DOMAIN can be an AD Domain or the local computer name.
