
//using PartyPlanner.Data;
//using PartyPlanner.Models;
//using PartyPlanner.Repositories;
//using PartyPlanner.Repositories.Interfaces;
//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        using var context = new PartyPlannerContext();
//        var serviceFactory = new ServiceFactory(context);

//        while (true)
//        {
//            Console.Clear();
//            Console.WriteLine("Meniu Principal:");
//            Console.WriteLine("1. Invitați");
//            Console.WriteLine("2. Furnizori");
//            Console.WriteLine("3. Evenimente");
//            Console.WriteLine("4. Taskuri");
//            Console.WriteLine("5. Ieși");
//            Console.Write("Alege o opțiune: ");
//            var choice = Console.ReadLine();

//            if (choice == "1") ShowGuestMenu(serviceFactory);
//            else if (choice == "2") ShowSupplierMenu(serviceFactory);
//            else if (choice == "3") ShowEventMenu(serviceFactory);
//            else if (choice == "4") ShowTaskMenu(serviceFactory);
//            else if (choice == "5") break;
//            else Console.WriteLine("Opțiune invalidă!");

//            Console.WriteLine("\nApasă orice tastă pentru a continua...");
//            Console.ReadKey();
//        }
//    }

//    #region Menus
//    static void ShowGuestMenu(ServiceFactory serviceFactory)
//    {
//        while (true)
//        {
//            Console.Clear();
//            Console.WriteLine("Meniu Invitați:");
//            Console.WriteLine("1. Adaugă un invitat");
//            Console.WriteLine("2. Afișează invitații");
//            Console.WriteLine("3. Actualizează un invitat");
//            Console.WriteLine("4. Șterge un invitat");
//            Console.WriteLine("5. Înapoi");
//            Console.Write("Alege o opțiune: ");
//            var choice = Console.ReadLine();

//            if (choice == "1") AddGuest(serviceFactory);
//            else if (choice == "2") ShowGuests(serviceFactory);
//            else if (choice == "3") UpdateGuest(serviceFactory);
//            else if (choice == "4") DeleteGuest(serviceFactory);
//            else if (choice == "5") break;
//            else Console.WriteLine("Opțiune invalidă!");
//        }
//    }

//    static void ShowSupplierMenu(ServiceFactory serviceFactory)
//    {
//        while (true)
//        {
//            Console.Clear();
//            Console.WriteLine("Meniu Furnizori:");
//            Console.WriteLine("1. Adaugă un furnizor");
//            Console.WriteLine("2. Afișează furnizorii");
//            Console.WriteLine("3. Actualizează un furnizor");
//            Console.WriteLine("4. Șterge un furnizor");
//            Console.WriteLine("5. Înapoi");
//            Console.Write("Alege o opțiune: ");
//            var choice = Console.ReadLine();

//            if (choice == "1") AddSupplier(serviceFactory);
//            else if (choice == "2") ShowSuppliers(serviceFactory);
//            else if (choice == "3") UpdateSupplier(serviceFactory);
//            else if (choice == "4") DeleteSupplier(serviceFactory);
//            else if (choice == "5") break;
//            else Console.WriteLine("Opțiune invalidă!");
//        }
//    }

//    static void ShowEventMenu(ServiceFactory serviceFactory)
//    {
//        while (true)
//        {
//            Console.Clear();
//            Console.WriteLine("Meniu Evenimente:");
//            Console.WriteLine("1. Adaugă un eveniment");
//            Console.WriteLine("2. Afișează evenimentele");
//            Console.WriteLine("3. Actualizează un eveniment");
//            Console.WriteLine("4. Șterge un eveniment");
//            Console.WriteLine("5. Înapoi");
//            Console.Write("Alege o opțiune: ");
//            var choice = Console.ReadLine();

//            if (choice == "1") AddEvent(serviceFactory);
//            else if (choice == "2") ShowEvents(serviceFactory);
//            else if (choice == "3") UpdateEvent(serviceFactory);
//            else if (choice == "4") DeleteEvent(serviceFactory);
//            else if (choice == "5") break;
//            else Console.WriteLine("Opțiune invalidă!");
//        }
//    }

//    static void ShowTaskMenu(ServiceFactory serviceFactory)
//    {
//        while (true)
//        {
//            Console.Clear();
//            Console.WriteLine("Meniu Taskuri:");
//            Console.WriteLine("1. Adaugă un task");
//            Console.WriteLine("2. Afișează taskurile");
//            Console.WriteLine("3. Actualizează un task");
//            Console.WriteLine("4. Șterge un task");
//            Console.WriteLine("5. Înapoi");
//            Console.Write("Alege o opțiune: ");
//            var choice = Console.ReadLine();

