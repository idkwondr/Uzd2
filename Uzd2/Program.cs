var employees = new List<Employee>
{
    new FullTimeEmployee("Anna", 1200m),
    new HourlyEmployee("Jānis", 8m, 100),
    new SalesEmployee("Marta", 500m, 4000m)
};

foreach (Employee e in employees)
{
    Console.WriteLine($"{e.Name}: {e.CalculateSalary():F2}");
}

var payroll = new PayrollCalculator();
Console.WriteLine($"Kopā: {payroll.TotalSalary(employees):F2}");

// Paskaidrojums:
// Polimorfisms ir redzams PayrollCalculator.TotalSalary() metodē, kur tiek iterēts pa sarakstu ar
// Employee tipa objektiem. Katram objektam tiek izsaukta CalculateSalary() metode, kura izpildās
// dažādi atkarībā no objekta faktiskā tipa (FullTimeEmployee, HourlyEmployee vai SalesEmployee).
// 
// PayrollCalculator nebija jāmaina, jo tas darbojās ar abstrakto Employee klasi un izsauca
// abstrakto metodi CalculateSalary(). Tas atbilst Open/Closed Principle (OCP):
// klase ir ATVĒRTA paplašinājumiem (var pievienot jaunas Employee apakšklases)
// un AIZVĒRTA modifikācijai (PayrollCalculator kods palika nemainīts).