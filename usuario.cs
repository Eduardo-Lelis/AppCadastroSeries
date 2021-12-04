namespace DIO.Series
{
    public class User
    {
        public string nome {get; set;}
        public Classeuser varclassuser {get; set;}

        //metodos
    
    public User (string nusuario, Classeuser classeuser)
    {
        this.nome=nusuario;
        this.varclassuser=classeuser;
    }

    }

}