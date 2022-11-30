Author: Conner Houchin

The application was tested using windows

It allows a user to enter strings of any length, and as soon as a series of consecutive integers (with any of non int characters separating them) are found (whether from 
the same or different strings) that correspond to either the lock or unlock code (187381 & 187384) the safe will change states and output a message if it isn't already in that state

In order to generate unit test coverage, you will need to first install dotnet coverage using
  dotnet tool install -g dotnet-coverage
Then you will run the command 
  dotnet-coverage collect -f xml -o coverage.xml dotnet test unittesting
from the root folder. This will run the tests and generate a coverage.xml file that you can open to see the unit coverage

In order to compile the program you will need to navigate to the file which contains the dotnet framework, likely
  C:\Windows\Microsoft.NET\Framework\v4.0.30319
and run 
 csc /out:"(Destination you'd like the executable to be saved)" "C:\.....\SafeApplication\SafeApplication\program.cs" "C:\.....\SafeApplication\SafeApplication\safe.cs"
