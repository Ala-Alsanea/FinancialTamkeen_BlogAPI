## The practical exam "FinancialTamkeen_BlogAPI"

* Author: Ala Alsanea
* Date: 12-FEB-2024

## Requairment

* dotnet 6

## Usage:

* Dependency setup

```
dotnet add package Microsoft.EntityFrameworkCore --version 6.0.2 
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 6.0.2
dotnet add package Microsoft.EntityFrameworkCore.Design --version 6.0.2
dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 6.0.2

dotnet tool install --global dotnet-ef

dotnet add package AutoMapper --version 12.0.1
dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection --version 12.0.1
```

* run test to use `swagger or postman`

```
dotnet watch run
```

# endpoints:

* ### User (Auth)
  * `Post` api/user/login
    * "userName": "string"
    * "password": "string"
   
  * `Post` api/user/signup
    - "userName": "string"
    - "password": "string"
    - "email": "string"
    - "phoneNumber": "string"
  
* ### Product
  * `Get` api/Product/all `return all products`
  * `Get` api/Product/{id}: `return a single product by id`
  * `Post` api/Product/createit: `create product with following keys:`

    - "name": string,
    - "description": string,
    - "price": decimal,
    - "quantityInStock": int

  * `Put` api/Product/{id}/update: `it update a single product with following keys:`
    - "name": string,
    - "description": string,
    - "price": decimal,
    - "quantityInStock": int
