using System;
using System.Collections.Generic;
using System.Linq;

namespace Programeringsprojekt_samhälle_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Hospital> hospitals = new List<Hospital>();
            List<FireStation> firestations = new List<FireStation>();
            List<PoliceStation> policeStations = new List<PoliceStation>();
            List<Bank> banks = new List<Bank>();
            List<Entertainment> entertainments = new List<Entertainment>();
            List<Store> stores = new List<Store>();


            string typeOfEmergencyService;
            string typeOfBuilding;
            int x = 1;
            while (x == 1)
            {
            //Meny som visar allt som går att göra
            //-------------------------------------------------------------------
            Console.WriteLine("\nVad vill du göra?");
            Console.WriteLine("Skriv:");
            Console.WriteLine("1 - Sjukhus");
            Console.WriteLine("2 - Brandstation");
            Console.WriteLine("3 - Polisstation");
            Console.WriteLine("4 - Bank");
            Console.WriteLine("5 - Underhållning");
            Console.WriteLine("6 - Butik");
            Console.WriteLine("7 - Skriv ut en lista på allt");
            Console.WriteLine("8 - Exit");
            int svar = int.Parse(Console.ReadLine());
            //-------------------------------------------------------------------
           
                switch (svar)
                {
                    // Creating hospital
                    
                    case 1:
                        int h = 1;
                        while (h == 1)
                        {
                            Console.WriteLine("\nVad vill du göra?");
                            Console.WriteLine("1 - Skapa ett nytt sjukhus");
                            Console.WriteLine("2 - Visa en lista på alla sjukhus");
                            Console.WriteLine("3 - Gå tillbaka");
                            int caseone = int.Parse(Console.ReadLine());
                            switch (caseone)
                            {
                                case 1:
                                    typeOfEmergencyService = "Sjukhus";
                                    Console.WriteLine("Vad heter sjukhuset?");
                                    string name = Console.ReadLine();
                                    Console.WriteLine("Skriv med siffror hur många ambulanser sjukhuset har");
                                    int numOfAmbulances = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Skriv med siffror hur många patienter sjukhuset kan ta emot");
                                    int maxNumOfPatients = int.Parse(Console.ReadLine());
                                    hospitals.Add(new Hospital(name, numOfAmbulances, typeOfEmergencyService, maxNumOfPatients));
                                    break;

                                case 2:
                                    foreach (var hospital in hospitals)
                                    {
                                        Console.WriteLine($"        Id: {hospital.Id} |  Namn: {hospital.Name} |  Antal fordon: {hospital.Ambulance} |  Platser för patienter: {hospital.NumberOfPatients}\n");
                                    }
                                    break;
                                case 3:
                                    h = 0;
                                    break;
                                default:
                                    h = 0;
                                    break;
                            }
                            
                        }
                        break;

                    // Creating fire station
                 case 2:
                        int f = 1;
                        while (f == 1)
                        {
                            Console.WriteLine("\nVad vill du göra?");
                            Console.WriteLine("1 - Skapa en ny brandstation");
                            Console.WriteLine("2 - Visa en lista på alla brandstationer");
                            Console.WriteLine("3 - Gå tillbaka");
                            int casetwo = int.Parse(Console.ReadLine());
                            switch (casetwo)
                            {
                                case 1:
                                    typeOfEmergencyService = "Brandstation";
                                    Console.WriteLine("Skriv namnet på Brandstationien");
                                    string name = Console.ReadLine();
                                    Console.WriteLine("Skriv med siffror hur många brandbilar brandstationen har");
                                    int numOfFireTrucks = int.Parse(Console.ReadLine());
                                    int numberOfPatients = 0;
                                    firestations.Add(new FireStation(name, typeOfEmergencyService, numberOfPatients, numOfFireTrucks));
                                    break;
                                case 2:
                                    foreach (var firestation in firestations)
                                    {
                                        Console.WriteLine($"      Id: {firestation.Id} |  Namn: {firestation.name} |  Antal fordon: {firestation.FireTrucks } \n| ");
                                    }
                                    break;
                                case 3:
                                    f = 0;
                                    break;
                                default:
                                    f = 0;
                                    break;
                            }
                        }
                        break;

                    // Police station
                    case 3:
                        int p = 1;
                        while (p == 1)
                        {
                            Console.WriteLine("\nVad vill du göra?");
                            Console.WriteLine("1 - Skapa en polisstation");
                            Console.WriteLine("2 - Visa en lista över polisstationer");
                            Console.WriteLine("3 - Gå tillbaka");
                            int casethree = int.Parse(Console.ReadLine());
                            switch (casethree)
                            {
                                            // Skapar polisstation
                                case 1:
                                    typeOfEmergencyService = "Polisstation";
                                    Console.WriteLine("\nVar ska polisstationen vara?");
                                    string location = Console.ReadLine();
                                    Console.WriteLine("Skriv med siffror hur många polisbilar polis stationen har");
                                    int numOfPoliceCars = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Skriv med nummer hur många anhängda är i police stationen");
                                    int numOfPatients = int.Parse(Console.ReadLine());
                                    Console.WriteLine("");
                                    policeStations.Add(new PoliceStation(location, numOfPoliceCars, typeOfEmergencyService, numOfPatients));
                                    break;

                                            // Visar lista över polisstationer
                                case 2:
                                    foreach (var policeStation in policeStations)
                                    {
                                        Console.WriteLine($"      Id: {policeStation.Id} |  Plats: {policeStation.Location} |  Antal fordon: {policeStation.Policecars} |  Platser för häktade: {policeStation.NumberOfPatients}\n");
                                    }
                                    break;
                                case 3:
                                    p = 0;
                                    break;
                                default:
                                    p = 0;
                                    break;
                            }
                        }
                        break;

                    // Skapande av bank
                    case 4:
                        int b = 1;
                        while (b == 1) { 
                               Console.WriteLine("\nVad vill du göra?");
                               Console.WriteLine("1 - Skapa en bank");
                               Console.WriteLine("2 - Visa en lista över banker");
                               Console.WriteLine("3 - Gå tillbaka");
                               int casefour = int.Parse(Console.ReadLine());
                                   switch (casefour)
                                    {
                                        case 1:
                                            typeOfBuilding = "bank";
                                            Console.WriteLine("skriv med siffror hur många konton banken har");
                                            int NumberOfAccounts = int.Parse(Console.ReadLine());
                                            Console.WriteLine("vilken valuta vill du använda?");
                                            string currency = Console.ReadLine();
                                            banks.Add(new Bank(typeOfBuilding, currency, NumberOfAccounts));

                                    break;

                                        case 2:
                                            foreach (var bank in banks)
                                            {
                                                Console.WriteLine($"      Id: {bank.Id} |  Antal konton: {bank.NumberOfAccouts} |  Vilken typ av valuta: {bank.currency}\n");
                                            }
                                    break;

                                        case 3:
                                            b = 0;
                                    break;

                                        default:
                                            b = 0;
                                    break;
                                    }
                            }
                    break;
                       
                        // undehållning
                    
                    case 5:
                        int u = 1;
                        while (u == 1)
                        {
                            Console.WriteLine("\nVad vill du göra?");
                            Console.WriteLine("1 - Skapa en ny underhålning");
                            Console.WriteLine("2 - Visa en lista på alla underhållningar");
                            Console.WriteLine("3 - Gå tillbaka");
                            int casefive = int.Parse(Console.ReadLine());
                            switch (casefive)
                            {
                                case 1:

                                typeOfBuilding = "underhållning";
                                Console.WriteLine("Vad heter underhållningen");
                                string name = Console.ReadLine();
                                Console.WriteLine("Skriv vart underhållningen ligger");
                                string location = Console.ReadLine();
                                Console.WriteLine("Skriv vilken akrivitet som görs här ");
                                string activity = Console.ReadLine();
                                entertainments.Add(new Entertainment(name, location, activity));
                                break;

                                case 2:
                                    foreach (var entertanment in entertainments)
                                    {
                                        Console.WriteLine($"      Id: {entertanment.Id} |  Namn: {entertanment.Name} |  Plats: {entertanment.Location} |  Aktivitet: {entertanment.Activity}\n");
                                    }
                                    break;
                                case 3:
                                    u = 0;
                                    break;
                                default:
                                    u = 0;
                                    break;
                    }

                }
                break;
                    case 6:
                        int s = 1;
                        while (s == 1)
                        {
                            Console.WriteLine("\nVad vill du göra?");
                            Console.WriteLine("1 - Skapa en ny butik");
                            Console.WriteLine("2 - Visa en lista på alla butiker");
                            Console.WriteLine("3 - Gå tillbaka");
                            int casesix = int.Parse(Console.ReadLine());
                            switch (casesix)
                            {
                                case 1:

                                    typeOfBuilding = "butik";
                                    Console.WriteLine("Skriv storleken på butiken i kvadratmeter");
                                    int size = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Skriv vad för butik det är");
                                    string type = (Console.ReadLine());
                                    Console.WriteLine("Skriv vart butliken ligger");
                                    string location = (Console.ReadLine());
                                    stores.Add(new Store(size,type, location));
                                    break;

                                case 2:
                                    foreach (var store in stores)
                                    {
                                        Console.WriteLine($"      Id: {store.Id} |  Storlek: {store.Size} Kvadrat meter |  Plats: {store.location} |  Typ av butik: {store.Type}\n");
                                    }
                                    break;

                                case 3:
                                    s = 0;
                                    break;

                                default:
                                    s = 0;
                                    break;
                            }
                        }
                        break;
                    case 7:
                        Console.WriteLine("<--------------------------------------------------------->\nSjukhus:\n");
                        foreach (var hospital in hospitals)
                        {
                            Console.WriteLine($"        Id: {hospital.Id} |  Namn: {hospital.Name} |  Antal fordon: {hospital.Ambulance} |  Platser för patienter: {hospital.NumberOfPatients}\n");
                        }

                        Console.WriteLine("<--------------------------------------------------------->\nBrandstationer:\n");
                        foreach (var firestation in firestations)
                        {
                            Console.WriteLine($"      Id: {firestation.Id} |  Namn: {firestation.name} |  Antal fordon: {firestation.FireTrucks } |\n ");
                        }

                        Console.WriteLine("<--------------------------------------------------------->\nPolicestationer:\n");
                        foreach (var policeStation in policeStations)
                        {
                            Console.WriteLine($"      Id: {policeStation.Id} |  Plats: {policeStation.Location} |  Antal fordon: {policeStation.Policecars} |  Platser för häktade: {policeStation.NumberOfPatients}\n");
                        }

                        Console.WriteLine("<--------------------------------------------------------->\nBanker:\n");
                        foreach (var bank in banks)
                        {
                            Console.WriteLine($"      Id: {bank.Id} |  Antal konton: {bank.NumberOfAccouts} |  Vilken typ av valuta: {bank.currency}\n");
                        }

                        Console.WriteLine("<--------------------------------------------------------->\nUndergållning:\n");
                        foreach (var entertanment in entertainments)
                        {
                            Console.WriteLine($"      Id: {entertanment.Id} |  Namn: {entertanment.Name} |  Plats: {entertanment.Location} |  Aktivitet: {entertanment.Activity}\n");
                        }

                        Console.WriteLine("<--------------------------------------------------------->\nButiker:\n");
                        foreach (var store in stores)
                        {
                            Console.WriteLine($"      Id: {store.Id} |  Storlek: {store.Size} Kvadrat meter |  Plats: {store.location} |  Typ av butik: {store.Type}\n");
                        }
                        break;


                    case 8:
                        x++;
                        // Exiting while loop
                        break;

                    default:
                        break;
                }
            }


        }
    }
}
