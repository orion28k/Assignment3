Assignment 3 – MongoDB Connector with Testcontainers

Andre Davis
CSCI-487-01-F2F-FALL25

⸻

Overview

This project was developed as part of Assignment 3 in Software Design. The objective was to gain familiarity with Docker, database connectivity, and automated testing in C#. Specifically, the task involved creating a class library to establish a connection to MongoDB, implementing a method to ping the database, and verifying the functionality through unit testing with xUnit and Testcontainers.

⸻

Implementation

MongoDBConnector Class

The MongoDBConnector class provides a constructor that accepts a connection string (and optionally a database name) and initializes a MongoDB client. It contains the method:
	•	PingMongoDB(): Executes the MongoDB { ping: 1 } command and returns a boolean indicating whether the database responded successfully. Error handling ensures the method returns false if the connection fails.

Unit Tests

Two unit tests were implemented using xUnit in combination with Testcontainers to provision ephemeral MongoDB instances during testing:
	1.	Success Case
	•	Valid connection string with an active container.
	•	Verifies that PingMongoDB() returns true.
	2.	Failure Case
	•	Invalid connection string (wrong host/port).
	•	Verifies that PingMongoDB() returns false.

Together, these tests confirm that the connector handles both valid and invalid connections appropriately.
