# AddressBook
Simple test project ASP.Net (C#)

Solution contatins 3 projects
- ASP.Net MVC 
- Service library
- Window service project

## Starting project

1. **Compile whole solution**

2. **Install service**. Start console with admin options and run command below:
```Bash
installutil "G:\YOURS PATH\ContactWindowsService.exe"
```
3. **Starting service**. Open Windows services dialog and start this service (name ContactWindowsService)

4. **Starting MVC project with ISS or ISS Express**


## Removing service

1. **Diactivating service.** Open Windows services dialog and deactive service (name ContactWindowsService)

2. **Remove service.** Start console with admin options and run command below:
```Bash
sc delete ContactWindowsService
```
