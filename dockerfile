# Use the official Microsoft Windows Server Core image as the base image
FROM mcr.microsoft.com/dotnet/framework/runtime:4.8

# Set the working directory inside the container
WORKDIR /app

# Copy the entire project (source code and files) into the container's working directory
COPY . .

# Install .NET Framework SDK (if you need to build the project from source)
# Optionally, you can choose to copy over the pre-built output if you prefer not to build inside the container
RUN powershell -Command \
    Install-WindowsFeature -Name Web-Server; \
    Install-WindowsFeature -Name Web-WebServer

# Command to run your app (assuming the project is built and output is .exe)
CMD ["PopulationReportingSystem.exe"]
