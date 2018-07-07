Instructions

Clone repo : https://github.com/rajsaroha44/employeeslip.git
Run the application using VS

Required :
VS2015 or above, Framework 4.5 and web api 2.0
It's using Factory pattern to calculate incometax and gross salary.
It's using Singleton pattern for initilization taxslabs.

Make sure all nuget packages are installed properly.

Unit Tests to validate salary calculations

After runng application test api's using postman or any api client.
Url : http://localhost:50878/api/EmployeeSalaryDetail/GetEmployeeSalaryDetaill
Type : POST
Sample Input : 
{"FirstName": "Rajpal", "LastName": "Saroha", "AnnualSalary" :"60050" ,"SuperRate" : "9","PaymentStartDate": "01 March – 31 March"}

Output : 
{"Name":"Rajpal Saroha","PayPeriod":"01 March – 31 March","GrossIncome":5004,"IncomeTax":922,"NetIncome":4082,"SuperAmount":450}