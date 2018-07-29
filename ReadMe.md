# Unity3D Empty - GitHub

## Note for Windows
```
If you're using Windows you'll need to install CURL in order to create the repository. 

If you're not comfortable installing CURL you can create the repository from your GitHub homepage and follow the instructions as written after the CURL command.
```
## Command Line
* Create the Unity3D Project as usual
* Navigate to the Project folder
* Open a command line
* Execute the following commands
``` 
curl -u <username>:<password> https://api.github.com/user/repos -d "{ \"name\":\"<repo-name>\"}"
git init
git remote add origin "https://github.com/<username>/<repo-name>.git"
```
Anything in angle brackets represents a variable you'll need to fill in.
