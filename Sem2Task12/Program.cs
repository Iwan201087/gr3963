
       
            Console.WriteLine("Ведите первое число:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ведите второе число:");
            int num2 = int.Parse(Console.ReadLine());
            if (num2 % num1 == 0)
            {
                Console.WriteLine("Второе число кратно первому.");
            }
            else
            {
                Console.WriteLine("Второе число не кратно первому. Остаток " + (num2 % num1));
            }
        
