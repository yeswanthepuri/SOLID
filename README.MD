SOLID - 
S - Single responsibility 
O - Open&Close 
L - Liskov substitution 
I - Interface segregation  
D - Dependency inversion

Open and close Principle shoud be open for extension and close for modification


Adding project to the solution in cli 
dotnet sln SOLID/SOLID.sln add SOLID/OCPLibrary/OCPLibrary.csproj

adding project reference to Another project
dotnet add SOLID/SOLIDPrinciple/SOLIDPrinciple.csproj reference SOLID/OCPLibrary/OCPLibrary.csproj