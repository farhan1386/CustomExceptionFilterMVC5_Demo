# Custom ExceptionFilter in ASP.Net MVC5

# Introduction

There are some limitations to the Exception Filter.

* The error won’t get logged anywhere.
* Exceptions raised outside controllers will not be handled. Example- exception raised because of invalid URL won’t be handled.
* Exception Handling based on the scenario is not possible. Example – So one error page when the request comes via AJAX and a different one when comes via normal request.
We will overcome all these problems by creating a Custom Exception Filter in MVC that means we will create a Custom Handle Error Filter in MVC application.


# For more info please visit below article
https://www.c-sharpcorner.com/article/custom-exception-filter-in-asp-net-mvc/
