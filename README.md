# GreenPlace

Create local db

In appsettings.json -> "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=GreenPlaceProductShop;Trusted_Connection=True;
                                            MultipleActiveResultSets=true"

AT DATABASE CHANGE THE NAME OF THE DATABASE *You can use GreenPlaceProductShop if you have just created this one before", THE NAME WILL BE YOUR CHOSEN NAME AT DB CREATION

In Package Manager Console, use command: "add-migration SomeMigration", after this, use command: "update-database"

Enjoy!

