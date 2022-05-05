# ef-core-learning

A sample app containing a pet-related API, with the purpose of me learning entity framework.

## Getting started
1. Run `docker-compose up` from the repository root.
2. Make some requests!
   - `curl https://localhost:8001/weatherForecast`

**Note** that you must have a self-signed certificate available in `~/.aspnet/https/aspnetapp.pfx`. It must be in pfx-format and it must contain a private key.

In order to get a good certificate that my OS (Arch Linux) trusts, I used one of the scripts [here](https://github.com/BorisWilhelms/create-dotnet-devcert/tree/main/scripts). I did a slight modification of it in order to obtain a pfx-file that contains a private key.

For Mac or Windows you should be able to use the `dotnet dev-certs https` command:
 - `dotnet dev-certs https -ep ${HOME}/.aspnet/https/aspnetapp.pfx`
 - `dotnet dev-certs https --trust`