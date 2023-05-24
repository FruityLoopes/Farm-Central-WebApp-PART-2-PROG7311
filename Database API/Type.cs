namespace Database_API
{
    public class Type
    {
        private static Type instance;

        private Type()
        {

        }

        public static Type getInstance()
        {
            if (instance == null)
            {
                instance = new Type();
            }
            return instance;
        }

        public String[] All(String[] Products)
        {
            return Products;
        }

       

    }
}
