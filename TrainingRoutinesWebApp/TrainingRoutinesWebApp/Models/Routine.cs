namespace TrainingRoutinesWebApp.Models
{
    public class Routine
    {
        public int Id{ get; set; }

        public string Titulo { get; set; }  
        public string Descripcion { get; set; }
        public int Duracion { get; set; }
        public Routine()
        {
                
        }
    }
}
