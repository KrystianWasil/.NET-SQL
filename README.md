# Projekt: Zadanie Rekrutacyjne

## Wymagania
- Microsoft Visual Studio
- Microsoft SQL Server

## Instrukcje uruchomienia

Aby uruchomić projekt na swoim komputerze, wykonaj poniższe kroki:

### 1. Klonowanie repozytorium
Sklonuj projekt do folderu docelowego używając polecenia:

git clone <adres_url_pobrany_z_tego_repozitorium>

### 2. Utworzenie bazy danych
Masz dwie opcje, aby utworzyć bazę danych:

### Opcja 1: Użyj Visual Studio
Przejdź do folderu, gdzie sklonował się projekt.
Otwórz folder w Visual Studio.
Znajdź plik o nazwie script2.sql i kliknij na niego.
Zmień wartość FILENAME na ścieżkę, gdzie chcesz zapisać pliki:
FILENAME = "N'adres_gdzie_chcesz_zapisac_pliki\test1.mdf"   !!!Wazne N' ..... !!!
Wykonaj skrypt, aby utworzyć bazę danych.


![image](https://github.com/user-attachments/assets/315e8a3b-11be-4c09-b955-be742228ab67)


![image](https://github.com/user-attachments/assets/5faeb263-04f0-4ca4-a357-48568dd1ec33)


#### Opcja 2: Użyj SQL Server Management Studio
Otwórz SQL Server Management Studio.
Przejdź do folderu Databases.
Wybierz plik script2.sql i wykonaj ten skrypt w bazie danych.
Też zmień FILENAME = "N'"

### 3. Ustaw connection stringa.

![image](https://github.com/user-attachments/assets/fb11d5eb-9c60-400f-ab22-e530b986e365)

Dodaj połączenie ze swoją bazą danych
Wpsiz adres/nazwe serwera , wybierz baze.

![image](https://github.com/user-attachments/assets/bb4428fb-a4cd-4fb1-84fd-90bc54c6f593)

kliknij na polaczenie wybeirz właściwosci i potem parametry połączenie (connection string)
Connection string wpisz w:
App.config 
connectionString="<miejsce na connection stringa>"
Możesz uruchomić juz apliakcje: wybeirając w start plik .vbproj lub uruchamiając w folderze WindowsApp1.sln
