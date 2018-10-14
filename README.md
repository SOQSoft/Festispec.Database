
# Festispec.Database

## Installation

**1.**  Clone de repository 
**2.**  Open Command promp 
**3.**  `cd` naar de map met het project 
**4.** Voer de volge
```cmd
#Restore npm packages
dotnet restore

# Restore database
dotnet ef database update
```

## Development


## Testing

### Tests draaien doormiddel van command line 
Het is mogelijk om via bash of cmd te draaien hiervoor moet je de volgende commando's invoeren: 
``` 
#Restore npm packages
dotnet restore

# Restore database
dotnet ef database update

# Run tests
dotnet test
```
### Tests draaien door middel van Visual studio
1.  Open  **Test Explorer**.
    
    ![On the Test menu, open Test Explorer](https://docs.microsoft.com/en-us/visualstudio/test/media/rununittest1.png?view=vs-2017)
    
2.  Run unit tests.
    
    ![Run unit tests in Test Explorer](https://docs.microsoft.com/en-us/visualstudio/test/media/rununittest2.png?view=vs-2017)
    
    Je kan in de de valende en werkende tests zien in  **Test Explorer**.
    
    ![Review unit test results in Test Explorer](https://docs.microsoft.com/en-us/visualstudio/test/media/rununittest3.png?view=vs-2017)


## Deployment
### Deployment method
Deployments gaan automatish doormiddel van intergratie van azure devops, zodra er iets naar de develop branch wordt gepushed wordt deze automatish op de test server gedeployed. 
Wil je het deployen naar de master server push dan de code van develop naar  ``Release`` aan in github, 


1.  Open Github en navigeer naar de repository.
    
2.  Under your repository name, click **Releases**.
![Releases tab](https://help.github.com/assets/images/help/releases/release-link.png =818x170)
    
3.  klik op **Draft a new release**.
![Releases tab](https://help.github.com/assets/images/help/releases/draft_release_button.png =371x171)

4.  ![Releases tagged version](https://github.com/SOQSoft/Technisch-Ontwerp/wiki/Versiebeheer =360x49) Schrijf het versie nummer neer van welke versie het is gebruik hierbij de benaming van het het  [versie beheer](https://git-scm.com/book/en/Git-Basics-Tagging) van het technish ontwerp.
