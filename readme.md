Created Project
## Run Project 
'dotnet run --project src/Gradebook'

## Restor the Packages
'dotnet restore src/GradeBook'

## pass args
dotnet run Hidayat

## Note 
var: var is used when u initialize directly

## Create Unit Test 
mkdir GradeBook.Tests

gradebook\test\GradeBook.Tests> dotnet new xunit

It will put the xUnit in the library
```csharp
// GradeBook.Test.csproj
<PackageReference Include="Microsoft.NET.Test.Sdk" Version="16.0.1" />
<PackageReference Include="xunit" Version="2.4.0" />
<PackageReference Include="xunit.runner.visualstudio" Version="2.4.0" />

```