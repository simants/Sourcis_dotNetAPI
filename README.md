# CRUD API implementation in .Net

## API's to perform CRUD operations on Car and Person table.

### Requirement:

### Version:
    dotnet >= 6.0.411

### Packages:
    Microsoft.AspNetCore.Mvc;
    Microsoft.EntityFrameworkCore.InMemory

### API Description:
    
### **Car:**
    This table has following car information : make, model and year.
    This table has 5 API's: 
    1. Display all the data. 
    2. Fetch car details using id. 
    3. Add new car record.
    4. Update car record using id.
    5. Delete car record using id.

        ```http GET /api/car/```
| Parameter | Type | Description |
| :--- | :--- | :--- |
| `NA` | `NA` | Display all records in the Car table. |

        ```http POST /api/car/```
| RequestBody | Type | Description |
| :--- | :--- | :--- |
| `id`| `auto-increment` | Insert new record in the Car table. |
|`make`| `string` |
|`model`| `string` |
|`year` | `int` | |
        
        ```http GET /api/car/{id}```
| Parameter | Type | Description |
| :--- | :--- | :--- |
| `id` | `int` | **Id Required**. Fetch record by id from the Car table. |

        ```http PUT /api/car/{id}```
| Parameter | Type |RequestBody | Type | Description |
| :--- | :--- | :--- | :--- | :--- |
| `id` | `int` | `id`| `int` | **Id Required**. Update existing record in the Car table. |
| | |`model`| `string` |
| | |`make`| `string` |
| | |`year` | `int`    |

        ```http DELETE /api/car/{id}```
| Parameter | Type | Description |
| :--- | :--- | :--- |
| `id` | `int` | **Id Required**. Delete record by id from the Car table. |






### **Person:**
    This table has following person information : name, gender and age.
    This table has 5 API's: 
    1. Display all the data. 
    2. Fetch person details using id. 
    3. Add new person record.
    4. Update person record using id.
    5. Delete person record using id.

            ```http GET /api/person/```
| Parameter | Type | Description |
| :--- | :--- | :--- |
| `NA` | `NA` | Display all records in the Person table. |

        ```http POST /api/person/```
| RequestBody | Type | Description |
| :--- | :--- | :--- |
| `id`| `auto-increment` | Insert new record in the Person table. |
|`name`| `string` |
|`gender`| `string` |
|`age` | `int` | |
        
        ```http GET /api/person/{id}```
| Parameter | Type | Description |
| :--- | :--- | :--- |
| `id` | `int` | **Id Required**. Fetch record by id from the Person table. |

        ```http PUT /api/person/{id}```
| Parameter | Type |RequestBody | Type | Description |
| :--- | :--- | :--- | :--- | :--- |
| `id` | `int` | `id`| `int` | **Id Required**. Update existing record in the Car table. |
| | |`name`| `string` |
| | |`gender`| `string` |
| | |`age` | `int`    |

        ```http DELETE /api/person/{id}```
| Parameter | Type | Description |
| :--- | :--- | :--- |
| `id` | `int` | **Id Required**. Delete record by id from the Person table. |





