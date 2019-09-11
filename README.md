# Tutor Time

## What is Tutor Time?
TutorTime is a web app to handle tutor scheduling 

## Features
It has the following features:
- Ability to select a tutor for a given subject
- Ability to request a meeting with tutor at a certain time where there are no other meetings with the tutor over a sepcific topic. WHen you requets a meeting you have to specify your name and the topic you need help with - no login required
- Other people may either schedule their own appointments with tutor or, if they see someone else is going to tutor for help with a topic they also need help with, they can opt to "tag along" with that student. the interface will show a count of how many students are joining in for each session.

## Libraries Used
- Vue
- Swagger
- Asp.Net Core
- Entity Framework Core

## Useful Scripts

All of the below scripts can be executed in the terminal of your choice (PowerShell/Cmd on windows, Terminal on mac). 
They must be executed from the "Source" folder, where the .Net Core project/node package files are located.

__Front-end:__

* `npm install` - installs any missing npm dependencies. 
When in doubt, run this before any other front-end commands. If you get any errors with the other below commands, try running this first as well.

* `npm run dev` - compiles vue components into wwwroot/dist/app.css and wwroot/dist/app.js files
in development mode - non minified and more error information avaialble. 

* `npm run build` - compiles vue components into same files as above but in production mode - 
minified and with less error info available

* `npm run watch` - compiles vue components into same files as above in watch mode - whenever changes are made 
to the vue components and saved, files get recompiled.


__Back-end:__

* `dotnet run` - runs the backend ASP.Net Core app. This is handiest to use when you're working in VS Code on a mac. Running this will give you a url to browse to to view the running app.

* `dotnet ef migrations add "MigrationName"` - creates a new entity framework code first migration

* `dotnet ef database update` - applies any unapplied migrations to the database

* `dotnet ef migrations remove` - removes the most recent migration, as long as it has not been appleid to the database
