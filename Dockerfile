
FROM mcr.microsoft.com/dotnet/core/sdk:3.1

ENV PROJECT=WEBAPP

# Required inside Docker, otherwise file-change events may not trigger
ENV DOTNET_USE_POLLING_FILE_WATCHER 1

#Configure ASPNET env, ports and urls.
ENV ASPNETCORE_ENVIRONMENT Development
ENV ASPNETCORE_URLS https://+;http://+;
ENV ASPNETCORE_HTTPS_PORT 44311

# Set a working dir at least 2 deep. The output and intermediate output folders will be /code/obj and /code/bin
WORKDIR /code/app


# By copying these into the image when building it, we don't have to re-run restore everytime we launch a new container
COPY ./*.sln	./
COPY ./*/*.csproj ./
RUN for file in $(ls *.csproj); do mkdir -p ./${file%.*}/ && mv $file ./${file%.*}/; done
RUN dotnet restore


# This will build and launch the server in a loop, restarting whenever a *.cs file changes
ENTRYPOINT dotnet watch --project ${PROJECT} run --no-restore
