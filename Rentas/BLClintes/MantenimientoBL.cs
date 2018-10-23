using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLClintes
{

        public class MantenimientoBL
    {
        //propiedad para hacer la lista de los clientes.
        //tambien tiene su propia libreria.
        public BindingList<Cliente> ListaCliente { get; set; }

        public MantenimientoBL()

    {
        ListaCliente = new BindingList<Cliente>();

        var Cliente1 = new Cliente();
        Cliente1.ID = 1;
        Cliente1.Nombre = "Hello Kitty";
        Cliente1.Identidad = "0001158912345";
        Cliente1.Telefono = 55555555;
        Cliente1.Email = null;
        Cliente1.Activo = true;

        ListaCliente.Add(Cliente1);

        var Cliente2 = new Cliente();
            Cliente2.ID = 2;
            Cliente2.Nombre = "Winny Pooh";
            Cliente2.Identidad = "0512859645678";
            Cliente2.Telefono = 223121588;
            Cliente2.Email = null;
            Cliente2.Activo = true;

            ListaCliente.Add(Cliente2);

            var Cliente3 = new Cliente();
            Cliente3.ID = 3;
            Cliente3.Nombre = "Totoro";
            Cliente3.Identidad = "0236852978945";
            Cliente3.Telefono = 223121588;
            Cliente3.Email = "shimigamidelbosque@totoro.gar";
            Cliente3.Activo = true;

            ListaCliente.Add(Cliente3);


            var Cliente4 = new Cliente();
            Cliente4.ID = 4;
            Cliente4.Nombre = "Sailor Moon";
            Cliente4.Identidad = "0236852978945";
            Cliente4.Telefono = 223121588;
            Cliente4.Email = "conejo06@sailor.moon";
            Cliente4.Activo = true;

            ListaCliente.Add(Cliente4);


            var Cliente5 = new Cliente();
            Cliente5.ID = 5;
            Cliente5.Nombre = "Full Metal Alchemist";
            Cliente5.Identidad =" 0236852978945";
            Cliente5.Telefono = 223121588;
            Cliente5.Email = "elgranfuhrer@alquimista.acero";
            Cliente5.Activo = true;


            // aqui se guarda el cliente que acabamos de crear.


            ListaCliente.Add(Cliente5);

        }

            //metodo/  funcion para retornar la lista de cliente. 
        public BindingList<Cliente> VerCliente()
    {
        return ListaCliente;
    }

        public bool GuardarCliente(Cliente cliente)
        {
            if (cliente.ID == 0)
            {
                cliente.ID = ListaCliente.Max(item => item.ID) + 1 ;
            }
            return true;
        }

        public void AgregarCliente()
        {
            var nuevoCliente = new Cliente();
            ListaCliente.Add(nuevoCliente);
        }


        public bool EliminarCliente(int id)
        {
            foreach (var producto in ListaCliente)
            {
                if (producto.ID == id)
                {
                    ListaCliente.Remove(producto);
                    return true;
                }
            }

            return false;
        }

        
    public class Cliente
        {
           public int ID { get; set; }
            public string Nombre { get; set; }
            public string Identidad { get; set; }
            public int Telefono { get; set; }
            public string Email { get; set; }
            public bool Activo { get; set; }


        }
    }
}
