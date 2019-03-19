# Experiencing-SmartBlazor
Investigation of  Issue [#8623](https://github.com/aspnet/AspNetCore/issues/8623) 
## Description 
### Http.PostJsonAsync\<T> throw exception when passing an object with DateTime property.
When I pass my object which has the DateTime Property, It throws exception. But it also send data to api and the records are inserted in database.
For all other objects it works fine. But for this object which has a Nullable DateTime property it throws exception.

>The Model is valid, before passing it to the method.

When I handle it in try catch block and print the ex.Message to console it prints *WASM: Invalid JSON string.*
> ### For more details see issue [#8623](https://github.com/aspnet/AspNetCore/issues/8623)

## Instructions
1. Open \SmartLearning\SmartLearning.Server\appsettings.json
1. Enter a valid database connection for ``` LocalConnection:```
1. Restore Nuget Packages
1. Build the solution.
> Make sure all the projects build successfully
1. Run the **SmartLearning.Server** project.
> Once the project runs in the browser
1. Click on **Student** in left navigation menu.
1. Click on **New Student** button on top-left corner of the page, *A model dialog will popup.*
1. Enter Some test data.
1. Click on **Save** button in bottom-left corner of the model.
1. Press **F12** on your keyboard to open you developer tool in brower *i.e Chrome*
1. Click on console tab *if it is not already in console.*
>***Now You Should See The Error***
