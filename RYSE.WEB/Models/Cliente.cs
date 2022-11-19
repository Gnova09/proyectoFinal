namespace RYSE.WEB.Models
{
    public class Cliente : Person
    {
      

        public int  IDCedula  { get; set; }

        public DateTime FechaNacimiento { get; set;}

        public  string? Usuario { get; set; }

        public string? Email { get; set; }


        public string? Contraseña { get; set; }


        public string? Direccion { get; set; }




    }
}
