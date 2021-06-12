# Parks.Solution

## A backend api that lets user create/read/update/delete parks

#### By Nick Reeder

[![Build Status](https://travis-ci.org/joemccann/dillinger.svg?branch=master)](https://travis-ci.org/joemccann/dillinger)

## Technologies Used

- c#
- .Net
- Entity
- MVC architecture
- ASP.NET
- EF Core

# Get Started

- Open your favorite Terminal

## Installation

```sh
git clone https://github.com/reeder32/Parks.Solution.git
```

##### Open in VS Code

```sh
cd PierresBakery.Solution
code .
```

**IMPORTANT**

1. In the root folder create a file 'appsettings.json'
2. Copy text below:

```sh
{
  "ConnectionStrings" : {
    "DefaultConnection" : "Server=localhost;Port=3306;database=nick_reeder;uid=root;pwd=epicodus;"
  }
}
```

---

**FYI**
If the below command doesn't work, you may not have dotnet -ef command available yet...

```sh
dotnet tool install --global dotnet-ef
```

---

```sh
dotnet ef database update
```

#### Start Server

```sh
cd PierresBakery
dotnet run
```

## How to consume api

1. Open [Postman](https://www.postman.com/downloads/)

- Get all Parks

  - Method: GET
  - http://localhost:5000/api/parks

- Get Park by id

  - Method: GET
  - http://localhost:5000/api/parks/{id}

- Post a new park
  ** Method: POST
  ** http://localhost:5000/api/parks
  \*\*\* pass in body, json object like this:

```sh
{
  "name": "Volcano National Park",
  "state": "Hawaii",
  "city": "Hawaii National Park,",
  "zipCode": "96715",
  "type": "National"
}
```

- Update park
  - Method: PUT
  - http://localhost:5000/api/parks/{id}
    \*\*\* pass in body, json object like this:

```sh
{
  "name": "Volcano National Park",
  "state": "Hawaii",
  "city": "Hawaii National Park,",
  "zipCode": "96718",
  "type": "National"
}
```

- Delete park
  - Method: Delete
  - http://localhost:5000/api/parks/{id}

## License

[MIT License](https://opensource.org/licenses/MIT)
&copy; 2021 Nick Reeder

## Contact Information

[email me](mailto:nickreeder32@gmail.com)

### Other projects

#### iOS work

- [Moody Weather](https://apps.apple.com/us/app/moody-weather/id1506337317)

- [Find My Mailbox](https://apps.apple.com/us/app/find-my-mailbox/id1530700085)
