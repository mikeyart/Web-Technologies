# Report

## Laboratory Work Nr.2

### Objectives:
* Get familiar with MVC pattern

### Framework ASP.NET
The Model-View-Controller (MVC) architectural pattern separates an application into three main components: the model, the view, and the controller. The ASP.NET MVC framework provides an alternative to the ASP.NET Web Forms pattern for creating Web applications. The ASP.NET MVC framework is a lightweight, highly testable presentation framework that (as with Web Forms-based applications) is integrated with existing ASP.NET features, such as master pages and membership-based authentication. The MVC framework is defined in the System.Web.Mvc assembly.

The MVC framework includes the following components:
* Models. Model objects are the parts of the application that implement the logic for the application's data domain. Often, model objects retrieve and store model state in a database. For example, a Product object might retrieve information from a database, operate on it, and then write updated information back to a Products table in a SQL Server database.
* Views. Views are the components that display the application's user interface (UI). Typically, this UI is created from the model data. An example would be an edit view of a Products table that displays text boxes, drop-down lists, and check boxes based on the current state of a Product object.
* Controllers. Controllers are the components that handle user interaction, work with the model, and ultimately select a view to render that displays UI. In an MVC application, the view only displays information; the controller handles and responds to user input and interaction. For example, the controller handles query-string values, and passes these values to the model, which in turn might use these values to query the database.

### Process:
In order to link my web project created using BootStrap, I had to do the following steps:
* Firstly, I had to create a MVC based project using Visual Studio;
* I had to install and update all the packages used in the BootStrap;
* Creating the file BundleConfig allowed me to create bundles to simplify the code. Generally, bundles are used to combine multiple files into a single file, to make things easy. In my case, i've used 2 types of bundles: style and script;
* Another step was creating a HomeController which is essential to my project. It has the purpose to handle URLs to the homepage of my site;
* My front-end side of the project, will consist of using a layout. I need that in order that all my pages that belong to the website should be linked between them. An easy way is to use the layout;
* The last step in completing this laboratory would be to insert the main style and script of the website inside the .NET project;

### Conclusion:
This laboratory work initialized me in the world of .NET. Creating the project and linking it to a bootstrap theme is considered the fist step into making a good, working website. Personally, i've encountered some minor problems with bundles, but after reading the documentation i've finally figured it out. It was interesting to me the approach of bundles because i've realized that putting multiple files into one is much more space and time efficient rather than writing a lot of useless code. The MVC pattern is another thing that got my attention. I've learned that there are active and passive models in an MVC pattern. I've worked before with ASP.NET but only now i've realized that the way that we are taught is considered passive model MVC, while i knew only about the active one. In conclusion, I'd say that this laboratory was rather interesting and I look forward on discovering new things in the world of ASP.NET.

