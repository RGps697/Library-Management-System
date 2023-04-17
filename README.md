# Library Management System

This project is a monolithic application dedicated for company book libraries, storing data about books, users, their borrowings and custom exams. It comes with access control based on built-in privileges (Patron, Librarian, Examiner, Manager, Administrator) and customizable roles.

## Getting Started

### Prerequisites

.NET 6 Runtime
[https://dotnet.microsoft.com/en-us/download/dotnet/6.0](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)<br/>
MongoDB 5.0.9
[https://www.mongodb.com/download-center/community/releases](https://www.mongodb.com/download-center/community/releases)

### Installing

1. Run .exe file
```
First run demands configuring application before it's ready to use
```
2. Enter database credentials
```
In dialog window enter database credentials. For local machine consider following:
- Ip: 127.0.0.1
- Port: 27017
- User name & password: your database user credentials (leave blank for no user)
```
3. Create root administrator
```
In dialog window enter credentials for root administrator, which will be used for later configurations
```
4. Done
```
Now create roles, books and users
```

## Tests

Solution contains project with automated tests created in the [NUnit](https://nunit.org/) framework.

## Further development

This application should be recreated as Web Api to eliminate drawbacks and allow more flexibility
