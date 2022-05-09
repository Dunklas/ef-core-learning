# ef-core-learning

A sample app containing a pet-related API, with the purpose of me learning entity framework.

## Getting started
1. Run `docker-compose up` from the repository root.
2. Make some requests!
   - `curl https://localhost:8001/weatherForecast`

**Note** that you must have a self-signed certificate available in `~/.aspnet/https/aspnetapp.pfx`. It must be in pfx-format and it must contain a private key.

In order to get a self-signed certificate that my OS (Arch Linux) trusts, I used one of the scripts [here](https://github.com/BorisWilhelms/create-dotnet-devcert/tree/main/scripts). After running the script, you may export the self-signed certificate by running `dotnet dev-certs https -ep ${HOME}/.aspnet/https/aspnetapp.pfx -p ""`.

For Mac or Windows you should just be able to use the `dotnet dev-certs https` command:
 - `dotnet dev-certs https -ep ${HOME}/.aspnet/https/aspnetapp.pfx -p ""`
 - `dotnet dev-certs https --trust`

## Make db schema changes
1. Make desired changes to models or db context
2. Run `dotnet ef migrations add NameOfMyMigration`
3. Run `dotnet ef database update`

Note that you must have Entity Framework CLI Tools installed for this.