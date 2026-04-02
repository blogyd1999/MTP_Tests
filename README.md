🧪 .NET 8 MTP Code Coverage Sample

This project demonstrates:

✅ Using Microsoft Testing Platform (MTP)
✅ Multiple source projects
✅ Multiple test projects
✅ Code coverage using coverlet.collector
✅ Merging reports using reportgenerator

-------------------------------------------------------------------------------
Folder Structure:

MtpTests/
│
├── .github/
│   └── workflows/
│       └── dotnet-ci.yml   ✅ (HERE)
│
├── MtpTests.Core/
├── MtpTests.Utils/
├── MtpTests.CoreTests/
├── MtpTests.UtilsTests/
│
├── coverage.runsettings
├── MtpTests.sln
└── README.md

------------------------------------------------------------------------
⚙️ Prerequisites
.NET SDK 8+
macOS / Linux / Windows
Install ReportGenerator tool:
dotnet tool install -g dotnet-reportgenerator-globaltool

------------------------------------------------------------------------
🚀 Setup Project (From Scratch)
1. Create Solution
mkdir MtpTests
cd MtpTests

dotnet new sln -n MtpTests
2. Create Source Projects
dotnet new classlib -n MtpTests.Core
dotnet new classlib -n MtpTests.Utils

Add to solution:

dotnet sln add MtpTests.Core/MtpTests.Core.csproj
dotnet sln add MtpTests.Utils/MtpTests.Utils.csproj
3. Create Test Projects
dotnet new xunit -n MtpTests.CoreTests
dotnet new xunit -n MtpTests.UtilsTests

Add to solution:

dotnet sln add MtpTests.CoreTests/MtpTests.CoreTests.csproj
dotnet sln add MtpTests.UtilsTests/MtpTests.UtilsTests.csproj
4. Add Project References
dotnet add MtpTests.CoreTests reference MtpTests.Core
dotnet add MtpTests.UtilsTests reference MtpTests.Utils
5. Enable Microsoft Testing Platform (MTP)

Add this to BOTH test projects (.csproj):

<PropertyGroup>
  <TargetFramework>net8.0</TargetFramework>
  <UseMicrosoftTestingPlatform>true</UseMicrosoftTestingPlatform>
</PropertyGroup>
6. Add Coverage Collector
dotnet add MtpTests.CoreTests package coverlet.collector
dotnet add MtpTests.UtilsTests package coverlet.collector

7. Create coverage.runsettings in root:

------------------------------------------------------------------------
✅ Useful Commands (Quick Reference)
# Run tests with coverage
dotnet test --settings coverage.runsettings

# Merge reports
reportgenerator \
-reports:"**/coverage.cobertura.xml" \
-targetdir:"coverage-report" \
-reporttypes:Html

