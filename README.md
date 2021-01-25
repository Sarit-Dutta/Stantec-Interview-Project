# Telehealth COVID-19 Health Project

Welcome to the TeleHealth COVID-19 Application that allows employees to make use of a windows form application in order to submit client data to an in-house API from where the data can be observed within an in-house Angular 9 Web Client by a supervisor after logging in. Both the application and web client require authentication to be used.

## Getting started

Firstly ensure that .NET is installed on your local machine, else you will not be able to begin execution of either the Windows Form Application or the Web API.

.NET Framework can be installed from: https://dotnet.microsoft.com/download/dotnet-framework

And additional packages can be added either by installing from the Visual Studio NuGet Package Manager or via the terminal/command prompt using the command:

`dotnet add package [insert package name here]`

The admin account used to access the Web Client uses the below credentials:

```
username: admin
password: admin
```

The employee account will use the credential:

```
username: John
password: Doe
```

## Starting the API

The first step in order to get started is to enable the .NET and EF Core API that has been built. In order to do so, follow the below steps.

1. Open Command prompt or the terminal
2. Navigate to the folder containing the API files, ie. /TeleHealth_API
3. Run this command in the terminal:
   `dotnet run start`

Now we can move onto the next step once the API is actively awaiting requests.

## Starting the Windows Form Application

The files and code for the Windows Form Application are kept within the TeleHealthApplication folder.

For execution however, the only step that is required for execution of the application is clicking on the file:
`TeleHealthApplication.application`

A brief window will appear that will check connection and install if not done already. After this, the login dialog box will open and users may proceed to log in and submit client records into the Data form that opens next.

## Starting the Web Client

THe Web client will require the appropriate npm packages to run correctly on the browser of your choice.

Firstly install node or npm from https://nodejs.org/en/ if not already installed on your device.

Once done, simply follow the steps below. As such the steps required to get it running are as below:

1. Open terminal/command prompt.
2. Navigate to the folder containing the Web Client, ie. /TeleHealthWebClient
3. Use the following command to install the required npm packages: `npm install`
4. Once all the packages have been installed, use the following command to run the web client:
   `ng serve --open`

The `--open` command will open up the web client in a tab on your default browser. From there an admin account may log in and review all the client records.

### Additional features:

The Client will not permit access to the client route unless authorization has been provided from the authorization service.

The client records display page also contains a refresh button that will get the list of records from the API if the page is open and repopulate. The logout button on this page will also reroute the users to the login page, requiring users to input credentials once again.
