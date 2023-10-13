Author Name: Arpan Arpan
Student ID:0820839 
Start Time: 10/09/2023 4:00 PM

Part1

Hi there I am Arpan Arpan , I got my first assignment of MvcApplication.
I started it while doing the same steps as I followed for the tutorial.
Since in my last tutorial I commented the sslport which was a obstacle in running the application.So here I
am doing this step in advance so that I don;t get an error!!!!!!! Yes I am smart..... 
I started and It worked.

According to the assignment Instructions 
I am working on the App for the Rulers.

Part2[ADD A CONTROLLER]
The step is to add a controller in the application.
I replaced the code with the given code of the tutorial...  

The main focus was to add the parameteres in the controller like numtimes.
So here i updated the welcome method to pass the parametres in it.Let's try this out in the browser.
Since i have to pass some information in the url i searched the given url:"https://localhost:{PORT}/HelloWorld/Welcome?name=Rick&numtimes=4"
Again I am doing the change in the parameters in which i am using ID.
and tried it out.It worked and now i am moving to the next part.

PART3[ADD A VIEW]

Currently in my controller i have a message for the index method.So i will change it to the return view . So what's next I added the new folder under the view folder and named it HelloWorld.
Next i added new item the index.cshtml page in the HelloWorld folder .Next i am going to updated it for my view part.
Now i am playing with the view of my application which is basically what a customer gonna see. So updated the created html page also the layout page in the shared folder under views. 
I changed the name of my application name with the name: Rulers_Rule

Now i replaced the index title with the name for my list of rulers.

Firstly i cahnged the welcome method to add the name and numtime in the Viewdata dictionary.
Now the main part is here to be perfomed. Passing data from controller to the view. Whats that creating a loop in the welcome.cshtml.
Now what gonna happen is  according to the numtimes [hello+name] will be printed out in a sequence which can be viwed.
 

PART4[Adding data Model class]


In this part i craeted a database for my application which  contain the categories of the product{id,Title,Material,purpose,Length,price}
Now lets move forward with the next step. I need to run the command in the Package manager console:"Install-Package Microsoft.EntityFrameworkCore.SqlServer".
Next I created the database class context. I created a Data folder in my app and added a controller name MvcRulerContext and changed the code in it according to the requirement
it was showing error so I wrote down the code mannually it the errors are gone now good to go now.

Since I created the database I surely had to register it so I am gonna register it by adding the using statement in the startup.cs and adding the code in the startup.cs configureServices.
Later I added a connecting string in the appsettings.json file and examine my database.



The complete step is I added the scaffolding item in it as per tutoriall but it gives me error of about the nuget packages version . Again i installed the latest version of the nuget packagers.
Again i added the scaffolding item and run the migration command and update commands in the package manager prompt.

It created my migrations folder and the timspan    ( GUESS WHAT IT WILL SHOW THAT I CREATED MY APPLICATION BY MYSELF.......!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!)
By this my part 4 is completed .


PART 5

Adding seedData in my application .
According to the tutorial I created a class name SeedData under the Model folder and added the data of the ruler in it.Next I updated the startup.cs file and the program.cs file of my application.
I test the app and it worked.(I am doing good and entered the 10 entries in the data.)


PART 6 :
In my part 6 I examine the code according to the tutorial.

Next step PART 7[ ADDING A SEARCH BAR ]


In my Controllers folder in the RulersController.cs file I added the searchstring parameter with the  query for the loop of search , in the index method.
Added the Lambda expression "rulers.Where(s => s.Title.Contains(searchString))" to specify the where place.
Under my Ruler/inde.cshtml i added the form to add a search bar in it and filter the result using the search bar.

Now what I created the class name RulerMaterialView under the Model folder and added the code in it.
Later i updated my index method with the searchstring for the material column in that.folder to fetch the data using the material column .
After that I updated the index of the view to add search by material in it.