//            if (choice == "1") AddTask(serviceFactory);
//            else if (choice == "2") ShowTasks(serviceFactory);
//            else if (choice == "3") UpdateTask(serviceFactory);
//            else if (choice == "4") DeleteTask(serviceFactory);
//            else if (choice == "5") break;
//            else Console.WriteLine("Opțiune invalidă!");
//        }
//    }

//    #endregion

//    #region Add
//    static void AddGuest(ServiceFactory serviceFactory)
//    {
//        var guestRepository = serviceFactory.CreateGuestRepository();

//        Console.WriteLine("\nAdd a guest:");
//        Console.Write("Name: ");
//        var name = Console.ReadLine();

//        Console.Write("Email: ");
//        var email = Console.ReadLine();

//        Console.Write("RSVP (true/false): ");
//        var rsvpInput = Console.ReadLine();
//        bool rsvp = bool.TryParse(rsvpInput, out rsvp) && rsvp;

//        var guest = new Guest { Name = name, Email = email, RSVP = rsvp };
//        guestRepository.Add(guest);

//        Console.WriteLine("Guest added successfully");
//    }
//    static void AddSupplier(ServiceFactory serviceFactory)
//    {
//        var supplierRepository = serviceFactory.CreateSupplierRepository();

//        Console.WriteLine("\nAdd a supplier:");
//        Console.Write("Supplier Name: ");
//        var name = Console.ReadLine();

//        Console.Write("Service offered: ");
//        var service = Console.ReadLine();

//        Console.Write("Contact (Phone/Email): ");
//        var contact = Console.ReadLine();

//        var supplier = new Supplier { Name = name, Service = service, Contact = contact };
//        supplierRepository.Add(supplier);

//        Console.WriteLine("Supplier added successfully!");
//    }
//    static void AddEvent(ServiceFactory serviceFactory)
//    {
//        var eventRepository = serviceFactory.CreateEventRepository();

//        Console.WriteLine("\nAdd an event:");
//        Console.Write("Title: ");
//        var title = Console.ReadLine();

//        Console.Write("Location: ");
//        var location = Console.ReadLine();

//        Console.Write("Date (yyyy-mm-dd): ");
//        var dateInput = Console.ReadLine();
//        DateTime date;
//        while (!DateTime.TryParse(dateInput, out date))
//        {
//            Console.Write("Date Invalid. Try again (yyyy-mm-dd): ");
//            dateInput = Console.ReadLine();
//        }

//        var eventItem = new Event { Title = title, Location = location, Date = date };
//        eventRepository.Add(eventItem);

//        Console.WriteLine("Event added successfully!");
//    }
//    static void AddTask(ServiceFactory serviceFactory)
//    {
//        var taskRepository = serviceFactory.CreatePlanningTaskRepository();

//        Console.WriteLine("\nAdd a task:");
//        Console.Write("Description: ");
//        var description = Console.ReadLine();

//        Console.Write("Assigned to (responsible name): ");
//        var assignedTo = Console.ReadLine();

//        Console.Write("Task completed? (true/false): ");
//        var doneInput = Console.ReadLine();
//        bool done = bool.TryParse(doneInput, out done) && done;

//        var task = new PlanningTask
//        {
//            Description = description,
//            AssignedTo = assignedTo,
//            Done = done
//        };

//        taskRepository.Add(task);
//        Console.WriteLine("Task added successfully!");
//    }
//    #endregion

//    #region Show
//    static void ShowGuests(ServiceFactory serviceFactory)
//    {
//        var guestRepository = serviceFactory.CreateGuestRepository();
//        var guests = guestRepository.GetAll();

//        Console.WriteLine("\nGuests list:");
//        foreach (var guest in guests)
//        {
//            Console.WriteLine($"ID: {guest.GuestId}, Nume: {guest.Name}, Email: {guest.Email}, RSVP: {guest.RSVP}");
//        }
//    }
//    static void ShowSuppliers(ServiceFactory serviceFactory)
//    {
//        var supplierRepository = serviceFactory.CreateSupplierRepository();
//        var suppliers = supplierRepository.GetAll();

