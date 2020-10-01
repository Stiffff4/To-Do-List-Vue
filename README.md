# To-Do-List-Vue

Another To-Do List application made with VueJS (front-end), .net core (web API, back-end) and SQLServer for the database.

## Description

A simple To-Do List application in which you can add a todo, mark it as completed and deleting it.

- By writing on the bar and then clicking submit or pressing "enter", you can add a new todo.
- By clicking on the todo, you can mark it as completed. By clicking it again, you can undo this.
- By clicking on the "trash" icon, you can delete it.

## Instalation

Vue libraries used:

```
npm i vuex
npm i axios
npm i vue-swal
```

SQL Script(s):

"todos" table:
```sql
CREATE TABLE todos (
id int primary key identity(1, 1),
title nvarchar(50) not null,
completed bit not null,
deleted bit not null
)
```

### Reminder

You have to change the localhost url (from the api) in todos.js
```javascript
const url = 'your url here'
```

You have to change the connection string in TodosContext.cs (in the api)
```csharp
private string constring = "Data Source=[yours here];Initial Catalog=todo;Integrated Security=True";
```
