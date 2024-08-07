namespace SimulacroPruebaC.models
{
    public class Vehicle
    {

        //miembros atributos
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Tipo { get; set; }
        public string EngineNumber { get; set; }
        public string SerialNumber { get; set; }
        public byte PeopleCapacity { get; set; }
        public Driver Owner {get; set;}

        //miembro constructor
        public Vehicle(string placa,string tipo,string eningerNumber,string serialNumber,byte peopleCapacity,Driver owner)
        {
            Placa = placa; 
            Tipo = tipo;
            EngineNumber = eningerNumber;
            SerialNumber = serialNumber;
            PeopleCapacity = peopleCapacity;
            Owner = owner;
        }

        //miembro borrar vehiculo
        public void DeleteVehicle(int id){
            
        }

        //miembro mostrar vehiculo
        public void ShowVehicles(){
            Console.WriteLine(@$"
            --------------------------------------- Vehiculo  -----------------------------------------
            Id : {Id} PLaca: {Placa,-5}, Tipo: {Tipo,-5},
            Numero de motor : {EngineNumber}, Numero de serie: {SerialNumber},
            Capacidad de persona :{PeopleCapacity} , Propietario {Owner},");
        }
    }
}