//        Console.WriteLine("\nSuppliers List:");
//        foreach (var supplier in suppliers)
//        {
//            Console.WriteLine($"ID: {supplier.SupplierId}, Name: {supplier.Name}, Service: {supplier.Service}, Contact: {supplier.Contact}");
//        }
//    }
//    static void ShowEvents(ServiceFactory serviceFactory)
//    {
//        var eventRepository = serviceFactory.CreateEventRepository();
//        var events = eventRepository.GetAll();

//        Console.WriteLine("\nEvents Lists:");
//        foreach (var eventItem in events)
//        {
//            Console.WriteLine($"ID: {eventItem.EventId}, Title: {eventItem.Title}, Location: {eventItem.Location}, Date: {eventItem.Date.ToShortDateString()}");
//        }
//    }
//    static void ShowTasks(ServiceFactory serviceFactory)
//    {
//        var taskRepository = serviceFactory.CreatePlanningTaskRepository();
//        var tasks = taskRepository.GetAll();

//        Console.WriteLine("\nTasks List:");
//        foreach (var task in tasks)
//        {
//            Console.WriteLine($"ID: {task.PlanningTaskId}, Description: {task.Description}, Assigned To: {task.AssignedTo}, Completed: {(task.Done ? "Da" : "Nu")}");
//        }
//    }
//    #endregion

//    #region update
//    static void UpdateGuest(ServiceFactory serviceFactory)
//    {
//        var guestRepository = serviceFactory.CreateGuestRepository();

//        Console.Write("\nEnter the guest ID to update: ");
//        var id = int.Parse(Console.ReadLine());
//        var guest = guestRepository.GetById(id);

//        if (guest == null)
//        {
//            Console.WriteLine("The guest was not found!");
//            return;
//        }

//        Console.WriteLine("Update guest information:");
//        Console.Write("Name (leave blank to not change):");
//        var name = Console.ReadLine();
//        if (!string.IsNullOrEmpty(name)) guest.Name = name;

//        Console.Write("Email (leave blank to not change): ");
//        var email = Console.ReadLine();
//        if (!string.IsNullOrEmpty(email)) guest.Email = email;

//        Console.Write("RSVP (true/false): ");
//        var rsvpInput = Console.ReadLine();
//        bool rsvp = bool.TryParse(rsvpInput, out rsvp);
//        guest.RSVP = rsvp;

//        guestRepository.Update(guest);
//        Console.WriteLine("Guest successfully updated!");
//    }
//    static void UpdateSupplier(ServiceFactory serviceFactory)
//    {
//        var supplierRepository = serviceFactory.CreateSupplierRepository();

//        Console.Write("\nEnter the provider ID to update: ");
//        var id = int.Parse(Console.ReadLine());
//        var supplier = supplierRepository.GetById(id);

//        if (supplier == null)
//        {
//            Console.WriteLine("Provider not found!");
//            return;
//        }

//        Console.WriteLine("Update provider information:");
//        Console.Write("Name (leave blank to not change): ");
//        var name = Console.ReadLine();
//        if (!string.IsNullOrEmpty(name)) supplier.Name = name;

//        Console.Write("Service (leave blank to not change): ");
//        var service = Console.ReadLine();
//        if (!string.IsNullOrEmpty(service)) supplier.Service = service;

//        Console.Write("Contact (leave blank to not change): ");
//        var contact = Console.ReadLine();
//        if (!string.IsNullOrEmpty(contact)) supplier.Contact = contact;

//        supplierRepository.Update(supplier);
//        Console.WriteLine("Provider updated successfully!");
//    }
//    static void UpdateEvent(ServiceFactory serviceFactory)
//    {
//        var eventRepository = serviceFactory.CreateEventRepository();

//        Console.Write("\nEnter the event ID to update: ");
//        var id = int.Parse(Console.ReadLine());
//        var eventItem = eventRepository.GetById(id);

//        if (eventItem == null)
//        {
//            Console.WriteLine("Event not found!");
//            return;
//        }

//        Console.WriteLine("Update event information:");
//        Console.Write("Title (leave blank to not change): ");
//        var title = Console.ReadLine();
//        if (!string.IsNullOrEmpty(title)) eventItem.Title = title;

//        Console.Write("Location (leave blank to not change): ");
//        var location = Console.ReadLine();
//        if (!string.IsNullOrEmpty(location)) eventItem.Location = location;

