
FROM agustinsilvanoatt/dotnet-refresh:v2


# Set a working dir at least 2 deep. The output and intermediate output folders will be /code/obj and /code/bin
WORKDIR /code/app

# By copying these into the image when building it, we don't have to re-run restore everytime we launch a new container
COPY Angular4KickOffBE.csproj .

RUN dotnet restore
