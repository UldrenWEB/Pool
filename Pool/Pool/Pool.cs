using Npgsql;

namespace Pool
{
    class Pool
    {
        private static Pool? instance = null;

        private Pool() { }

        //Patron de diseño singleton

        public static Pool GetInstance()
        {
            //Aqui usamos una asignacion compuesta de C# que significa que si instance es igual a null
            //entonces sera igual a esa instancia
            instance ??= new Pool();


            return instance;
        }


        public List<NpgsqlConnection> CreatePool()
        {

            List<NpgsqlConnection> connects = new();


            return connects;
        }
    }
}
