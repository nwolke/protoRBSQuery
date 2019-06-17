# Prototype for RBS Dataprovider and Request/Response objects

## Project breakdown:
### Common
This holds common classes that are shared across the projects, mostly the request/response objects, but also has the makeshift REST caller

### API
This is the web api project to simulate the service.
The ValuesController is left in it for the sake of showing default behavior of Controllers.

## DataProvider
This is the meat of it. Showing a very simplified version of how i envisioned the request/response objects to work against the 
dataprovider's query classes.
Also shows how the Autofac IOC works.

## Console
This is here merely to test calling the service like its the web project.

This will run but will return an exception message as I'm not connecting to a database and haven't finished the AccountPropertiesQuery class.
But you can see what is happening here.
I'll gladly go over this anytime if anyone has questions. I'm also not attached to this so we can dump this at any time.
