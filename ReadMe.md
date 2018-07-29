# Unity3D Empty - GitHub

## Note for Windows
```
If you're using Windows you'll need to install CURL in order to create the repository. 

If you're not comfortable installing CURL you can create the repository from your GitHub homepage and follow the instructions as written after the curl command.
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

* The curl command will create the repository in GitHub
* git init - This is the step that turns your directory into a local repository
* git remote add - This sets your local repository to use GitHub as the remote

Now you need to make sure that all editor windows are closed as they may be locking files that would cause the next steps to fail.

```
git add *
git commit -m "Initial Commit"
git push --set-upstream origin master
```

* git add * - Adds all files in the current directory to the local repo
* git commmit - Commits the files to the local repo
* git push - Pushes the changes up to Github.

Normally we wouldn't have to set the upstream, but since we just created this repository we have to tell it which branch we're using for our push.

## Why use Command Line?

Personally, I use command line because at work we do a lot of automation and it's really nice to know the commands the UI tools are using in case you need to replicate them in a your automation pipeline.

It's up to you, but if you're learning it's something nice you'll probably need to know eventually anyway.

Good luck! If you have questions feel free to reach out on Discord.
