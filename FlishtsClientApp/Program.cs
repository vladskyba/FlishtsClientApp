using FlishtsClientApp.Enums;
using UserWcfReference;

UserServiceClient client = new UserServiceClient();
bool isWorking = true;

while (isWorking)
{
    Console.Clear();
    var operation = DetermineOperation();
    Console.Clear();

    switch (operation)
    {
        case Operations.GetAll:
        {
            var users = await client.GetAllUsersAsync();

            foreach (var user in users)
            {
                Console.WriteLine(user);
            }

            break;
        }
        case Operations.Get:
        {
            Console.WriteLine("Input identifier: ");
            int.TryParse(Console.ReadLine(), out var identidier);

            Console.Clear();
            Console.WriteLine(await client.GetByIdAsync(identidier));

            break;
        }
        case Operations.Delete:
        {
            Console.WriteLine("Input identifier: ");
            int.TryParse(Console.ReadLine(), out var identidier);

            Console.Clear();
            await client.DeleteAsync(identidier);
            Console.WriteLine("Operation executed");
            break;
        }
        case Operations.Add:
        {
            Console.Clear();

            await client.AddAsync(GetUser());
            Console.WriteLine("Operation executed");
            break;
        }
        case Operations.Update:
        {
            Console.Clear();

            Console.WriteLine("Input identifier: ");
            int.TryParse(Console.ReadLine(), out var identidier);

            var user = GetUser();
                user.Id = identidier;

            await client.UpdateAsync(user);
            Console.WriteLine("Operation executed");
            break;
        }
        default:
            break;
    }

    isWorking = TryContinue();
}

bool TryContinue()
{
    Console.WriteLine("\nDo you want to continue? (Yes or No)");
    var decision = Console.ReadLine();
    switch (decision)
    {
        case "Yes":
            return true;
        case "No":
            return default;
        default:
            Console.Clear();
            Console.WriteLine("Incorrect input. Try again :)");
            return TryContinue();
    }
}

Operations DetermineOperation()
{
    Console.WriteLine("Choose operation (GetAll, Get, Add, Update, Delete)");
    var input = Console.ReadLine();

    if (!Operations.TryParse(input, out Operations output))
    {
        Console.Clear();
        Console.WriteLine("Incorrect input. Try again :)");
        return DetermineOperation();
    }

    return output;
}

User GetUser()
{
    var user = new User();

    Console.WriteLine("Input first name: ");
    user.FirstName = Console.ReadLine();

    Console.WriteLine("Input last name: ");
    user.LastName = Console.ReadLine();

    Console.WriteLine("Input middle name: ");
    user.MiddleName = Console.ReadLine();

    Console.WriteLine("Input phone: ");
    user.Phone = Console.ReadLine();

    return user;
}