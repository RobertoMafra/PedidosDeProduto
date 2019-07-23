using System;
using System.Collections.Generic;
using System.Text;

namespace PedidoDeProduto.Entities
{
    class Client
    {
        //Atributos
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDay { get; set; }

        //Construtores
        public Client()
        {

        }

        public Client(string name, string email, DateTime birthDay)
        {
            Name = name;
            Email = email;
            BirthDay = birthDay;
        }

        //Metodos
        public override string ToString()
        {
            return Name + "(" + BirthDay.ToString("dd/MM/yyy")  + ") - " + Email;
        }
    }
}
