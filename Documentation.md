# Burrito API
## an api for portland burrito reviews
_by Noah Kise, Ravin Fisher, & Gabriel Tucker_

Base URL: localhost:5001/api

This API is designed to find and display burritos in Portland, and see their ratings and reviews.

### Endpoints

```
GET https://localhost:5001/api/burritos/
GET https://localhost:5001/api/burritos/{id}
POST https://localhost:5001/api/burritos/
PUT https://localhost:5001/api/burritos/{id}
DELETE https://localhost:5001/api/burritos/{id}
```
* Note: the `{id}` in the URL is a variable and should be replaced with the id of the burrito a user wants to access.

 -   A GET endpoint at https://localhost:5001/api/burritos will return all burrito objects.
 -   A GET endpoint at https://localhost:5001/api/burritos/{id} will return one burrito object based on its BurritoId property.
 -   A POST endpoint at https://localhost:5001/api/burritos will add a new burritos to our database and requires a request body with an object literal of a burrito.
 -   A PUT endpoint at https://localhost:5001/api/burritos/{id} will edit the object in entired based on it's BurritoId property
 -   A DELETE endpoint at  https://localhost:5001/api/burritos/{id} will delete the object based on its BurritoId property

### Optional Query String Parameters for GET Request
#### These query strings are a way to filter the burrito objects
| Parameter   | Type        |  Required    | Description |
| ----------- | ----------- | -----------  | ----------- |
| Protein     | String      | not required | Returns buritos containing the input protein |
| MaxPrice        | Double      | not required | Returns burritos with a rating less than or equal to the input price |
| MinRating  | Double      | not required | Returns burritos with a rating greater than or equal to the input rating |
| Random  | Boolean      | not required | Returns a random burrito |
| Page  | Integer      | not required | Sets the page number, defaults to 1 |
| PageSize | Integer | not required | Sets the number of results per page, defaults to four |
#### Example Query



The following query will return all burritos with the protein "Beef":

```
GET https://localhost:5001/api/Burritos?protein=Beef
```
It's possible to include multiple query strings by separating them with an `&`:

```
GET https://localhost:5001/api/Burritos?protein=Beef&maxPrice=10
```
### Additional requirements for PUT request
When making a PUT request to `https://localhost:5001/api/Burritos/{id}`, you need to include a **body** that includes the burrito's `burritoId` property. Here's an example body in JSON:

```json
{
  "burritoId": 1,
  "name": "string",
  "price": "string",
  "location": "string",
  "protein": "string",
  "review": "string",
  "imageUrl": "string",
  "user": "string",
  "rating": 10
},
```

And here's the PUT request we would send the previous body to:

```
https://localhost:5001/api/burritos/1
```

Notice that the value of `BurritoId` needs to match the id number in the URL. In this example, they are both 1. For put and delete requests, the value of `user` must match the value of user in the database for that instance of a burrito.