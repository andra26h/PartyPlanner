# 🥳 Party Planner – Aplicație Console C# cu SQL Server

## 📌 Descriere generală

**Party Planner** este o aplicație de tip consolă scrisă în **C#** care permite gestionarea unui eveniment: invitați, furnizori, evenimente și taskuri. Datele sunt stocate într-o bază de date **SQL Server**, iar aplicația oferă operații CRUD pentru fiecare entitate.

##  Funcționalități

-  Adăugare, vizualizare, actualizare și ștergere pentru:
  - **Invitați (Guests)**
  - **Furnizori (Suppliers)**
  - **Evenimente (Events)**
  - **Taskuri de planificare (Planning Tasks)**
-  Meniu interactiv în consolă
-  Salvare și citire date direct din baza de date SQL Server

##  Structură aplicație

- **Models** – Clasele entitate (`Guest`, `Supplier`, `Event`, `PlanningTask`)
- **Data** – Clasa `PartyPlannerContext` (moștenește `DbContext`) pentru conectare la baza de date
- **Repositories**
  - `IRepository<T>` – Interfață generică CRUD
  - `GenericRepository<T>` – Implementare care folosește EF Core
- **Factory**
  - `RepositoryFactory` – Folosește **Factory Pattern** pentru a crea instanțe de `GenericRepository<T>`
- **Program.cs**
  - Meniu principal și funcționalități CRUD per entitate

##  Design Patterns folosite

- **Factory Pattern** – `RepositoryFactory` creează repository-uri pentru entități.
- **Repository Pattern** – abstractizare a operațiilor asupra bazei de date, folosind `GenericRepository<T>`.

##  Principii OOP aplicate

- **Encapsulation** – fiecare entitate își gestionează propriile date și comportamente.
- **Abstraction** – folosirea interfeței `IRepository<T>` pentru a ascunde implementarea CRUD.
- **Inheritance** – toate entitățile moștenesc `BaseEntity` cu proprietatea `Id`.
- **Polymorphism** – metode generice folosite pentru a trata toate entitățile printr-o singură interfață.

## ⚙ Tehnologii folosite

- .NET / C#
- EF Core
- SQL Server

##  Testare aplicație (manuală)

- 🔸 Se rulează aplicația din consolă
- 🔸 Se selectează o entitate (ex: Guests)
- 🔸 Se testează fiecare operație:
  - **Add** – introduci date noi din consolă
  - **Show All** – vizualizezi toate înregistrările
  - **Update** – modifici o înregistrare existentă
  - **Delete** – ștergi o înregistrare
- 🔸 Verifici din SQL Server că datele s-au salvat/modificat
