Projekt na zaliczenie Programownie Obiektowe

Aplikacje w ASP.NET Core WEB MVC.

### Opis

Aplikacja to prosty blog, bez panelu admina.
Aplikacja pozwala przeglądanie i edytowanie postów.
Kilka wpisów i kategorii umieściłem w pamięci aplikacji,
sa one ładowane i resetowane przy starcie.

Zależało mi głównie na pokazaniu, że rozumiem jak działa programowanie obiektowe.

### Co przeglądać

Najlepiej przeglądać te ścieżkę:
https://github.com/ptrela/BlogAspNetProjekt/tree/main/BlogAspNet

Foldery: Controllers, Models, Services, Views - tam znajduje się cała logika aplikacji

### Spis funkcjonalności

1. Przeglądanie wpisów bloga
2. Przeglądanie pojedynczego wpisu po przekazaniu id
3. Licznik wyświetleń wpisu (zapisywany w pamięci na serwerze, restartowany po resecie serwera)
4. Edycja wpisu

### Instalacja

1. Pobrać lub sklonować repozytorium
2. Otworzyć projekt w Visual Studio lub Jetbrains Raider
3. Komendy do przywrócenia środowiska
```
dotnet restore - przywraca zależności (biblioteki) projektu
dontnet build - kompiluje projekt
dotnet run - uruchamia serwer
```
