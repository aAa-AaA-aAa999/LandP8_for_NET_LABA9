//Создать классы-наследники из 8 ЛР, хранящие логины и пароли.
//При регистрации пользователей логины и пароли добавляются в массивы.

using System;
using System.Collections.Generic;

namespace L9
{
    public class Array_Class<T>
    {
        List<T> list = new List<T> { };

        public Array_Class()
        {
        }
        public void AddElem(T item) 
        {
            list.Add(item);
        }
        public void DeleteElem(T item) 
        {
            list.Remove(item);
        }
        public T GetElem(int index) 
        {
            return list[index];
        }
        public int GetLength() 
        {
            return list.Lenght;
        }
    }

    public class Login : Array_Class<string>
    {
    }

    public class Password<T> : Array_Class<T>
    {
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Login login = new Login();
            login.AddElem("Eckhart");
            login.AddElem("Tolle");

            Password<string> password = new Password<string>();
            password.AddElem("Z223Ik332l2L");
            password.AddElem("L332Ki223z3Z");
        }
    }
}
