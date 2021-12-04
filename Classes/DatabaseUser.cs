namespace DIO.Series
{
    public class DatabaseUser
    {
     public string name { get; protected set; }
     public int cpf {get; protected set;}
    
    //metodos
        public DatabaseUser(string name, int cpf)
		{
			this.name = name;
			this.cpf = cpf;
			
        }
    }
}