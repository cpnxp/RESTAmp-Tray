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

### Licence - MIT
Copyright 2017 CPNXP

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
