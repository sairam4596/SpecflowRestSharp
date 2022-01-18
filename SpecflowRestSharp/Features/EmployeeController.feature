Feature: EmployeeController
	Automate the API using RestSharp

@mytag
Scenario: addANewEmployee
    Given enter the endpoint url is /api/v1/employee
	And i create POST request
	And I add the request body using the below params
	| Key        | Value   |
	| compitency | Java    |
	| id         |234455   |
	| name       | sreeram |
    |yearOfJoining| 2017|
    When i send the request
	Then i validate the response status code Created

	Scenario: getEmployeeById
    Given enter the endpoint url is /api/v1/employees/{id}
	And i create GET request
	And i passed url parameter as  234455
    When i send the request
	Then i validate the response status code Accepted

    Scenario: getAllEmployees
    Given enter the endpoint url is /api/v1/employees
	And i create GET request
    When i send the request
	Then i validate the response status code Accepted

	Scenario: updateEmployeeById
    Given enter the endpoint url is /api/v1/employees/{id}
	And i create PUT request
	And i passed url parameter as 234455
	And I add the request body using the below params
	| Key        | Value   |
	| compitency | Java    |
	| name       | sreeram |
    |yearOfJoining| 2019|
    When i send the request
	Then i validate the response status code Accepted
	
	Scenario: deleteEmployeeById
    Given enter the endpoint url is /api/v1/employees/{id}
	And i create DELETE request
	And i passed url parameter as 234455
    When i send the request
	Then i validate the response status code Gone