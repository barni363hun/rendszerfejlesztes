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

get all tasks
list devs
add task
