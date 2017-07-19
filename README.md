#  Interview task

My Application is divided in 4 different layers.

Client- portable project that consumes the API and uses the result of its endpoints

Api-a separate codebase that can be consumed from multiple clients(Mobile, Web, Windows services). In my case the api is REST api. It can be hosted in IIS and freely accessed from all the clients that  I have not implemented authentication but my next step( if the time allows) would have been to implement token based authentication.

Business layer-Using the data repositories to fetch the data and perform some calculations, if necessary.

Data Layer- Using Entity Framework - Code First Approach. It gives the ability to easily, based on the current entities, to generate database and tables and the relations between them. I chose EF as ORM  because this is a light application and EF provides quick implementation of all the CRUD operations. Ideally, in case of huge applications that need to be high performant I would prefer writing stored procedures and using them for the CRUD operations because EF sometimes generates unnecessary sql code which decreases the performance.

I used abstraction and inheritance for implementing the base repository contracts
There is configuration that specifies the connection string for EF. Also, I use another configuration to specify the API url that the client needs to request.

I wrote couple of unit tests that verify the code test cases.Each layer has its own unit testing project. In terms of improvement I can write integration tests as well, verifying that the integration between different components(layers) works.
