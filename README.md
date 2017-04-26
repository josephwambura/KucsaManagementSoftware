
# KucsaManagementSoftware

The software program is a windows forms application implemented using CSharp language, and the UI controls made beautiful with the modern-metro-UI. It uses entify-framework for the CRUD operations. 

![Login UI](https://github.com/dansef/KucsaManagementSoftware/blob/master/KucsaManagementSoftware/Screenshots/Login_Sketch.png)

## Visual Studio 2017 
This is a visual studio solution.
Download [Visual Studio](https://www.visualstudio.com/downloads/) from their official website.

## Sample
<a href="https://www.kedevelopers.com/kucsamanagementsoftware/sample"><img alt="View the demo on Ke Developers" src="https://github.com/dansef/KucsaManagementSoftware/blob/master/KucsaManagementSoftware/Screenshots/MainWindow_Sketch.png" width="200" height="100"/></a><br>
<a href="https://www.kedevelopers.com/kucsamanagementsoftware/sample"><img alt="View the demo on Ke Developers" src="https://github.com/dansef/KucsaManagementSoftware/blob/master/KucsaManagementSoftware/Screenshots/Member_Details_Sketch.png" width="200" height="100"/></a><br>
<a href="https://www.kedevelopers.com/kucsamanagementsoftware/sample"><img alt="View the demo on Ke Developers" src="https://github.com/dansef/KucsaManagementSoftware/blob/master/KucsaManagementSoftware/Screenshots/Manage_Courses_Sketch.png" width="200" height="100"/></a><br>
<a href="https://www.kedevelopers.com/kucsamanagementsoftware/sample"><img alt="View the demo on Ke Developers" src="https://github.com/dansef/KucsaManagementSoftware/blob/master/KucsaManagementSoftware/Screenshots/Successful_Save_Sketch.png" width="200" height="100"/></a><br>

## Wiki
### General
The software is made with VS 2017 Visual C#. It uses entity-framework.
In Visual Studio, remember to add Modern-Metro-UI as a nuget package, also you need to add the package controls to the Toolbox to be able to use them.

### The Windows UI 
The software UI may change overtime as this is not the final product. I expect suggestions from KUCSA Members.

### Reports
The software is lacking the reports, feel free. Well, they will be coming sooner than you think.

### Email
The software is lacking the email module, feel free. Well, it could be coming sooner than you think.

### SMS
The SMS module is on its way, suggestions allowed.

If you are familiar with CSharp - you already know how to use this software.

#### Usage:
 1. Install Visual Studio 2013, 2015 or 2017 and later.
 2. Create the sql database (Required!).
 3. Create a new query pointing to your database, the execute the [CreateDatabase.sql](https://github.com/dansef/KucsaManagementSoftware/blob/master/KucsaManagementSoftware/Data/CreateDatabase.sql) to get started, if you don't know how to do it.
 4. Set the entity-framework.
 5. You may opt to use Sql manually, also possible, but why go back to the primates age.  
 6. You are all set, just run the app by hitting F5 in the Visual Studio.
 7. You may be required to change the Form to MetroForm in every View Code of a Windows Form to get the magic of Metro-UI from

```csharp
using System.Windows.Forms;
using System.IO;

namespace KucsaManagementSoftware
{
    public partial class FormMain : Form { //Some Code in here }
}
```
 
```csharp
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using System.IO;

namespace KucsaManagementSoftware
{
    public partial class FormMain : MetroForm { //Some Code in here }
}
```
 8. You are done! 

## Special thanks
Thanks to [Ke Developers](https://www.kedevelopers.com) and [KUCSA](https://www.kedevelopers.com) for their continued support.

## License
```
Copyright 2017 Joseph Githithu

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
```