//        Console.Write("Date (yyyy-mm-dd, leave blank to not change): ");
//        var dateInput = Console.ReadLine();
//        if (!string.IsNullOrEmpty(dateInput))
//        {
//            DateTime date;
//            if (DateTime.TryParse(dateInput, out date))
//            {
//                eventItem.Date = date;
//            }
//            else
//            {
//                Console.WriteLine("Invalid date. Date change not made.");
//            }
//        }

//        eventRepository.Update(eventItem);
//        Console.WriteLine("Event updated successfully!");
//    }
//    static void UpdateTask(ServiceFactory serviceFactory)
//    {
//        var taskRepository = serviceFactory.CreatePlanningTaskRepository();

//        Console.Write("\nEnter the ID of the task to update: ");
//        var id = int.Parse(Console.ReadLine());
//        var task = taskRepository.GetById(id);

//        if (task == null)
//        {
//            Console.WriteLine("Task not found!");
//            return;
//        }

//        Console.WriteLine("Update task information:");
//        Console.Write("Description (leave blank to not modify): ");
//        var description = Console.ReadLine();
//        if (!string.IsNullOrEmpty(description)) task.Description = description;

//        Console.Write("Assigned to (leave blank to not change): ");
//        var assignedTo = Console.ReadLine();
//        if (!string.IsNullOrEmpty(assignedTo)) task.AssignedTo = assignedTo;

//        Console.Write("Task completed? (true/false): ");
//        var doneInput = Console.ReadLine();
//        bool done = bool.TryParse(doneInput, out done);
//        task.Done = done;

//        taskRepository.Update(task);
//        Console.WriteLine("Task updated successfully!");
//    }
//    #endregion

//    #region Delete
//    static void DeleteGuest(ServiceFactory serviceFactory)
//    {
//        var guestRepository = serviceFactory.CreateGuestRepository();

//        Console.Write("\nEnter the ID of the guest to delete: ");
//        var id = int.Parse(Console.ReadLine());
//        guestRepository.Delete(id);

//        Console.WriteLine("Guest successfully deleted!");
//    }
//    static void DeleteSupplier(ServiceFactory serviceFactory)
//    {
//        var supplierRepository = serviceFactory.CreateSupplierRepository();

//        Console.Write("\nEnter the provider ID to delete: ");
//        var id = int.Parse(Console.ReadLine());
//        supplierRepository.Delete(id);

//        Console.WriteLine("Supplier successfully deleted!");
//    }
//    static void DeleteEvent(ServiceFactory serviceFactory)
//    {
//        var eventRepository = serviceFactory.CreateEventRepository();

//        Console.Write("\nEnter the event ID to delete: ");
//        var id = int.Parse(Console.ReadLine());
//        eventRepository.Delete(id);

//        Console.WriteLine("Event successfully deleted!");
//    }
//    static void DeleteTask(ServiceFactory serviceFactory)
//    {
//        var taskRepository = serviceFactory.CreatePlanningTaskRepository();

//        Console.Write("\nEnter the ID of the task to delete: ");
//        var id = int.Parse(Console.ReadLine());
//        taskRepository.Delete(id);

//        Console.WriteLine("Task deleted successfully!");
//    }
//    #endregion
//}

using PartyPlanner.Models;
using PartyPlanner.Repositories;
using PartyPlanner.Repositories.Interfaces;
using System;

class Program
{
    static void Main()
    {
        var factory = new RepositoryFactory();

        var guestRepo = factory.CreateRepository<Guest>();
        var supplierRepo = factory.CreateRepository<Supplier>();
        var eventRepo = factory.CreateRepository<Event>();
        var taskRepo = factory.CreateRepository<PlanningTask>();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("===== Party Planner =====");
            Console.WriteLine("1. Guests");
            Console.WriteLine("2. Suppliers");
            Console.WriteLine("3. Events");
            Console.WriteLine("4. Tasks");
            Console.WriteLine("0. Exit");
            Console.Write("Choose section: ");

            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    EntityMenu(guestRepo, "Guest");
                    break;
                case "2":
                    EntityMenu(supplierRepo, "Supplier");
                    break;
                case "3":
                    EntityMenu(eventRepo, "Event");
                    break;
                case "4":
                    EntityMenu(taskRepo, "Task");
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Invalid option. Press any key...");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void EntityMenu<T>(IRepository<T> repository, string entityName) where T : BaseEntity, new()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"===== {entityName} Menu =====");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Show All");
            Console.WriteLine("3. Update");
            Console.WriteLine("4. Delete");
            Console.WriteLine("0. Back");
            Console.Write("Choose option: ");

            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    var newItem = CreateEntity<T>();
                    if (newItem != null) repository.Add(newItem);
                    break;
                case "2":
                    ShowAllEntities(repository);
                    break;
                case "3":
                    UpdateEntity(repository);
                    break;
                case "4":
                    DeleteEntity(repository);
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Invalid option. Press any key...");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void ShowAllEntities<T>(IRepository<T> repository) where T : BaseEntity
    {
        Console.Clear();
        var entities = repository.GetAll();
        if (entities.Any())
        {
            foreach (var item in entities)
                Console.WriteLine(itemToString(item));
        }
        else
        {
            Console.WriteLine("No data found.");
        }
        Console.WriteLine("Press any key...");
        Console.ReadKey();
    }

