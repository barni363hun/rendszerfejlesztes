# futtatáshoz

- redmine.sln megnyitása
- package manager console
  - PM> cd WebAPI
  - PM> dotnet tool install --global dotnet-ef
  - PM> dotnet ef database update
- WebAPI és BlazorApp projektek futtatása

# használat

- belépés
  - frits@example.com - asd -> egyszerű manager user
  - admin@example.com - admin -> admin manager (ő tud felvenni új managereket)
- home page-en ki vanna listázva a projektek
- ezek valamelyikére kattintva meg lehet tekinteni a projekthez tartozó taskokat
- itt hozzáadhatunk új task-ot is a projekthez
- a My Tasks oldalon a manager megnézheti melyik task-okat hozta ő létre
- ezek közül amelyik le fog járni a következő két napban annak a határideje piros
