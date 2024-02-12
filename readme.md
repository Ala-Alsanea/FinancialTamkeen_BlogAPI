
## This code is part of the project "FinancialTamkeen_BlogAPI".
## It performs a specific task related to the project.

# Author: [Ala Alsanea]
# Date: [12-FEB-2024]
------
# Requairment
    - ## dotnet 6

------------
# Usage:
    - Dependency setup
```
dotnet add package Microsoft.EntityFrameworkCore --version 6.0.2 
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 6.0.2
dotnet add package Microsoft.EntityFrameworkCore.Design --version 6.0.2
dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 6.0.2

dotnet tool install --global dotnet-ef

dotnet add package AutoMapper --version 13.0.1
dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection --version 12.0.1
```
    - run test to use `swagger`
```
dotnet watch run
```
# endpoints:

    - api/Product/all
        return all products

    - api/Product/{id}
        return a single product by id

    - api/Product/create
        it create product with following keys:
            - "name": string,
            - "description": string,
            - "price": decimal,
            - "quantityInStock": int

    - api/Product/{id}/update
        it update a single product with following keys:
            - "name": string,
            - "description": string,
            - "price": decimal,
            - "quantityInStock": int






