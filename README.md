WebApi
dotnet new classlib - n nome_da_biblioteca

dotnet new sln -n nome_da_solucao

dotnet new webapi -n nome_web_api

Adicionando referencias
    dotnet add .\DalPiaz.Repository\DalPiaz.Repository.csproj reference .\DalPiaz.Domain\DalPiaz.Domain.csproj

    dotnet add .\DalPiaz.API\DalPiaz.API.csproj reference .\DalPiaz.Domain\DalPiaz.Domain.csproj

    dotnet add .\DalPiaz.API\DalPiaz.API.csproj reference .\DalPiaz.Repository\DalPiaz.Repository.csproj

Adicionando todos os projetos a solucao
    dotnet sln .\DalPiaz.sln add .\DalPiaz.API\DalPiaz.API.csproj .\DalPiaz.Domain\DalPiaz.Domain.csproj .\DalPiaz.Repository\DalPiaz.Repository.csproj

Deletar todos os bin e obj de todos os projetos e dar um dotnet build em seguida NO DIRETÓRIO raiz

Para criar as migrations devemos referenciar o projeto API principal 
    dotnet ef --startup-project ..\DalPiaz.API\ migrations add init
    dotnet ef --startup-project ..\DalPiaz.API\ database drop
    dotnet ef --startup-project ..\DalPiaz.API\ database update
__________________________________________
Para definir chaves compostas
modelBuilder.Entity<PalestranteEvento>().HasKey(PE => new {PE.EventoId, PE.PalestranteId});
__________________________________________
Angular

npm install -g @angular/cli
ng new my-dream-app
cd my-dream-app
ng serve