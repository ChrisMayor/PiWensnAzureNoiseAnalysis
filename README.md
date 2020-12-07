# Raspberry Pi Wensn Azure Noise Analysis - By use of the WS1361 Sound Pressure Level (SPL) Meter
.Net Core API and frontend web app for DB(A) measurement with Wensn soundmeter and Raspberry PI

-- Work in Progress --

Project target is, to provide an Azure cloud frontend for the cheap WS1361 Sound Pressure Level (SPL) Meter when it is in use in comination with the Raspberry Pi.

The WS1361 is a cheap (but very accurate) Sound Pressure Level (SPL) Meter which contains an USB port. The software provided with the WS1361 is nearly unusable, so it was reverse engineered in the past by some people, so it is now possible to connect the WS1361 to an USB port of the Raspberry Pi and use Python to read data from the WS1361.

For further information please refer to https://github.com/mepster/wensn. Huge thanks and copyrights goes to mepster for providing the Python scripts for reading the data in his repository. 

# Architecture

Logging of db(A) value every 10 seconds to AzrueSQL Database:

WS1361 --> Raspberry Pi --> .NET Core Api --> Azure SQL Database

Frontend:

Option 1) Azure SQL Database --> .NET Core Razor Pages

Option 2) Azure SQL Database --> .NET Core Api --> Angular

# Price

The price for the cloud sound pressure level logger will be really cheap:

- WS1361 Sound Pressure Level (SPL) Meter from Aliexpress ~ 20 €
- Raspberry PI (e.g. 3b) ~ 30 €
- AzureSQL Instance (Size:Basic) ~ 5 €/Month
- Azure App Service (for hosting API and Frontend) starting from 0 €

In total:
* Inital costs: 50 €
* Cost per Month: Starting vom ~5 €

# How to setup

-- Work in Process --

# Current screenshot

Test Page:

![current Screenshot](https://github.com/ChrisMayor/PiWensnAzureNoiseAnalysis/blob/main/screentshots/current.JPG?raw=true)



