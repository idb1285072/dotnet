## Model View Controller

## Controller

- Receives HTTP request data
- Invoke business model to execute business logic

## Business Model

- Receives input data from the controller
- Performs business operations such as retrieving/ inserting data from database
- Sends data of the database, back to the controller

## Controller

- Creates object of ViewModel and fills data into its properties
- Selects a View and invoke it and also pass the object of ViewModel to the view

## View

- Receives the object of ViewModel from the controller
- Accesses properties of ViewModel to render data in html code
- After the view renders, the renderer view result will be sent as response

## Rule

- Each component (model, view and controller) performs single responsibility
- Identifying and fixing errors will be easy
- Each component (model, view and controller) can be developed independently
- In practical, both view and controller depend on the model. Model doesn't depend on neither view nor the controller. This is one of the key benefits of the clean separation. This separation allows the model to be built and tested independently
- Unit testing each individual component easier
