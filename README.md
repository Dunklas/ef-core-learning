# ef-core-learning

A sample app containing a pet-related API, with the purpose of me learning entity framework.

## Run HTTPS from docker

While running the dotnet I use a self signed certificate (from `dotnet dev-certs https`) in order to make requests using HTTPS.
To have this working from Docker, I use a volume to mount a directory containing my certificate.

The certificate must: (1) be in pfx-format; (2) contain private key; (3) exist in path `~/.aspnet/https/aspnetapp.pfx`.

In order to get a good certificate that my OS trusts, I used one of the scripts [here](https://github.com/BorisWilhelms/create-dotnet-devcert/tree/main/scripts). I did a slight modification of it in order to obtain a pfx-file that contains a private key.