# Netizen Experience Job Application
## REST API task

## Instruction:
Need to return a response:
```
{"message":"GET to this endpoint with 'email' query parameter to receive further instructions. Please provide the same email as the one used in your job application."}
```

## Steps to test the API repo:

1. Clone the repo
```
git clone https://github.com/eimanes/NetizenExp.JobApplication.git
```

2. Open terminal and run
```
dotnet restore
```

3. Run API
```
dotnet run
```

4. Run Postman to test API
   - GET request
   - url : `http://localhost:5000/api/checkEmail?email=eimansalleh.5@gmail.com`

5. Response :
![image](https://github.com/eimanes/NetizenExp.JobApplication/assets/80232250/2e0a25ed-42ac-40c7-b94c-e50c77e8b808)
