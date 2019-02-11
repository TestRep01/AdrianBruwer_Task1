## Prerequisites
<ul>
<li>A windows node - (Windows workstation or Server)</li>
<li>Visual studio</li>
<li>Browsers required</li>
<ul>
<li>Chrome</li>
<li>FireFox</li>
<li>IE 11</li>
</ul>
<li>GitHub plugin should be added.</li>
<li>[GitHub extension for visual studio](https://visualstudio.github.com/)</li>
<li> If Jenkins "CI" is required the following plugins are recomended for Jenkins</li>
<ul>
<li>MSBuild</li>
<li>MSTest</li>
<li>MSTestrunner</li>
<li>GitHub</li>
</ul>
</li>
</ul> 

## Disclaimer
For the purpose of this project permission has been granted to use the site bujinkan-ct.co.za.
A gmail and github account have been setup for a easy deploy.

<ul>
<li>Gmail testtasksel@gmail.com, password P@$$W0rd</li>
<li>Github users testtasksel@gmail.com, password TestTask1Sel</li>
</ul> 

It has not been done for this project, but in a real world deployment a website would be setup to
display and record the results generated for the TRX files.

## Installing
<ul>
<li>Please install the visual studio and Github visual studio extension.</li>
<li>In Visual studio go to Team explore and select Managed Connections Github.</li>
<li>Enter provided Credentials.(testtasksel@gmail.com, password P@$$W0rd)</li>
<li>Select clone (TestRep01/AdrianBruwer_Task1)</li>
<li>Select the cloned solution and rebuild.</li>
<li>Go to Test \ Windows \ Test Explore and Run selected tests.</li>
</ul>

### Tests on IE 11
Please Set the same security level in all zones.

>Open IE 11
Go to Tools --> Internet Options --> Security
Set all zones (Internet, Local intranet, Trusted sites, Restricted sites) to the same protected mode, enabled or disabled should not matter.


## Running the tests
<ul>
<li>Go to Test \ Windows \ Test Explore and Run selected tests.</li>
</ul>

## Break down into end to end tests
<ul>
<li>Navagate_to_the_home_page_01</li>
 <ul><li>Navigate to the home page and Assert you on the correct page</li></ul> 
<li>Navagate_To_Selected_school_02</li>
<ul><li>Navigate to a selected school from the home page aand Assert you on you have the correct school</li></ul> 
<li>Login_To_Tthe_Website_with_Chrome_3</li>
<ul><li>Login to the website using chrome browser, and Assert you are on the profile page</li></ul> 
<li>Login_To_The_Website_With_FireFox_4</li>
<ul><li>Login to the website using firefox browser,and Assert you are on the profile page</li></ul> 
<li>Login_To_The_Website_With_IE_5</li>
<ul><li>Login to the website using IE browser,and Assert you are on the profile page</li></ul> 
</ul> 

## Author
Adrian Bruwer -Senior Automation Tester