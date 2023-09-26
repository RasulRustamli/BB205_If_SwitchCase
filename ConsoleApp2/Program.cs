
//if (select_number == '1')
//{
//    Console.WriteLine("Azerbaycan dili secildi");
//}
//else if (select_number == '2')
//{
//    Console.WriteLine("Rus dili secildi");
//}
//else if (select_number == '0')
//{
//    Console.WriteLine("Operatora baglanir");
//}
//else
//{
//    Console.WriteLine("Duzgun secim edin");
//}
int select_number = 1;

switch (select_number)
{
    case 1:
        Console.WriteLine("Azerbaycan dili secildi");
        break;
    case 2:
        Console.WriteLine("Rus dili secildi");
        break;
    case 0:
        Console.WriteLine("Operatora baglanir");
        break;
    default:
        Console.WriteLine("Duzgun secim edin");
        break;
}