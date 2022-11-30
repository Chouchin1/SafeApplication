using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace SafeApplication
{
    public class Safe
    {
        public Safe(IUserInput input) {
            lockUnlockRand();
            enterNum(input);
        }

        Random rnd = new Random();
        int[] code = { 1, 8, 7, 3, 8 };
        bool locked = true;
        bool quit = false;
        int nextNum = 0;
        public void lockUnlockRand()
        {
            int entry;
            int nextNum = 0;
            int count = 0;
            while (!quit)
            {
                entry = rnd.Next(0, 9);

                count = count + 1;
                switch (nextNum)
                {
                    default:
                        if (entry == code[nextNum])
                            nextNum++;
                        else if (entry == code[0])
                            nextNum = 1;
                        else nextNum = 0;
                        break;
                    case 5:
                        if (entry == 1)
                        {
                            System.Console.WriteLine("Unlocked");
                            System.Console.WriteLine(count);
                            locked = false;
                            nextNum = 0;
                            quit = true;
                        }
                        else nextNum = 0;
                        break;
                }
            }
        }
        public void lockUnlock(string entry)
        {
            int currentVal;
            for (int i = 0; i < entry.Length; i++)
            {
                if (int.TryParse(entry[i].ToString(), out currentVal))
                {
                    switch (nextNum)
                    {
                        default:
                            if (currentVal == code[nextNum])
                                nextNum++;
                            else if (currentVal == code[0])
                                nextNum = 1;
                            else nextNum = 0;
                            break;
                        case 5:
                            if (currentVal == 1)
                            {
                                if (locked == true)
                                {
                                    System.Console.WriteLine("Unlocked");
                                    locked = false;
                                    nextNum = 0;
                                }
                                else nextNum = 1;
                            }
                            else if (currentVal == 4 && locked == false)
                            {
                                System.Console.WriteLine("Locked");
                                locked = true;
                                nextNum = 0;
                            }
                            else nextNum = 0;
                            break;
                    }
                }
            }
        }

        public void enterNum(IUserInput input)
        {
            string entry;
            do
            {
                System.Console.WriteLine("Enter code or QUIT to exit:");
                entry = input.GetInput();
                lockUnlock(entry);
            } while (entry != "QUIT");
        }
        public bool getlocked()
        {
            return locked;
        }

        public interface IUserInput
        {
            string GetInput();
        }

        public class Something : IUserInput
        {
            public string GetInput()
            {
                return System.Console.ReadLine()+"";
            }
        }

        public class FakeUserInput: IUserInput
        {
            public string GetInput()
            {
                return "QUIT";
            }
        }
    }
}
