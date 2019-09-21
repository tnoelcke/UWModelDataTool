# UWModelDataTooldata
The UW Data Tool is designed to extract data from the University of Washington weather models. This will be accomplished by downloading the images and processing the images to extract the data. The data will then be placed in a database through an API. The api will expose the UW model data through the database. There is also a UI component to this applicaiton that will eventually be replaced by a better UI called Weather View. This UI will provide data accross several different models.

## Development
If you want to help build the application or work on bug fixes feel free to assign your self an issue on the board and get to work!

## Set Up
This part of the applicaiton is a C# Dontnet Core application. This can be run in any enviornment but the set up steps may be different. I am using Visual Studio for this part of the application. In windows this appliciton should be able to be built and run with out any special steps in visul studio. Though this will eventually require Docker Desktop to be installed.

### Mac and Linux
Coming Soon.


## Data Model
We are planning to capture data from the following models:
- WRF-GFS
- WRF-GFS-Extended (for frames not covered by the WRF-GFS).
- MMM5-NAM

For these models we plan to capture the following data:
- Temperature
- Wind Speed Sustained
- Wind Speed Gust
- 850 MB Temps
- 500 MB Temps
- Preciptiation
	- 3 Hour
	- 24 hour
	- 3 Hour Snow
	- 24 Hour Snow
- Freezing level