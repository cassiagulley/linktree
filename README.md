# Linktree Take Home Test - Cassia Gulley
The following is a solution developed to meet the requirements as specified in the **Take Home Test** specification.
Not all functionality has been implemented, as such TODO's have been used to denote potential future work.


# Build Application 
## Before you start
- Ensure the latest version of .NET (6.0) is downloaded
- Note: viewing/editing this code works best using Visual Studio (Preview) 2022 for macOS.

## Run Locally
1. Clone this repository into a relevent folder
2. Navigate inside the folder 'LinktreeTakeHome'
```bash
cd LinktreeTakeHome
```
3. Run the following command
```bash
dotnet run
```
*Note: Remember the PORT value displayed* 

## Test Locally
Open a web browser and go to: 
```bash
https://localhost:{PORT}/swagger/index.html
```
From here reqest types can be accessed at tested using SwaggerUI


# Api Design
## API Routes 
The following image denotes the requests available and the routes the endpoints they can be acessed at.

<img width="387" alt="Screen Shot 2022-04-10 at 11 13 28 pm" src="https://user-images.githubusercontent.com/91455929/162619891-dac3471c-a0c8-457a-9bba-78f3c4f31564.png">

- ```GET /Link``` returns all of the links available 
- ```GET /Link/{id}``` returns the link associated with a given identifyer
- ```GET /Link/userLinks/{userId}``` returns all of the links available to a given user
- ```POST /classicLink``` handles the addition of a classic link
- ```POST /showsLink``` handles the addition of a shows link
- ```POST /musicStyle``` handles the addition of a music style link

*Assumptions: Assuming the clientside specifies the userId and link type*

# Schema
This solution is based on the following assumed schema

<img width="403" alt="Screen Shot 2022-04-10 at 10 40 39 pm" src="https://user-images.githubusercontent.com/91455929/162618592-fa3f9b21-03ed-4b8b-9d6c-3a9a6b45483d.png">

