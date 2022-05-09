# ef-core-learning

A sample app containing a pet-related API, with the purpose of me learning entity framework.

## Getting started
1. Run `docker-compose rm -f && docker-compose up --build --renew-anon-volumes` from the repository root.
2. Apply db migrations (see below)
3. Make some requests!
   - `curl https://localhost:8001/weatherForecast`

**Note** that you must have a self-signed certificate available in `~/.aspnet/https/aspnetapp.pfx`. It must be in pfx-format and it must contain a private key.

In order to get a self-signed certificate that my OS (Arch Linux) trusts, I used one of the scripts [here](https://github.com/BorisWilhelms/create-dotnet-devcert/tree/main/scripts). After running the script, you may export the self-signed certificate by running `dotnet dev-certs https -ep ${HOME}/.aspnet/https/aspnetapp.pfx -p ""`.

For Mac or Windows you should just be able to use the `dotnet dev-certs https` command:
 - `dotnet dev-certs https -ep ${HOME}/.aspnet/https/aspnetapp.pfx -p ""`
 - `dotnet dev-certs https --trust`

## Make db schema changes
1. Make desired changes to models or db context
2. Start the local database using `docker-compose rm -f && docker-compose up --build --renew-anon-volumes`
3. Generate migration script for new change:

```
DB_CONNECTION_STRING="host=localhost:8002;database=petio;user id=super-user;password=super-secret;" \
   dotnet ef migrations add NAME-OF-MY-MIGRATION 
```

4. Verify that you have pending migration(s):
```
DB_CONNECTION_STRING="host=localhost:8002;database=petio;user id=super-user;password=super-secret;" \
   dotnet ef migrations list 
```

5. Apply migration(s):
```
DB_CONNECTION_STRING="host=localhost:8002;database=petio;user id=super-user;password=super-secret;" \
   dotnet ef database update 
```

6. If you need to rollback migration(s):
```
DB_CONNECTION_STRING="host=localhost:8002;database=petio;user id=super-user;password=super-secret;" \
   dotnet ef database update NAME-OF-MIGRATION-TO-ROLLBACK-TO
```

7. If you want to remove last migration:
```
DB_CONNECTION_STRING="host=localhost:8002;database=petio;user id=super-user;password=super-secret;" \
   dotnet ef migrations remove
```

Note that you must have Entity Framework CLI Tools installed for this.