    static void UpdateEntity<T>(IRepository<T> repository) where T : BaseEntity
    {
        Console.Write("Enter ID to update: ");
        if (int.TryParse(Console.ReadLine(), out int updateId))
        {
            var existing = repository.GetById(updateId);
            if (existing != null)
            {
                var updated = CreateEntity<T>();
                if (updated != null)
                {
                    updated.Id = updateId;
                    repository.Update(updated);
                    Console.WriteLine($"{typeof(T).Name} updated successfully!");
                }
            }
            else
            {
                Console.WriteLine("Entity not found.");
            }
        }
        else
        {
            Console.WriteLine("Invalid ID.");
        }
        Console.WriteLine("Press any key...");
        Console.ReadKey();
    }

    static void DeleteEntity<T>(IRepository<T> repository) where T : BaseEntity
    {
        Console.Write("Enter ID to delete: ");
        if (int.TryParse(Console.ReadLine(), out int deleteId))
        {
            var entity = repository.GetById(deleteId);
            if (entity != null)
            {
                repository.Delete(deleteId);
                Console.WriteLine($"{typeof(T).Name} with ID {deleteId} deleted successfully!");
            }
            else
            {
                Console.WriteLine("Entity not found.");
            }
        }
        else
        {
            Console.WriteLine("Invalid ID.");
        }
        Console.WriteLine("Press any key...");
        Console.ReadKey();
    }

    static T CreateEntity<T>() where T : BaseEntity
    {
        Console.Clear();
        if (typeof(T) == typeof(Guest))
        {
            Console.Write("Name: ");
            var name = Console.ReadLine();

            Console.Write("Email: ");
            var email = Console.ReadLine();

            Console.Write("RSVP (true/false): ");
            bool.TryParse(Console.ReadLine(), out bool rsvp);

            return new Guest(name, email, rsvp) as T;
        }
        else if (typeof(T) == typeof(Supplier))
        {
            Console.Write("Name: ");
            var name = Console.ReadLine();

            Console.Write("Service: ");
            var service = Console.ReadLine();

            Console.Write("Contact: ");
            var contact = Console.ReadLine();

            return new Supplier(name, service, contact) as T;
        }
        else if (typeof(T) == typeof(Event))
        {
            Console.Write("Title: ");
            var title = Console.ReadLine();

            Console.Write("Location: ");
            var location = Console.ReadLine();

            Console.Write("Date (yyyy-MM-dd): ");
            DateTime.TryParse(Console.ReadLine(), out DateTime date);

            return new Event(title, location, date) as T;
        }
        else if (typeof(T) == typeof(PlanningTask))
        {
            Console.Write("Description: ");
            var desc = Console.ReadLine();

            Console.Write("Assigned To: ");
            var assigned = Console.ReadLine();

            Console.Write("Is Done (true/false): ");
            bool.TryParse(Console.ReadLine(), out bool done);

            return new PlanningTask(desc, assigned, done) as T;
        }

        return null;
    }

    static string itemToString<T>(T item) where T : BaseEntity
    {
        if (item is Guest g)
            return $"[ID {g.Id}] Guest: {g.Name}, Email: {g.Email}, RSVP: {g.RSVP}";
        if (item is Supplier s)
            return $"[ID {s.Id}] Supplier: {s.Name}, Service: {s.Service}, Contact:{s.Contact}";
        if (item is Event e)
            return $"[ID {e.Id}] Event: {e.Title}, {e.Location}, {e.Date.ToShortDateString()}";
        if (item is PlanningTask t)
            return $"[ID {t.Id}] Task: {t.Description}, Assigned: {t.AssignedTo}, Done: {t.Done}";
        return $"[ID {item.Id}] Unknown entity";
    }
}

