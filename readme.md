# futtatáshoz

- redmine.sln megnyitása
- ha nincs akkor EntityFrameWorkCore, EntityFrameWorkCore.Design, EntityFrameWorkCore.Sqlite telepítése
- package manager console
- (fejlesztőknek) ha van a WebAPI mappában sqlite.db fájl töröld
- adatbázis létrehozása tesztadatokkal
  - PM> cd WebAPI
  - PM> dotnet tool install --global dotnet-ef
  - PM> dotnet ef database update
- WebAPI és BlazorApp projektek futtatása

# használat

- belépés még nincs
- a rendszer úgy kezeli hogy az 1-es id-vel rendelkező meneger van belépve
- home page-en ki vanna listázva a projektek
- ezek valamelyikére kattintva meg lehet tekinteni a projekthez tartozó taskokat
- itt hozzáadhatunk új task-ot is a projekthez
- a My Tasks oldalon a manager megnézheti melyik task-okat hozta ő létre 
- ezek közül amelyik le fog járni a következő két napban annak a határideje piros
