switch (valg)
                {
                    case "1":
                        Variabler.Run();
                        break;
                    case "2":
                        Inputs.Run();
                        break;
                    case "3":
                        ControlFlow.Run();
                        break;
                    case "4":
                        Loops.Run();
                        break;
                    case "5":
                        Arrays.Run();
                        break;
                    case "6":
                        Methods.Run();
                        break;
                    case "7":
                        Classes.Run();
                        break;
                    case "8":
                        RockPaperScissors.Run();
                        break;
                    case "!":
                        run = false;
                        Console.WriteLine("Programmet afsluttes. Tak for denne gang!");
                        break;
                    case "?":
                        Hjælp();
                        break;
                    default:
                        Console.WriteLine("Ugyldigt valg!");
                        Console.Write("Indtast dit valg: ");

                        break;
                }